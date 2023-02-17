using System;

namespace PortalDengue1.Models.V1
{
    public class SystemLogin
    {
        public static Boolean Login = false;
        public static int LevelLogin = 0;
        public static string Directory = System.Environment.CurrentDirectory;
        public static string PhotoDirectory = Directory + @"\Foto\";
        public static string SpreadSheetDirectory = Directory + @"\Planilha\";// localização da pasta da planilha
    }
}
