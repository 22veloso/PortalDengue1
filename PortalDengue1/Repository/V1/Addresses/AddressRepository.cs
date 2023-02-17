using Dapper;
using PortalDengue1.Config.V1;
using PortalDengue1.Models.V1;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PortalDengue1.Repository.V1.Addresses
{
    public class AddressRepository : IAddressRepository
    {
        private string _conn;

        public AddressRepository()
        {
            _conn = DatabaseConfiguration.Get();
        }

        public int Add(Address address)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                address.Id = (int)db.QuerySingle<int>(Address.INSERT, address);
            }
            return address.Id;
        }
    }
}
