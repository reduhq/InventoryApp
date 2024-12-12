using InventoryApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<string> RegisterAsync(string email, string password)
        {
            return (email + " " + password);
        }
    }
}
