using Dapper;
using PortalDengue1.Config.V1;
using PortalDengue1.Models.V1;
using PortalDengue1.Services.V1;
using PortalDengue1.Utils.V1;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace PortalDengue1.Repository.V1.Districts
{
    public class DistrictRepository : IDistrictRepository
    {
        private string _conn;

        public DistrictRepository()
        {
            _conn = DatabaseConfiguration.Get();
        }
        public bool Update(List<District> districts)
        {
            using (var db = new SqlConnection(_conn))
            {
                foreach (var item in districts)
                {
                    if (!VerifyDistrict(item.Name))// verificando se existe o bairro no banco
                    {
                        db.Execute(District.INSERT, item);// vai inserir o bairro que nao esta cadastrado no banco
                    }
                    else
                    {
                        var query = $"UPDATE District SET NumberCases += {item.NumberCases} WHERE Name = '{item.Name}';"; // se existir, apenas da o update nos casos
                        db.Execute(query);
                    }

                    var districtUpper100 = GetDistrictsUpper100Cases(item.Name);// pegando os bairros com mais de 100 casos

                    if (districtUpper100 != null)
                    {
                        if ((item.NumberCases > 25) || (districtUpper100.NumberCases >= 100))
                        {
                            if (districtUpper100 == null)
                                EmailAlertUtils.StartSendingAlert(item.Name, item.NumberCases, 1);
                            else
                                EmailAlertUtils.StartSendingAlert(districtUpper100.Name, districtUpper100.NumberCases, 2);
                        }
                    }
                    else if (item.NumberCases > 25)
                    {
                        EmailAlertUtils.StartSendingAlert(item.Name, item.NumberCases, 1);
                    }
                }
                return true;
            }
        }

        public List<District> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var districts = db.Query<District>(District.SELECT);
                return (List<District>)districts;
            }
        }

        public District GetDistrictsUpper100Cases(string nameDistrict)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var query = $"SELECT * FROM District WHERE NumberCases > 100 AND Name = '{nameDistrict}';";
                var district = db.Query<District>(query).FirstOrDefault();
                return district;
            }
        }

        public List<District> GetTop5DistrictCases()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var query = $"SELECT TOP 5 Name,NumberCases FROM District ORDER BY NumberCases DESC;";
                var districts = db.Query<District>(query);
                return (List<District>)districts;
            }
        }

        public bool VerifyDistrict(string name)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var query = $"SELECT Name FROM District WHERE Name = '{name}';";
                var districtFound = db.Query(query);
                if (districtFound.Count() != 0)
                    return true;
            }
            return false;
        }
    }
}
