using OfficeOpenXml;
using PortalDengue1.Models.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalDengue1.Utils.V1
{
    public class ExcelArchiveUtils
    {
        public static List<District> ReadXls(string fileInfo)
        {
            var listaBairros = new List<District>();

            FileInfo existingFile = new FileInfo(fileInfo);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                try
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int colCount = worksheet.Dimension.End.Column;
                    int rowCount = worksheet.Dimension.End.Row;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var district = new District();
                        district.Name = worksheet.Cells[row, 1].Value.ToString();
                        district.NumberCases = Convert.ToInt32(worksheet.Cells[row, 2].Value);

                        listaBairros.Add(district);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return listaBairros;
        }
    }
}
