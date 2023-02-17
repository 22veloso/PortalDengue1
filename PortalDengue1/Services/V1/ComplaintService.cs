using PortalDengue1.Models.V1;
using PortalDengue1.Repository.V1.Denunciations;
using System.Data;

namespace PortalDengue1.Services.V1
{
    public class ComplaintService
    {
        private IDenunciationsRepository _denunciationsRepository;

        public ComplaintService()
        {
            _denunciationsRepository = new DenunciationsRepository();
        }

        public bool Add(Complaint complaint)
        {
            return _denunciationsRepository.Add(complaint);
        }
        public bool Delete(string id)
        {
            return _denunciationsRepository.Delete(id);
        }

        public DataTable GetAll()
        {
            return _denunciationsRepository.GetAll();
        }

        public DataTable GetAllValid()
        {
            return _denunciationsRepository.GetAllValid();
        }

        public bool UpdateStatus(string id)
        {
            return _denunciationsRepository.UpdateStatus(id);
        }
    }
}
