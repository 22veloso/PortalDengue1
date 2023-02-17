using Dapper;
using PortalDengue1.Config.V1;
using PortalDengue1.Models.V1;
using PortalDengue1.Repository.V1.Addresses;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PortalDengue1.Repository.V1.Users
{
    public class UserRepository : IUserRepository
    {
        private string _conn;

        public UserRepository()
        {
            _conn = DatabaseConfiguration.Get();
        }
        public bool Add(User user)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                user.AddressId = new AddressRepository().Add(user.Addresses);
                db.Execute(User.INSERT, user);
                result = true;
            }
            return result;
        }

        public User GetUser(string email, string password)// select pra fazer o login
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var query = $"SELECT Id,Name,Telephone,Email,Password,AcessLevel FROM Usuario WHERE Email = '{email}' AND Password = '{password}';";
                var user = db.Query<User>(query).FirstOrDefault();// retornando user
                return user;
            }
        }

        public bool GetUser(string email)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var query = $"SELECT Name FROM Usuario WHERE Email = '{email}';";
                var name = db.Query<string>(query).FirstOrDefault();
                if (name != null)
                    return true;
                else
                    return false;
            }
        }

        public List<string> GetEmailByDistrict(string district)
        {
            List<string> usersEmailFound = new List<string>();

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var query = $"SELECT Email FROM Usuario,Addresses WHERE Usuario.Addresses = Addresses.Id AND Addresses.District = '{district}';";
                var users = db.Query<User>(query).ToList();

                foreach (var item in users)
                {
                    usersEmailFound.Add(item.Email);
                }

                return usersEmailFound;
            }
        }
    }
}
