using PortalDengue1.Services.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    public partial class Frm_ValidateDenunciantions : Form
    {
        public Frm_ValidateDenunciantions()
        {
            InitializeComponent();
        }

        private void Frm_ValidateDenunciantions_Load(object sender, EventArgs e)
        {
            dgv_Complaint.DataSource = new ComplaintService().GetAll();
            dgv_Complaint.Columns[0].Width = 60;
            dgv_Complaint.Columns[1].Width = 75;
            dgv_Complaint.Columns[2].Visible = false;
            dgv_Complaint.Columns[3].Width = 50;
            dgv_Complaint.Columns[4].Width = 80;
            dgv_Complaint.Columns[5].Width = 50;
            dgv_Complaint.Columns[6].Width = 50;
            dgv_Complaint.Columns[7].Width = 68;
        }

        private void dgv_Complaint_SelectionChanged(object sender, EventArgs e)
        {
            int contlinhas = dgv_Complaint.SelectedRows.Count;

            if (contlinhas > 0)
            {
                Tb_Id.Text = dgv_Complaint.SelectedRows[0].Cells[0].Value.ToString();
                Tb_Comments.Text = dgv_Complaint.SelectedRows[0].Cells[1].Value.ToString();
                Pb_Complaint.ImageLocation = dgv_Complaint.SelectedRows[0].Cells[2].Value.ToString();
                Tb_ZipCode.Text = dgv_Complaint.SelectedRows[0].Cells[3].Value.ToString();
                Tb_PublicPlace.Text = dgv_Complaint.SelectedRows[0].Cells[4].Value.ToString();
                Tb_District.Text = dgv_Complaint.SelectedRows[0].Cells[5].Value.ToString();
                Tb_State.Text = dgv_Complaint.SelectedRows[0].Cells[6].Value.ToString();
                Tb_City.Text = dgv_Complaint.SelectedRows[0].Cells[7].Value.ToString();
            }

            if (dgv_Complaint.Rows.Count == 0)
            {
                Tb_Id.Text = "";
                Tb_Comments.Text = "";
                Pb_Complaint.ImageLocation = "";
                Tb_ZipCode.Text = "";
                Tb_PublicPlace.Text = "";
                Tb_District.Text = "";
                Tb_State.Text = "";
                Tb_City.Text = "";
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Tb_Id.Text == "")
                MessageBox.Show("Não há denuncias para serem validadas!");
            else
            {
                if (MessageBox.Show("Confirma a exclusão?", "Excluir? ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (File.Exists(Pb_Complaint.ImageLocation))
                    {
                        File.Delete(Pb_Complaint.ImageLocation);
                    }

                    new ComplaintService().Delete(Tb_Id.Text);
                    dgv_Complaint.Rows.Remove(dgv_Complaint.CurrentRow);
                }
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Tb_Id.Text == "")
                MessageBox.Show("Não há denuncias para serem validadas!");
            else
            {
                if (MessageBox.Show("Confirmar a denúncia?", "Salvar? ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ComplaintService().UpdateStatus(Tb_Id.Text);
                    dgv_Complaint.Rows.Remove(dgv_Complaint.CurrentRow);
                }
            }
        }
    }
}