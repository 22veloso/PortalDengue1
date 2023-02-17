//V1 versionamento de codigo

namespace PortalDengue1.Models.V1
{
    public class Address
    {
        // passando por uma constant ex: insert na tabela endereço
        #region Constants
        public readonly static string INSERT = "INSERT INTO Addresses (ZipCode,PublicPlace,District,State,City) output inserted.Id VALUES (@ZipCode,@PublicPlace,@District,@State,@City);";//inserindo o endereço no banco e retornando o ID que acabou de ser inserido
        #endregion

        #region Properties
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PublicPlace { get; set; }
        #endregion
    }
}
