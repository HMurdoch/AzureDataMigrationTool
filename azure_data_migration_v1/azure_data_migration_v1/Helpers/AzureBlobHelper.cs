using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Azure;

namespace azure_data_migration_v1.Helpers
{
    public class AzureBlobHelper
    {
        private BlobContainerClient _client;
        private string _connectionString = @"DefaultEndpointsProtocol=https;AccountName=cbreunpocfostore;AccountKey=xvSMNZrjrI+ZBlOKSWBTxsIJ1PLmp80NW6qHVK2/gp/u0PZnj/dCg0wMIHeUpLhPmOQ9IqRZS+DyjHep/Gic1Q==;EndpointSuffix=core.windows.net";
        private string _containerName = "sys-large-document-store";

        /// <summary>
        /// Create an instance of blob repository
        /// </summary>
        /// <param name="connectionString">The storage account connection string</param>
        /// <param name="containerName">The name of the container</param>
        public AzureBlobHelper()
        {
            _client = new BlobContainerClient(_connectionString, _containerName);
            // Only create the container if it does not exist
            _client.CreateIfNotExists(PublicAccessType.BlobContainer);
        }

        /// <summary>
        /// Create an instance of blob repository
        /// </summary>
        /// <param name="connectionString">The storage account connection string</param>
        /// <param name="containerName">The name of the container</param>
        public AzureBlobHelper(string connectionString, string containerName)
        {
            _client = new BlobContainerClient(connectionString, containerName);
            // Only create the container if it does not exist
            _client.CreateIfNotExists(PublicAccessType.BlobContainer);
        }

        /// <summary>
        /// Upload a local file to the blob container
        /// </summary>
        /// <param name="localFilePath">Full path to the local file</param>
        /// <param name="pathAndFileName">Full path to the container file</param>
        /// <param name="contentType">The content type of the file being created in the container</param>
        public void Upload(string localFilePath, string pathAndFileName, string contentType)
        {
            BlobClient blobClient = _client.GetBlobClient(pathAndFileName);

            using FileStream uploadFileStream = File.OpenRead(localFilePath);
            blobClient.Upload(uploadFileStream, new BlobHttpHeaders { ContentType = contentType });
            uploadFileStream.Close();
        }

        /// <summary>
        /// Download file as a string
        /// </summary>
        /// <param name="pathAndFileName">Full path to the container file</param>
        /// <returns>Contents of file as a string</returns>
        public string Download(string pathAndFileName)
        {
            BlobClient blobClient = _client.GetBlobClient(pathAndFileName);
            if (blobClient.Exists())
            {
                Response<BlobDownloadResult> download = blobClient.DownloadContent();
                byte[] result = download.Value.Content.ToArray();
                //download.Content.Read(result, 0, (int)download.ContentLength);
                var returnString = Encoding.UTF8.GetString(result);
                return returnString;
            }
            return string.Empty;
        }

        /// <summary>
        /// Delete file in container
        /// </summary>
        /// <param name="pathAndFileName">Full path to the container file</param>
        /// <returns>True if file was deleted</returns>
        public bool Delete(string pathAndFileName)
        {
            BlobClient blobClient = _client.GetBlobClient(pathAndFileName);
            return blobClient.DeleteIfExists(DeleteSnapshotsOption.IncludeSnapshots);
        }
    }
}