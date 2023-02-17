using PortalDengue1.Models.V1;
using PortalDengue1.Services.V1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();
            btn_CasesRegister.Visible = false;
            btn_Denunciations.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void Frm_HomePage_Load(object sender, EventArgs e)
        {
            List<string> listNames = new List<string>();
            List<int> listNumber = new List<int>();
            var districts = new DistrictService().GetTop5DistrictCases();

            if (districts.Count == 0)
            {
                cht_Graphic.Visible = false;
                lbl_District1.Visible = false;
                lbl_District2.Visible = false;
                lbl_District3.Visible = false;
                lbl_District4.Visible = false;
                lbl_District5.Visible = false;
                lbl_NumberCases.Visible = false;
                lbl_Districts.Visible = false;
                lbl_Top5.Visible = false;
            }
            else
            {
                foreach (var item in districts)
                {
                    listNames.Add(item.Name);
                    listNumber.Add(item.NumberCases);
                }

                var districtsName = listNames.ToArray();
                var numberCases = listNumber.ToArray();

                cht_Graphic.Series.Add("Teste");
                cht_Graphic.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                cht_Graphic.Series[0].Points.DataBindXY(districtsName, numberCases);
                cht_Graphic.Series[0].Label = "#PERCENT";
                cht_Graphic.Series[0].LegendText = "#AXISLABEL";

                lbl_District1.Text = numberCases[0].ToString();
                lbl_District2.Text = numberCases[1].ToString();
                lbl_District3.Text = numberCases[2].ToString();
                lbl_District4.Text = numberCases[3].ToString();
                lbl_District5.Text = numberCases[4].ToString();
            }
        }
        private void btn_Foco_Click(object sender, EventArgs e)
        {
            if (SystemLogin.Login)
            {
                Frm_Denunciations foco = new Frm_Denunciations();
                foco.ShowDialog();
            }
            else
            {
                Frm_Login frm_login = new Frm_Login(this);
                frm_login.ShowDialog();

            }
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login(this);
            frm_Login.ShowDialog();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Registration frm_Registration = new Frm_Registration();
            frm_Registration.ShowDialog();
        }

        private void btn_Denunciations_Click(object sender, EventArgs e)
        {
            Frm_ValidateDenunciantions frm_ValidateDenunciantions = new Frm_ValidateDenunciantions();
            frm_ValidateDenunciantions.ShowDialog();
        }

        private void btn_CasesRegister_Click(object sender, EventArgs e)
        {
            Frm_ExcelArchive frm_ExcelArchive = new Frm_ExcelArchive();
            frm_ExcelArchive.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            lb_AcessoUsuario.Text = "0";
            lb_NomeUsuario.Text = "---";
            pb_Logado.Image = Properties.Resources.icons8_red_circle_48;
            SystemLogin.LevelLogin = 0;
            SystemLogin.Login = false;
            btn_Login.Enabled = true;
            btn_CasesRegister.Visible = false;
            btn_Denunciations.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void btn_Complaint_Click(object sender, EventArgs e)
        {
            if (SystemLogin.Login)
            {
                Frm_ValidDenunciations frm_ValidDenunciantions = new Frm_ValidDenunciations();
                frm_ValidDenunciantions.ShowDialog();
            }
            else
            {
                Frm_Login frm_login = new Frm_Login(this);
                frm_login.ShowDialog();
            }
        }

        private void btn_Informação_Click(object sender, EventArgs e)
        {
            Frm_AboutApp frm_aboutApp = new Frm_AboutApp();
            frm_aboutApp.ShowDialog();
        }
    }
}