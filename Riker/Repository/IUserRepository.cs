using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using riker.Models;

namespace riker.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetUsersAsync();
        Task<bool> DeleteUserAsync(Guid id);
        Task<ApplicationUser> InsertUserAsync(ApplicationUser user);
        Task<bool> UpdateUserAsync(ApplicationUser user);
        Task<ApplicationUser> GetUserByIdAsync(Guid userGuid);
    }
}