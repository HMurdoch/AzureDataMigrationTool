using azure_data_migration_v1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace azure_data_migration_v1.Pages
{
    public class BlobToFileStorage : PageModel
    {
        private readonly ILogger<BlobToFileStorage> _logger;
        CbrEunPocCfgQueue9bb531c86eContext _dbContext = new CbrEunPocCfgQueue9bb531c86eContext();


        public BlobToFileStorage(ILogger<BlobToFileStorage> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var mimPersonVwList = new List<MimPersonVw>();
            if (!string.IsNullOrEmpty(Request.Query["name"].ToString()))
            {
                List<MimPersonVw> mimPersonVwRecords = _dbContext.MimPersonVws.Where(p => p.MimPersonNameSurname == Request.Query["same"].ToString()).ToList();
                foreach (var record in mimPersonVwRecords)
                    if (!mimPersonVwList.Contains(record))
                        mimPersonVwList.Add(record);
                ViewData["name"] = Request.Query["name"].ToString();
            }

            if (!string.IsNullOrEmpty(Request.Query["surname"].ToString()))
            {
                List<MimPersonVw> mimPersonVwRecords = _dbContext.MimPersonVws.Where(p => p.MimPersonNameSurname == Request.Query["surname"].ToString()).ToList();
                foreach (var record in mimPersonVwRecords)
                    if (!mimPersonVwList.Contains(record))
                        mimPersonVwList.Add(record);
                ViewData["surname"] = Request.Query["surname"].ToString();
            }

            if (!string.IsNullOrEmpty(Request.Query["mimcontrolid"].ToString()))
            {
                List<MimPersonVw> mimPersonVwRecords = _dbContext.MimPersonVws.Where(p => p.MimPersonNameSurname == Request.Query["mimcontrolid"].ToString()).ToList();
                foreach (var record in mimPersonVwRecords)
                    if (!mimPersonVwList.Contains(record))
                        mimPersonVwList.Add(record);
                ViewData["mimcontrolid"] = Request.Query["mimcontrolid"].ToString();
            }
            ViewData["MimPersonVwList"] = mimPersonVwList;


            if (!string.IsNullOrEmpty(Request.Query["name"]) || !string.IsNullOrEmpty(Request.Query["surname"]) || !string.IsNullOrEmpty(Request.Query["mimcontrolid"]))
                ListMimControls();

            if (!string.IsNullOrEmpty(Request.Query["mci"]))
            {
                this.ListDocuments(Request.Query["mci"]);
            }
        }

        public void OnPost()
        {
            bool isAdditionalVariable = false;
            string queryParameters = "/BlobToFileStorage?";

            if (!string.IsNullOrEmpty(Request.Query["mci"]))
            {
                queryParameters += "mci=" + Request.Query["mci"];
                isAdditionalVariable = true;
            }
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
            var mimPersonVwList = new List<MimPersonVw>();
            List<MimPersonVw> mimPersonVwRecords = _dbContext.MimPersonVws.Where(p => p.MimPersonNameSurname == Request.Query["name"].ToString()).ToList();
            foreach (var record in mimPersonVwRecords)
                if (!mimPersonVwList.Contains(record))
                    mimPersonVwList.Add(record);

            ViewData["name"] = Request.Query["name"].ToString();

            mimPersonVwRecords = _dbContext.MimPersonVws.Where(p => p.MimPersonNameSurname == Request.Query["surname"].ToString()).ToList();
            foreach (var record in mimPersonVwRecords)
                if (!mimPersonVwList.Contains(record))
                    mimPersonVwList.Add(record);
            ViewData["surname"] = Request.Query["surname"].ToString();

            mimPersonVwRecords = _dbContext.MimPersonVws.Where(p => p.MimPersonNameSurname == Request.Query["mimcontrolid"].ToString()).ToList();
            foreach (var record in mimPersonVwRecords)
                if (!mimPersonVwList.Contains(record))
                    mimPersonVwList.Add(record);
            ViewData["mimcontrolid"] = Request.Query["mimcontrolid"].ToString();

            ViewData["MimPersonVwList"] = mimPersonVwList;
        }

        public void ListDocuments(string mimControlID)
        {
            var mimDocumentsVwList = new List<MimDocumentsVw>();
            var mimControlIDGuid = Guid.Parse(mimControlID);
            List<MimDocumentsVw> mimDocumentsVwRecords = _dbContext.MimDocumentsVws.Where(vw => vw.MimControlId == mimControlIDGuid).ToList();
            foreach (var record in mimDocumentsVwRecords)
                if (!mimDocumentsVwList.Contains(record))
                    mimDocumentsVwList.Add(record);

            ViewData["MimDocumentsVwList"] = mimDocumentsVwList;

        }
    }

}
