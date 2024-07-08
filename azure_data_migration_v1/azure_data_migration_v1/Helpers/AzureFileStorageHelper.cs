using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;

namespace azure_data_migration_v1.Helpers
{
    public class AzureFileStorageHelper
    {
        private ShareClient _shareClient;
        private string _connectionString = @"DefaultEndpointsProtocol=https;AccountName=cbreunpocfostore;AccountKey=xvSMNZrjrI+ZBlOKSWBTxsIJ1PLmp80NW6qHVK2/gp/u0PZnj/dCg0wMIHeUpLhPmOQ9IqRZS+DyjHep/Gic1Q==;EndpointSuffix=core.windows.net";
        private string _shareName = "sys-large-document-store";
        private string _directoryName = "file-share-large-document-store";

        public AzureFileStorageHelper()
        {
            _shareClient = new ShareClient(_connectionString, _shareName);
        }

        public AzureFileStorageHelper(string connectionString, string shareName)
        {
            _shareClient = new ShareClient(connectionString, shareName);
        }

        /// <summary>
        /// Upload a file to the Azure storage containers
        /// </summary>
        /// <param name="temporaryLocalFilePath"></param>
        /// <param name="destinationFileName"></param>
        public void Upload(string temporaryLocalFilePath, string destinationFileName)
        {
            // Get a reference to a _shareClient and then create it
            //_shareClient.Create();

            // Get a reference to a directory and create it
            ShareDirectoryClient shareDirectoryClient = _shareClient.GetDirectoryClient(_directoryName);
            //shareDirectoryClient.Create();

            // Get a reference to a file and upload it
            ShareFileClient shareFileClient = shareDirectoryClient.GetFileClient(destinationFileName);

            using (FileStream fileStream = File.OpenRead(temporaryLocalFilePath))
            {
                shareFileClient.Create(fileStream.Length);
                shareFileClient.UploadRange(new HttpRange(0, fileStream.Length), fileStream);
            }
        }

        /// <summary>
        /// Download a file from file storage in Azure storage containers
        /// </summary>
        /// <param name="destinationFileName"></param>
        /// <param name="localFilePath"></param>
        public void Download(string destinationFileName, string localFilePath)
        {
            // Get a reference to the file
            ShareDirectoryClient shareDirectoryClient = _shareClient.GetDirectoryClient(_directoryName);
            ShareFileClient shareFileClient = shareDirectoryClient.GetFileClient(destinationFileName);

            // Download the file
            ShareFileDownloadInfo shareFileDownloadInfo = shareFileClient.Download();
            using (FileStream fileStream = File.OpenWrite(localFilePath))
            {
                shareFileDownloadInfo.Content.CopyTo(fileStream);
            }
        }

        /// <summary>
        /// Traverse a storage container
        /// </summary>
        /// <returns></returns>
        public void Traverse()
        {
            // Track the remaining directories to walk, starting from the root
            var shareDirectoryClientsQueue = new Queue<ShareDirectoryClient>();
            shareDirectoryClientsQueue.Enqueue(_shareClient.GetRootDirectoryClient());
            while (shareDirectoryClientsQueue.Count > 0)
            {
                // Get all of the next directory's files and subdirectories
                ShareDirectoryClient shareDirectoryClient = shareDirectoryClientsQueue.Dequeue();
                foreach (ShareFileItem shareFileItem in shareDirectoryClient.GetFilesAndDirectories())
                {
                    // Print the name of the item
                    Console.WriteLine(shareFileItem.Name);

                    // Keep walking down directories
                    if (shareFileItem.IsDirectory)
                    {
                        shareDirectoryClientsQueue.Enqueue(shareDirectoryClient.GetSubdirectoryClient(shareFileItem.Name));
                    }
                }
            }
        }
    }
}