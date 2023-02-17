namespace PortalDengue1.Views.V1
{
    partial class Frm_ValidateDenunciantions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tb_Comments = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.dgv_Complaint = new System.Windows.Forms.DataGridView();
            this.Pb_Complaint = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
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
            this.lblComentario = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Complaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Complaint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(99, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(304, 32);
            label1.TabIndex = 35;
            label1.Text = "VALIDAR DENÚNCIAS";
            // 
            // Tb_Comments
            // 
            this.Tb_Comments.Enabled = false;
            this.Tb_Comments.Location = new System.Drawing.Point(12, 460);
            this.Tb_Comments.Multiline = true;
            this.Tb_Comments.Name = "Tb_Comments";
            this.Tb_Comments.ReadOnly = true;
            this.Tb_Comments.Size = new System.Drawing.Size(487, 62);
            this.Tb_Comments.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 59);
            this.panel1.TabIndex = 16;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(127, 13);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(87, 36);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "DELETAR";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(26, 13);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(80, 36);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "SALVAR";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // dgv_Complaint
            // 
            this.dgv_Complaint.AllowUserToAddRows = false;
            this.dgv_Complaint.AllowUserToDeleteRows = false;
            this.dgv_Complaint.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Complaint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Complaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Complaint.EnableHeadersVisualStyles = false;
            this.dgv_Complaint.Location = new System.Drawing.Point(545, 12);
            this.dgv_Complaint.MultiSelect = false;
            this.dgv_Complaint.Name = "dgv_Complaint";
            this.dgv_Complaint.ReadOnly = true;
            this.dgv_Complaint.RowHeadersVisible = false;
            this.dgv_Complaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Complaint.Size = new System.Drawing.Size(436, 519);
            this.dgv_Complaint.TabIndex = 17;
            this.dgv_Complaint.SelectionChanged += new System.EventHandler(this.dgv_Complaint_SelectionChanged);
            // 
            // Pb_Complaint
            // 
            this.Pb_Complaint.Location = new System.Drawing.Point(12, 158);
            this.Pb_Complaint.Name = "Pb_Complaint";
            this.Pb_Complaint.Size = new System.Drawing.Size(487, 274);
            this.Pb_Complaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Complaint.TabIndex = 13;
            this.Pb_Complaint.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(18, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 47;
            this.lblId.Text = "ID:";
            // 
            // Tb_Id
            // 
            this.Tb_Id.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_Id.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tb_Id.Enabled = false;
            this.Tb_Id.Location = new System.Drawing.Point(18, 74);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.ReadOnly = true;
            this.Tb_Id.Size = new System.Drawing.Size(100, 20);
            this.Tb_Id.TabIndex = 46;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(182, 104);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(98, 13);
            this.lblLogradouro.TabIndex = 45;
            this.lblLogradouro.Text = "LOGRADOURO:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(18, 104);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 13);
            this.lblCidade.TabIndex = 44;
            this.lblCidade.Text = "CIDADE:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(452, 58);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 13);
            this.lblUf.TabIndex = 43;
            this.lblUf.Text = "UF:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(233, 58);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(58, 13);
            this.lblBairro.TabIndex = 42;
            this.lblBairro.Text = "BAIRRO:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(124, 58);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 41;
            this.lblCEP.Text = "CEP:";
            // 
            // Tb_City
            // 
            this.Tb_City.Enabled = false;
            this.Tb_City.Location = new System.Drawing.Point(18, 120);
            this.Tb_City.Name = "Tb_City";
            this.Tb_City.ReadOnly = true;
            this.Tb_City.Size = new System.Drawing.Size(158, 20);
            this.Tb_City.TabIndex = 40;
            // 
            // Tb_State
            // 
            this.Tb_State.Enabled = false;
            this.Tb_State.Location = new System.Drawing.Point(450, 74);
            this.Tb_State.Name = "Tb_State";
            this.Tb_State.ReadOnly = true;
            this.Tb_State.Size = new System.Drawing.Size(53, 20);
            this.Tb_State.TabIndex = 39;
            // 
            // Tb_District
            // 
            this.Tb_District.Enabled = false;
            this.Tb_District.Location = new System.Drawing.Point(233, 74);
            this.Tb_District.Name = "Tb_District";
            this.Tb_District.ReadOnly = true;
            this.Tb_District.Size = new System.Drawing.Size(205, 20);
            this.Tb_District.TabIndex = 38;
            // 
            // Tb_PublicPlace
            // 
            this.Tb_PublicPlace.Enabled = false;
            this.Tb_PublicPlace.Location = new System.Drawing.Point(182, 120);
            this.Tb_PublicPlace.Name = "Tb_PublicPlace";
            this.Tb_PublicPlace.ReadOnly = true;
            this.Tb_PublicPlace.Size = new System.Drawing.Size(320, 20);
            this.Tb_PublicPlace.TabIndex = 37;
            // 
            // Tb_ZipCode
            // 
            this.Tb_ZipCode.Enabled = false;
            this.Tb_ZipCode.Location = new System.Drawing.Point(127, 74);
            this.Tb_ZipCode.Name = "Tb_ZipCode";
            this.Tb_ZipCode.ReadOnly = true;
            this.Tb_ZipCode.Size = new System.Drawing.Size(100, 20);
            this.Tb_ZipCode.TabIndex = 36;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(9, 444);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(93, 13);
            this.lblComentario.TabIndex = 48;
            this.lblComentario.Text = "COMENTÁRIO:";
            // 
            // Frm_ValidateDenunciantions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1005, 596);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.Tb_Id);
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
            this.Controls.Add(label1);
            this.Controls.Add(this.dgv_Complaint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tb_Comments);
            this.Controls.Add(this.Pb_Complaint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ValidateDenunciantions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_ValidateDenunciantions_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Complaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Complaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox Pb_Complaint;
        private System.Windows.Forms.TextBox Tb_Comments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DataGridView dgv_Complaint;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox Tb_Id;
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
        private System.Windows.Forms.Label lblComentario;
    }
}