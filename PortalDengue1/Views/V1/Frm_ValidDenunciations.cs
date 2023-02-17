using PortalDengue1.Services.V1;
using System;
using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    public partial class Frm_ValidDenunciations : Form
    {
        public Frm_ValidDenunciations()
        {
            InitializeComponent();
        }

        private void Frm_ValidDenunciations_Load(object sender, EventArgs e)
        {
            dgv_Complaint.DataSource = new ComplaintService().GetAllValid();
            dgv_Complaint.Columns[0].Width = 60;
            dgv_Complaint.Columns[1].Width = 75;
            dgv_Complaint.Columns[2].Visible = false;
            dgv_Complaint.Columns[3].Width = 50;
            dgv_Complaint.Columns[4].Width = 80;
            dgv_Complaint.Columns[5].Width = 60;
            dgv_Complaint.Columns[6].Width = 50;
            dgv_Complaint.Columns[7].Width = 62;
        }

        private void dgv_Complaint_SelectionChanged_1(object sender, EventArgs e)
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
        }

        private void dgv_Complaint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}