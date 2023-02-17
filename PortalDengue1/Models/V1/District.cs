namespace PortalDengue1.Models.V1
{
    public class District
    {
        #region Constants
        //readonly = somente leitura.
        public readonly static string INSERT = "INSERT INTO District (Name, NumberCases) VALUES (@Name,@NumberCases);";
        public readonly static string SELECT = "SELECT Id, Name, NumberCases FROM District;";
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberCases { get; set; }
        #endregion
    }
}
