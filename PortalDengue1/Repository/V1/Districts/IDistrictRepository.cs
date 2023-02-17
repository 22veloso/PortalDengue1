using PortalDengue1.Models.V1;
using System.Collections.Generic;

namespace PortalDengue1.Repository.V1.Districts
{
    public interface IDistrictRepository
    {
        bool Update(List<District> district);
        List<District> GetAll();
        List<District> GetTop5DistrictCases();
        District GetDistrictsUpper100Cases(string nameDistrict);
    }
}
