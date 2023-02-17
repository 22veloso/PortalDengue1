using PortalDengue1.Models.V1;
using PortalDengue1.Repository.V1.Districts;
using System.Collections.Generic;

namespace PortalDengue1.Services.V1
{
    public class DistrictService
    {
        private IDistrictRepository _districtRepository;

        public DistrictService()
        {
            _districtRepository = new DistrictRepository();
        }

        public bool Update(List<District> district)
        {
            return _districtRepository.Update(district);
        }

        public List<District> GetAll()
        {
            return _districtRepository.GetAll();
        }
        public List<District> GetTop5DistrictCases()
        {
            return _districtRepository.GetTop5DistrictCases();
        }

        public District GetDistrictsUpper100Cases(string nameDistrict)
        {
            return _districtRepository.GetDistrictsUpper100Cases(nameDistrict);
        }
    }
}