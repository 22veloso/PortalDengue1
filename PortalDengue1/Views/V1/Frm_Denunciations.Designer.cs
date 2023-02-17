using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    partial class Frm_Denunciations
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
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UF_Foco = new System.Windows.Forms.TextBox();
            this.txt_Cep_Foco = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar_Foco = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Logradouro_Foco = new System.Windows.Forms.TextBox();
            this.txt_Bairro_Foco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cidade_Foco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Comentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_SalvarFoco = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 14);
            this.label12.TabIndex = 36;
            this.label12.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "CEP:";
            // 
            // txt_UF_Foco
            // 
            this.txt_UF_Foco.Location = new System.Drawing.Point(10, 398);
            this.txt_UF_Foco.Name = "txt_UF_Foco";
            this.txt_UF_Foco.Size = new System.Drawing.Size(44, 20);
            this.txt_UF_Foco.TabIndex = 35;
            // 
            // txt_Cep_Foco
            // 
            this.txt_Cep_Foco.Location = new System.Drawing.Point(10, 358);
            this.txt_Cep_Foco.Name = "txt_Cep_Foco";
            this.txt_Cep_Foco.Size = new System.Drawing.Size(139, 20);
            this.txt_Cep_Foco.TabIndex = 28;
            // 
            // btn_Pesquisar_Foco
            // 
            this.btn_Pesquisar_Foco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar_Foco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pesquisar_Foco.Location = new System.Drawing.Point(155, 354);
            this.btn_Pesquisar_Foco.Name = "btn_Pesquisar_Foco";
            this.btn_Pesquisar_Foco.Size = new System.Drawing.Size(93, 24);
            this.btn_Pesquisar_Foco.TabIndex = 30;
            this.btn_Pesquisar_Foco.Text = "PESQUISAR";
            this.btn_Pesquisar_Foco.UseVisualStyleBackColor = true;
            this.btn_Pesquisar_Foco.Click += new System.EventHandler(this.btn_Pesquisar_Foco_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 34;
            this.label10.Text = "CIDADE:";
            // 
            // txt_Logradouro_Foco
            // 
            this.txt_Logradouro_Foco.Location = new System.Drawing.Point(10, 438);
            this.txt_Logradouro_Foco.Name = "txt_Logradouro_Foco";
            this.txt_Logradouro_Foco.Size = new System.Drawing.Size(474, 20);
            this.txt_Logradouro_Foco.TabIndex = 29;
            // 
            // txt_Bairro_Foco
            // 
            this.txt_Bairro_Foco.Location = new System.Drawing.Point(277, 398);
            this.txt_Bairro_Foco.Name = "txt_Bairro_Foco";
            this.txt_Bairro_Foco.Size = new System.Drawing.Size(207, 20);
            this.txt_Bairro_Foco.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "LOGRADOURO:";
            // 
            // txt_Cidade_Foco
            // 
            this.txt_Cidade_Foco.Location = new System.Drawing.Point(60, 398);
            this.txt_Cidade_Foco.Name = "txt_Cidade_Foco";
            this.txt_Cidade_Foco.Size = new System.Drawing.Size(207, 20);
            this.txt_Cidade_Foco.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 32;
            this.label9.Text = "BAIRRO:";
            // 
            // txt_Comentario
            // 
            this.txt_Comentario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Comentario.Location = new System.Drawing.Point(559, 352);
            this.txt_Comentario.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Comentario.Multiline = true;
            this.txt_Comentario.Name = "txt_Comentario";
            this.txt_Comentario.Size = new System.Drawing.Size(400, 91);
            this.txt_Comentario.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 40;
            this.label1.Text = "COMENTÁRIO:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(715, 29);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 27);
            this.btn_Add.TabIndex = 42;
            this.btn_Add.Text = "ADD FOTO";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|JPEG(*.jpeg)|*.jpeg";
            // 
            // btn_SalvarFoco
            // 
            this.btn_SalvarFoco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarFoco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalvarFoco.Location = new System.Drawing.Point(138, 486);
            this.btn_SalvarFoco.Name = "btn_SalvarFoco";
            this.btn_SalvarFoco.Size = new System.Drawing.Size(110, 38);
            this.btn_SalvarFoco.TabIndex = 44;
            this.btn_SalvarFoco.Text = "SALVAR";
            this.btn_SalvarFoco.UseVisualStyleBackColor = true;
            this.btn_SalvarFoco.Click += new System.EventHandler(this.btn_SalvarFoco_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(277, 486);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 38);
            this.btnVoltar.TabIndex = 45;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PortalDengue1.Properties.Resources.WhatsApp_Image_2022_12_04_at_16_20_29;
            this.pictureBox1.Location = new System.Drawing.Point(10, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Foto
            // 
            this.pb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Foto.Location = new System.Drawing.Point(559, 62);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(400, 248);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Foto.TabIndex = 37;
            this.pb_Foto.TabStop = false;
            // 
            // Frm_Denunciations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1055, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btn_SalvarFoco);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Comentario);
            this.Controls.Add(this.pb_Foto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_UF_Foco);
            this.Controls.Add(this.txt_Cep_Foco);
            this.Controls.Add(this.btn_Pesquisar_Foco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Logradouro_Foco);
            this.Controls.Add(this.txt_Bairro_Foco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Cidade_Foco);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Denunciations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label12;
        private Label label3;
        private TextBox txt_UF_Foco;
        private TextBox txt_Cep_Foco;
        private Button btn_Pesquisar_Foco;
        private Label label10;
        private TextBox txt_Logradouro_Foco;
        private TextBox txt_Bairro_Foco;
        private Label label4;
        private TextBox txt_Cidade_Foco;
        private Label label9;
        private PictureBox pb_Foto;
        private TextBox txt_Comentario;
        private Label label1;
        private Button btn_Add;
        private OpenFileDialog openFileDialog1;
        private Button btn_SalvarFoco;
        private Button btnVoltar;
        private PictureBox pictureBox1;
    }
}