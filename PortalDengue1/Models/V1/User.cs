namespace PortalDengue1.Models.V1
{
    public class User
    {
        #region Constant
        public readonly static string INSERT = "INSERT INTO Usuario (Name,Telephone,Email,Password,AcessLevel,Addresses) VALUES (@Name,@Telephone,@Email,@Password,@AcessLevel,@AddressId);";
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int AcessLevel { get; set; }
        public int AddressId { get; set; }
        public Address Addresses { get; set; }
        #endregion

        #region Methods
        public static bool IsValidEmail(string email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                return enderecoEmail.Address == email;
            }

            catch
            {
                return false;
            }
        }
        #endregion
    }
}