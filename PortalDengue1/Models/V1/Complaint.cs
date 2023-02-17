namespace PortalDengue1.Models.V1
{
    public class Complaint
    {
        #region Constants
        public readonly static string INSERT = "INSERT INTO Complaint (Comment,Photo,Addresses,StatusComplaint) VALUES (@Comment,@Photo,@AddressId,@StatusComplaint);";
        #endregion

        #region Properties
        public int Id { get; set; }
        public int AddressId { get; set; }
        public Address Addresses { get; set; }
        public string Comment { get; set; }
        public string Photo { get; set; }
        public int StatusComplaint { get; set; }
        #endregion
    }
}
