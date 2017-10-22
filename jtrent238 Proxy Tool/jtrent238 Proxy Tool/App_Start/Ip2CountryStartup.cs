using IP2Country;
using IP2Country.Import;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using jtrent238_Proxy_Tool;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(Ip2CountryStartup), "Start")]
namespace jtrent238_Proxy_Tool
{
    public static class Ip2CountryStartup
	{
	    public static void Start()
	    {
	        var account = new CloudStorageAccount(new StorageCredentials(
                "", // Azure Storage Account Name
                ""), // Azure Storage Account Key
                true); // Use Https
	        var importer = new AzureStorageImporter(account, 
				"", // Container
				""); // Blob Name
	        IpLookup.Initialize(importer, "DefaultConnection"); // Optional Database Connection String Name
	    }
	}
}