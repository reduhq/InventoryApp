using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.AppCore.Interfaces
{
    public interface IUserService
    {
        Task<string> RegisterAsync(string email, string password);
    }
}