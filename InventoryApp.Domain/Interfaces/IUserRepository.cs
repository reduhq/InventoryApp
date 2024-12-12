using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<string> RegisterAsync(string email, string password);
    }
}
