using PortalDengue1.Models.V1;
using PortalDengue1.Services.V1;
using System;
using System.Data;
using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    public partial class Frm_Login : Form
    {
        Frm_HomePage frm_P;
        DataTable dt = new DataTable();

        public Frm_Login(Frm_HomePage frm_HomePage)
        {
            InitializeComponent();
            frm_P = frm_HomePage;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            {
                if (txt_LogarEmail.Text == "" || txt_LogarSenha.Text == "")
                {
                    MessageBox.Show("EMAIL OU SENHA INVÁLIDOS!");
                    txt_LogarEmail.Focus();
                    return;
                }
                User user = new UserService().GetUser(txt_LogarEmail.Text, txt_LogarSenha.Text);
                if (user != null)
                {
                    frm_P.lb_AcessoUsuario.Text = user.AcessLevel.ToString();
                    frm_P.lb_NomeUsuario.Text = user.Name;
                    frm_P.pb_Logado.Image = Properties.Resources.icons8_green_circle_48;
                    SystemLogin.LevelLogin = user.AcessLevel;
                    SystemLogin.Login = true;
                    frm_P.btn_Login.Enabled = false;
                    if (SystemLogin.LevelLogin == 2)
                    {
                        frm_P.btn_CasesRegister.Visible = true;
                        frm_P.btn_Denunciations.Visible = true;
                        frm_P.panel7.Visible = true;
                        frm_P.panel8.Visible = true;
                    }
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
            }
        }
    }
}
