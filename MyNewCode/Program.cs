using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;



namespace AzureTableStorage
{
    class Program
    {
        static CloudStorageAccount storageAccount;
        static CloudTableClient tableClient;
        static CloudTable table;
        static void Main(string[] args)
        {
            try
            {
                CreateAzureStorageTable();
            }
            catch
            {

            }

        }


        private static void CreateAzureStorageTable()
        {
            storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageCon"));
            //hence

        }




    }
}
