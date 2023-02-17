namespace PortalDengue1.Views.V1
{
    partial class Frm_ValidDenunciations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Complaint = new System.Windows.Forms.DataGridView();
            this.Tb_Comments = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.Tb_City = new System.Windows.Forms.TextBox();
            this.Tb_State = new System.Windows.Forms.TextBox();
            this.Tb_District = new System.Windows.Forms.TextBox();
            this.Tb_PublicPlace = new System.Windows.Forms.TextBox();
            this.Tb_ZipCode = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.Pb_Complaint = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Complaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Complaint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(91, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(304, 32);
            label1.TabIndex = 34;
            label1.Text = "DENÚNCIAS VÁLIDAS";
            // 
            // dgv_Complaint
            // 
            this.dgv_Complaint.AllowUserToAddRows = false;
            this.dgv_Complaint.AllowUserToDeleteRows = false;
            this.dgv_Complaint.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Complaint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Complaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Complaint.EnableHeadersVisualStyles = false;
            this.dgv_Complaint.Location = new System.Drawing.Point(590, 15);
            this.dgv_Complaint.MultiSelect = false;
            this.dgv_Complaint.Name = "dgv_Complaint";
            this.dgv_Complaint.ReadOnly = true;
            this.dgv_Complaint.RowHeadersVisible = false;
            this.dgv_Complaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Complaint.Size = new System.Drawing.Size(440, 519);
            this.dgv_Complaint.TabIndex = 31;
            this.dgv_Complaint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Complaint_CellContentClick);
            this.dgv_Complaint.SelectionChanged += new System.EventHandler(this.dgv_Complaint_SelectionChanged_1);
            // 
            // Tb_Comments
            // 
            this.Tb_Comments.Enabled = false;
            this.Tb_Comments.Location = new System.Drawing.Point(12, 429);
            this.Tb_Comments.Multiline = true;
            this.Tb_Comments.Name = "Tb_Comments";
            this.Tb_Comments.ReadOnly = true;
            this.Tb_Comments.Size = new System.Drawing.Size(484, 111);
            this.Tb_Comments.TabIndex = 30;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(9, 410);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(93, 13);
            this.lblComentario.TabIndex = 29;
            this.lblComentario.Text = "COMENTÁRIO:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(176, 119);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(98, 13);
            this.lblLogradouro.TabIndex = 27;
            this.lblLogradouro.Text = "LOGRADOURO:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(12, 119);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 13);
            this.lblCidade.TabIndex = 26;
            this.lblCidade.Text = "CIDADE:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(446, 73);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 13);
            this.lblUf.TabIndex = 25;
            this.lblUf.Text = "UF:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(227, 73);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(58, 13);
            this.lblBairro.TabIndex = 24;
            this.lblBairro.Text = "BAIRRO:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(118, 73);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 23;
            this.lblCEP.Text = "CEP:";
            // 
            // Tb_City
            // 
            this.Tb_City.Enabled = false;
            this.Tb_City.Location = new System.Drawing.Point(15, 135);
            this.Tb_City.Name = "Tb_City";
            this.Tb_City.ReadOnly = true;
            this.Tb_City.Size = new System.Drawing.Size(155, 20);
            this.Tb_City.TabIndex = 22;
            // 
            // Tb_State
            // 
            this.Tb_State.Enabled = false;
            this.Tb_State.Location = new System.Drawing.Point(444, 89);
            this.Tb_State.Name = "Tb_State";
            this.Tb_State.ReadOnly = true;
            this.Tb_State.Size = new System.Drawing.Size(53, 20);
            this.Tb_State.TabIndex = 21;
            // 
            // Tb_District
            // 
            this.Tb_District.Enabled = false;
            this.Tb_District.Location = new System.Drawing.Point(227, 89);
            this.Tb_District.Name = "Tb_District";
            this.Tb_District.ReadOnly = true;
            this.Tb_District.Size = new System.Drawing.Size(205, 20);
            this.Tb_District.TabIndex = 20;
            // 
            // Tb_PublicPlace
            // 
            this.Tb_PublicPlace.Enabled = false;
            this.Tb_PublicPlace.Location = new System.Drawing.Point(176, 135);
            this.Tb_PublicPlace.Name = "Tb_PublicPlace";
            this.Tb_PublicPlace.ReadOnly = true;
            this.Tb_PublicPlace.Size = new System.Drawing.Size(320, 20);
            this.Tb_PublicPlace.TabIndex = 19;
            // 
            // Tb_ZipCode
            // 
            this.Tb_ZipCode.Enabled = false;
            this.Tb_ZipCode.Location = new System.Drawing.Point(121, 89);
            this.Tb_ZipCode.Name = "Tb_ZipCode";
            this.Tb_ZipCode.ReadOnly = true;
            this.Tb_ZipCode.Size = new System.Drawing.Size(100, 20);
            this.Tb_ZipCode.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 73);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "ID:";
            // 
            // Tb_Id
            // 
            this.Tb_Id.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_Id.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tb_Id.Enabled = false;
            this.Tb_Id.Location = new System.Drawing.Point(12, 89);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.ReadOnly = true;
            this.Tb_Id.Size = new System.Drawing.Size(100, 20);
            this.Tb_Id.TabIndex = 32;
            // 
            // Pb_Complaint
            // 
            this.Pb_Complaint.Location = new System.Drawing.Point(12, 161);
            this.Pb_Complaint.Name = "Pb_Complaint";
            this.Pb_Complaint.Size = new System.Drawing.Size(484, 241);
            this.Pb_Complaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Complaint.TabIndex = 28;
            this.Pb_Complaint.TabStop = false;
            // 
            // Frm_ValidDenunciations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1055, 552);
            this.Controls.Add(label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.dgv_Complaint);
            this.Controls.Add(this.Tb_Comments);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.Pb_Complaint);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.Tb_City);
            this.Controls.Add(this.Tb_State);
            this.Controls.Add(this.Tb_District);
            this.Controls.Add(this.Tb_PublicPlace);
            this.Controls.Add(this.Tb_ZipCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ValidDenunciations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_ValidDenunciations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Complaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Complaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Complaint;
        private System.Windows.Forms.TextBox Tb_Comments;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.PictureBox Pb_Complaint;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox Tb_City;
        private System.Windows.Forms.TextBox Tb_State;
        private System.Windows.Forms.TextBox Tb_District;
        private System.Windows.Forms.TextBox Tb_PublicPlace;
        private System.Windows.Forms.TextBox Tb_ZipCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox Tb_Id;
    }
}