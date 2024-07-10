using System.Drawing;
using azure_data_migration_v1.Entities;
using azure_data_migration_v1.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NHibernate.Linq;

namespace azure_data_migration_v1.Pages
{
    public class BlobToFileStorage : PageModel
    {
        private readonly ILogger<BlobToFileStorage> _logger;
        dbContext _dbContext = new dbContext();


        public BlobToFileStorage(ILogger<BlobToFileStorage> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var mimPerson001sList = new List<MimPerson001>();
            if (!string.IsNullOrEmpty(Request.Query["name"].ToString()))
            {
                List<MimPerson001> mimPersonVwRecords = _dbContext.MimPerson001s.Where(p => p.MimPersonNameSurname == Request.Query["name"].ToString()).ToList();
                foreach (var record in mimPersonVwRecords)
                    if (!mimPerson001sList.Contains(record))
                        mimPerson001sList.Add(record);
                ViewData["name"] = Request.Query["name"].ToString();
            }

            if (!string.IsNullOrEmpty(Request.Query["surname"].ToString()))
            {
                List<MimPerson001> mimPersonVwRecords = _dbContext.MimPerson001s.Where(p => p.MimPersonNameSurname == Request.Query["surname"].ToString()).ToList();
                foreach (var record in mimPersonVwRecords)
                    if (!mimPerson001sList.Contains(record))
                        mimPerson001sList.Add(record);
                ViewData["surname"] = Request.Query["surname"].ToString();
            }

            if (!string.IsNullOrEmpty(Request.Query["mimcontrolid"].ToString()))
            {
                List<MimPerson001> mimPersonVwRecords = _dbContext.MimPerson001s.Where(p => p.MimPersonNameSurname == Request.Query["mimcontrolid"].ToString()).ToList();
                foreach (var record in mimPersonVwRecords)
                    if (!mimPerson001sList.Contains(record))
                        mimPerson001sList.Add(record);
                ViewData["mimcontrolid"] = Request.Query["mimcontrolid"].ToString();
            }
            ViewData["MimPersonVwList"] = mimPerson001sList;


            if (!string.IsNullOrEmpty(Request.Query["name"]) || !string.IsNullOrEmpty(Request.Query["surname"]) || !string.IsNullOrEmpty(Request.Query["mimcontrolid"]))
                ListMimControls();

            if (!string.IsNullOrEmpty(Request.Query["mci"]))
            {
                this.ListDocuments(Request.Query["mci"]);
            }

            if (!string.IsNullOrEmpty(Request.Query["ltf"]))
            {
                this.MoveBlobToFileStorage(Request.Query["ltf"]);
            }
        }

        public void OnPost()
        {
            bool isAdditionalVariable = false;
            string queryParameters = "/BlobToFileStorage?";

            //if (!string.IsNullOrEmpty(Request.Query["mci"]))
            //{
            //    queryParameters += "mci=" + Request.Query["mci"];
            //    isAdditionalVariable = true;
            //}
            if (!string.IsNullOrEmpty(Request.Form["Name"].ToString()))
            {
                if (isAdditionalVariable)
                    queryParameters += "&";
                queryParameters += "name=" + Request.Form["Name"].ToString();
                isAdditionalVariable = true;
            }
            if (!string.IsNullOrEmpty(Request.Form["Surname"].ToString()))
            {
                if (isAdditionalVariable)
                    queryParameters += "&";
                queryParameters += "surname=" + Request.Form["Surname"];
                isAdditionalVariable = true;
            }
            if (!string.IsNullOrEmpty(Request.Form["MIMControlID"].ToString()))
            {
                if (isAdditionalVariable)
                    queryParameters += "&";
                queryParameters += "mimcontrolid=" + Request.Form["MIMControlID"];
                isAdditionalVariable = true;
            }
            Response.Redirect(queryParameters);
        }

        public void ListMimControls()
        {
            var mimPerson001List = new List<MimPerson001>();
            List<MimPerson001> mimPerson001RecordsList = _dbContext.MimPerson001s.Where(p => p.MimPersonNameSurname == Request.Query["name"].ToString()).ToList();
            foreach (var record in mimPerson001RecordsList)
                if (!mimPerson001List.Contains(record))
                    mimPerson001List.Add(record);

            ViewData["name"] = Request.Query["name"].ToString();

            mimPerson001RecordsList = _dbContext.MimPerson001s.Where(p => p.MimPersonNameSurname == Request.Query["surname"].ToString()).ToList();
            foreach (var record in mimPerson001RecordsList)
                if (!mimPerson001List.Contains(record))
                    mimPerson001List.Add(record);
            ViewData["surname"] = Request.Query["surname"].ToString();

            mimPerson001RecordsList = _dbContext.MimPerson001s.Where(p => p.MimPersonNameSurname == Request.Query["mimcontrolid"].ToString()).ToList();
            foreach (var record in mimPerson001RecordsList)
                if (!mimPerson001List.Contains(record))
                    mimPerson001List.Add(record);
            ViewData["mimcontrolid"] = Request.Query["mimcontrolid"].ToString();

            ViewData["MimPersonVwList"] = mimPerson001List;
        }

        public void ListDocuments(string mimControlID)
        {
            var mimDocuments001List = new List<MimDocuments001>();
            List<MimDocuments001> mimDocumentsVwRecords = _dbContext.MimDocuments001s.Where(vw => vw.MimControlId == Guid.Parse(mimControlID)).ToList();
            foreach (var record in mimDocumentsVwRecords)
                if (!mimDocuments001List.Contains(record))
                    mimDocuments001List.Add(record);

            ViewData["MimDocumentsVwList"] = mimDocuments001List;
        }

        public void MoveBlobToFileStorage(string linkToFile)
        {
            AzureBlobHelper azureBlobHelper = new AzureBlobHelper();
            AzureFileStorageHelper azureFileStorageHelper = new AzureFileStorageHelper();
            
            var base64BlobData = azureBlobHelper.Download(linkToFile.ToLower()).Replace(" ", "+");
            byte[] imageBytes = Convert.FromBase64String(base64BlobData);
            string temporaryFileName = Path.GetTempFileName();

            try
            {
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(memoryStream);
                    image.Save(temporaryFileName);
                }

                azureFileStorageHelper.Upload(temporaryFileName, linkToFile + ".jpg");

                using (_dbContext)
                {
                    var documentRecord = _dbContext.MimDocuments001s.FirstOrDefault(p => p.MimDocumentsLinkToFile == Guid.Parse(linkToFile));
                    if (documentRecord != null)
                    {
                        documentRecord.MimDocumentsReferenceNo = linkToFile + ".jpg";
                        //_dbContext.Attach(documentRecord).State = EntityState.Modified;
                        var updateCount = _dbContext.SaveChanges();
                    }
                }
            }
            finally
            {
                System.IO.File.Delete(temporaryFileName);
            }

        }
    }

}
