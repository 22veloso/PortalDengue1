using PortalDengue1.Models.V1;
using System.Data;

namespace PortalDengue1.Repository.V1.Denunciations
{
    public interface IDenunciationsRepository
    {
        bool Add(Complaint complaint);
        DataTable GetAll();
        DataTable GetAllValid();
        bool Delete(string id);
        bool UpdateStatus(string id);
    }
}