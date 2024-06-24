using NLayer.Core.Model;
using NLayer.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IUserRepository: IGenericRepository<User>

    {
        Task<User> GetUserAsync(string name, string password);
    }
}
