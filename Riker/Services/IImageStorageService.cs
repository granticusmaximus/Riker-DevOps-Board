using System;
using System.Threading.Tasks;

namespace riker.Services
{
    public interface IImageStorageService
    {
        Task<string> StoreImage(string filename, byte[] image);
        Task<string> StoreProfile(string filename, byte[] image);
    }
}
