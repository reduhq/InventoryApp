using InventoryApp.AppCore.Interfaces;
using InventoryApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.AppCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<string> RegisterAsync(string email, string password)
        {
            return await userRepository.RegisterAsync(email, password);
        }
    }
}
