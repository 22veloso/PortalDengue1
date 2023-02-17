using PortalDengue1.Models.V1;
using PortalDengue1.Repository.V1.Addresses;

namespace PortalDengue1.Services.V1
{
    public class AddressService
    {
        private IAddressRepository _addressRepository;

        public AddressService()
        {
            _addressRepository = new AddressRepository();
        }

        public int Add(Address address)
        {
            return _addressRepository.Add(address);
        }
    }
}
