using System;
using System.Threading.Tasks;
using riker.Models;

namespace riker.Repository
{
    public interface IUserContext
    {
        Task<string> GenerateToken(ApplicationUser model);
        Task<ApplicationUser> GetCurrentUser();
        ApplicationUser NewGuestUser();
        void RemoveUserGuidCookies();
        void SetUserGuidCookies(Guid userGuid);
        Task<ApplicationUser> GetLoggedInUser();
        Guid? GetUserGuidFromCookies();
    }
}