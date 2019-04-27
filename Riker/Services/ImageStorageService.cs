using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;
namespace riker.Services
{
    public class ImageStorageService : IImageStorageService
    {
        private readonly IConfiguration _config;

        public ImageStorageService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<string> StoreImage(string filename, byte[] image)
        {
            var filenameonly = Path.GetFileName(filename);

            var url = string.Concat(_config["BlobService:StorageUrl"], "images/", filenameonly);

            return url;
        }

        public async Task<string> StoreProfile(string filename, byte[] image)
        {
            var filenameonly = Path.GetFileName(filename);

            var url = string.Concat(_config["BlobService:StorageUrl"], "profile/", filenameonly);


            return url;
        }
    }
}
