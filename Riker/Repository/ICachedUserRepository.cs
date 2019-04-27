using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using riker.Models;

namespace riker.Repository
{
    public interface ICachedUserRepository<T> where T : ApplicationUser 
    {
        Task<ApplicationUser> GetByIdAsync(Guid userGuid);
        Task<IEnumerable<ApplicationUser>> ListAsync();
    }
}