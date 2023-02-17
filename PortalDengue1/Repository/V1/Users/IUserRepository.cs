using PortalDengue1.Models.V1;
using System.Collections.Generic;

namespace PortalDengue1.Repository.V1.Users
{
    public interface IUserRepository
    {
        bool Add(User user);
        User GetUser(string email, string password);
        bool GetUser(string email);
        List<string> GetEmailByDistrict(string district);
    }
}
