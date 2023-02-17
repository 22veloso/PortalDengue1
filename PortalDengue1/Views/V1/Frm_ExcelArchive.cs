using PortalDengue1.Models.V1;
using PortalDengue1.Services.V1;
using PortalDengue1.Utils.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    public partial class Frm_ExcelArchive : Form
    {
        string OrigemCompleto = "";
        string Planilha = "";
        string PastaDestino = SystemLogin.SpreadSheetDirectory;
        string DestinoCompleto = "";

        public Frm_ExcelArchive()
        {
            InitializeComponent();
        }

        public void UpdateCases(string destiny)
        {
            List<District> listDistrict = ExcelArchiveUtils.ReadXls(destiny);
            new DistrictService().Update(listDistrict);
            
        }

        private void btn_AddExcel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OrigemCompleto = openFileDialog1.FileName;
                Planilha = openFileDialog1.SafeFileName;
                DestinoCompleto = PastaDestino + Planilha;
            }

            if (File.Exists(DestinoCompleto))
            {
                MessageBox.Show("Os dados dessa planilha já foram inseridos no sistema!");
                {
                    return;
                }
            }
            System.IO.File.Copy(OrigemCompleto, DestinoCompleto, true);

            if(File.Exists(DestinoCompleto))
                UpdateCases(DestinoCompleto);

            MessageBox.Show("Os dados da planilha foram inseridos com sucesso no sistema!");
        }
    }
}