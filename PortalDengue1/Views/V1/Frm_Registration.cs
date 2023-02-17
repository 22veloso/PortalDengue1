using PortalDengue1.Models.V1;
using PortalDengue1.Services.V1;
using System;
using System.Data;
using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    public partial class Frm_Registration : Form
    {
        public Frm_Registration()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            get_cep();
        }

        private void get_cep()
        {
            string cep = txt_Cep.Text;
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
                            txt_UF.Text = dataSet.Tables[0].Rows[0]["uf"].ToString().Trim();
                            txt_Cidade.Text = dataSet.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            txt_Bairro.Text = dataSet.Tables[0].Rows[0]["bairro"].ToString().Trim();
                            txt_Logradouro.Text = dataSet.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                            break;
                        default:
                            MessageBox.Show("CEP NAO ENCONTRADO");
                            break;
                    }
                }
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                MessageBox.Show("Preencher Campo de Email!");
                txt_Email.Focus();
            }
            else if (txt_Email.Text != "")
            {
                bool emailRegistered = new UserService().GetUser(txt_Email.Text);

                if (emailRegistered)
                {
                    MessageBox.Show("Email já cadastrado");
                }
                else
                {
                    if (!User.IsValidEmail(txt_Email.Text))
                        MessageBox.Show("Formato de email inválido!");

                    else
                    {
                        Address address = new Address();
                        address.ZipCode = txt_Cep.Text;
                        address.PublicPlace = txt_Logradouro.Text;
                        address.State = txt_UF.Text;
                        address.District = txt_Bairro.Text;
                        address.City = txt_Cidade.Text;

                        User usuario = new User();
                        usuario.Name = txt_Nome.Text;
                        usuario.Telephone = txt_Telefone.Text;
                        usuario.Email = txt_Email.Text;
                        usuario.Password = txt_Senha.Text;
                        usuario.AcessLevel = 1;
                        usuario.Addresses = address;

                        new UserService().Add(usuario);

                        txt_Bairro.Text = "";
                        txt_Cep.Text = "";
                        txt_Cidade.Text = "";
                        txt_Email.Text = "";
                        txt_Logradouro.Text = "";
                        txt_Nome.Text = "";
                        txt_Senha.Text = "";
                        txt_Telefone.Text = "";
                        txt_UF.Text = "";

                        MessageBox.Show("Usuário cadastrado com Sucesso!");
                    }
                }
            }
        }
    }
}
