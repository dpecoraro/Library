using Core.IRepository;
using Core.IServices;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Adapters
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Get(string name, string password) => _userRepository.Get(name, password);
    }
}
