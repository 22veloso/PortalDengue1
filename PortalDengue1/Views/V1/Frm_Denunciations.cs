using PortalDengue1.Models.V1;
using PortalDengue1.Services.V1;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    public partial class Frm_Denunciations : Form
    {
        string OrigemCompleto = "";
        string Foto = "";
        string PastaDestino = SystemLogin.PhotoDirectory;
        string DestinoCompleto = "";
        public Frm_Denunciations()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas denúncias passam por uma análise antes de serem validadas para conferir se não estão ferindo as diretrizes do APP. Por favor, antes de realizar sua denúncia, certifique-se de que ela não inflinga os princípios de invasão de privacidade!", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OrigemCompleto = openFileDialog1.FileName;
                Foto = openFileDialog1.SafeFileName;
                DestinoCompleto = PastaDestino + Foto;

                if (File.Exists(DestinoCompleto))
                {
                    MessageBox.Show("Uma denúncia já foi realizada com esta foto!");
                }
                else
                {
                    System.IO.File.Copy(OrigemCompleto, DestinoCompleto, true);
                    pb_Foto.ImageLocation = DestinoCompleto;
                }

            }
        }

        private void btn_SalvarFoco_Click(object sender, EventArgs e)
        {
            if (DestinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

            }

            if (DestinoCompleto != "")
            {
                System.IO.File.Copy(OrigemCompleto, DestinoCompleto, true);
                if (File.Exists(DestinoCompleto))
                {
                    pb_Foto.ImageLocation = DestinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            Address address = new Address();
            address.ZipCode = txt_Cep_Foco.Text;
            address.PublicPlace = txt_Logradouro_Foco.Text;
            address.State = txt_UF_Foco.Text;
            address.District = txt_Bairro_Foco.Text;
            address.City = txt_Cidade_Foco.Text;

            Complaint complaint = new Complaint();
            complaint.Comment = txt_Comentario.Text;
            complaint.Photo = DestinoCompleto.ToString();
            complaint.StatusComplaint = 1;
            complaint.Addresses = address;

            new ComplaintService().Add(complaint);
            MessageBox.Show("Denúncia cadastrada com Sucesso e esperando Aprovação!");

            txt_Bairro_Foco.Text = "";
            txt_Cep_Foco.Text = "";
            txt_Cidade_Foco.Text = "";
            txt_Comentario.Text = "";
            txt_Logradouro_Foco.Text = "";
            txt_UF_Foco.Text = "";
            pb_Foto.ImageLocation = "";
        }

        private void btn_Pesquisar_Foco_Click(object sender, EventArgs e)
        {
            string cep = txt_Cep_Foco.Text;
            string _resultado;
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml");

            if (dataSet != null)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    _resultado = dataSet.Tables[0].Rows[0]["resultado"].ToString();
                    switch (_resultado)
                    {
                        case "1":
                            txt_UF_Foco.Text = dataSet.Tables[0].Rows[0]["uf"].ToString().Trim();
                            txt_Cidade_Foco.Text = dataSet.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            txt_Bairro_Foco.Text = dataSet.Tables[0].Rows[0]["bairro"].ToString().Trim();
                            txt_Logradouro_Foco.Text = dataSet.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                            break;
                        default:
                            MessageBox.Show("CEP NAO ENCONTRADO");
                            break;
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}