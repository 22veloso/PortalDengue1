using PortalDengue1.Models.V1;
using PortalDengue1.Repository.V1.Users;
using System.Collections.Generic;

namespace PortalDengue1.Services.V1
{
    public class UserService
    {
        private IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public bool Add(User user)
        {
            return _userRepository.Add(user);
        }

        public User GetUser(string email, string password)
        {
            return _userRepository.GetUser(email, password);
        }

        public bool GetUser(string email)
        {
            return _userRepository.GetUser(email);
        }

        public List<string> GetEmailByDistrict(string district)
        {
            return _userRepository.GetEmailByDistrict(district);
        }
    }
}
