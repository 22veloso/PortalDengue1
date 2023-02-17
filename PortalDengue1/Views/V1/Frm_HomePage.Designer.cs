using System.Windows.Forms;

namespace PortalDengue1.Views.V1
{
    partial class Frm_HomePage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.BarraMenu = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Complaint = new System.Windows.Forms.Button();
            this.btn_CasesRegister = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Denunciations = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Foco = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Informação = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Tela_inicial = new System.Windows.Forms.Panel();
            this.lbl_District5 = new System.Windows.Forms.Label();
            this.lbl_District4 = new System.Windows.Forms.Label();
            this.lbl_District3 = new System.Windows.Forms.Label();
            this.lbl_District2 = new System.Windows.Forms.Label();
            this.lbl_District1 = new System.Windows.Forms.Label();
            this.lbl_NumberCases = new System.Windows.Forms.Label();
            this.lbl_Top5 = new System.Windows.Forms.Label();
            this.lbl_Districts = new System.Windows.Forms.Label();
            this.cht_Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_adm = new System.Windows.Forms.Button();
            this.lb_AcessoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NomeUsuario = new System.Windows.Forms.Label();
            this.pb_Logado = new System.Windows.Forms.PictureBox();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraMenu.SuspendLayout();
            this.Tela_inicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Graphic)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraMenu
            // 
            this.BarraMenu.BackColor = System.Drawing.Color.White;
            this.BarraMenu.Controls.Add(this.panel9);
            this.BarraMenu.Controls.Add(this.btn_Complaint);
            this.BarraMenu.Controls.Add(this.btn_CasesRegister);
            this.BarraMenu.Controls.Add(this.panel8);
            this.BarraMenu.Controls.Add(this.btn_Denunciations);
            this.BarraMenu.Controls.Add(this.panel7);
            this.BarraMenu.Controls.Add(this.panel4);
            this.BarraMenu.Controls.Add(this.panel3);
            this.BarraMenu.Controls.Add(this.panel2);
            this.BarraMenu.Controls.Add(this.btn_Foco);
            this.BarraMenu.Controls.Add(this.btn_Cadastrar);
            this.BarraMenu.Controls.Add(this.btn_Informação);
            this.BarraMenu.Controls.Add(this.btn_Sair);
            this.BarraMenu.Controls.Add(this.panel1);
            this.BarraMenu.Controls.Add(this.btn_Login);
            this.BarraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(175, 563);
            this.BarraMenu.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Location = new System.Drawing.Point(0, 155);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(9, 32);
            this.panel9.TabIndex = 15;
            // 
            // btn_Complaint
            // 
            this.btn_Complaint.BackColor = System.Drawing.Color.White;
            this.btn_Complaint.FlatAppearance.BorderSize = 0;
            this.btn_Complaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Complaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Complaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Complaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Complaint.Image = global::PortalDengue1.Properties.Resources.icons8_megafone_24;
            this.btn_Complaint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Complaint.Location = new System.Drawing.Point(7, 155);
            this.btn_Complaint.Name = "btn_Complaint";
            this.btn_Complaint.Size = new System.Drawing.Size(165, 32);
            this.btn_Complaint.TabIndex = 14;
            this.btn_Complaint.Text = "DENÚNCIAS";
            this.btn_Complaint.UseVisualStyleBackColor = false;
            this.btn_Complaint.Click += new System.EventHandler(this.btn_Complaint_Click);
            // 
            // btn_CasesRegister
            // 
            this.btn_CasesRegister.BackColor = System.Drawing.Color.White;
            this.btn_CasesRegister.FlatAppearance.BorderSize = 0;
            this.btn_CasesRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CasesRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CasesRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CasesRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_CasesRegister.Image = global::PortalDengue1.Properties.Resources.icons8_ms_excel_24;
            this.btn_CasesRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CasesRegister.Location = new System.Drawing.Point(9, 193);
            this.btn_CasesRegister.Name = "btn_CasesRegister";
            this.btn_CasesRegister.Size = new System.Drawing.Size(167, 32);
            this.btn_CasesRegister.TabIndex = 13;
            this.btn_CasesRegister.Text = "  NOVOS CASOS";
            this.btn_CasesRegister.UseVisualStyleBackColor = false;
            this.btn_CasesRegister.Click += new System.EventHandler(this.btn_CasesRegister_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Location = new System.Drawing.Point(0, 231);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(9, 32);
            this.panel8.TabIndex = 12;
            // 
            // btn_Denunciations
            // 
            this.btn_Denunciations.BackColor = System.Drawing.Color.White;
            this.btn_Denunciations.FlatAppearance.BorderSize = 0;
            this.btn_Denunciations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Denunciations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Denunciations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Denunciations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Denunciations.Image = global::PortalDengue1.Properties.Resources.icons8_megafone_24;
            this.btn_Denunciations.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Denunciations.Location = new System.Drawing.Point(7, 231);
            this.btn_Denunciations.Name = "btn_Denunciations";
            this.btn_Denunciations.Size = new System.Drawing.Size(165, 32);
            this.btn_Denunciations.TabIndex = 11;
            this.btn_Denunciations.Text = "     ADM DENÚNCIAS";
            this.btn_Denunciations.UseVisualStyleBackColor = false;
            this.btn_Denunciations.Click += new System.EventHandler(this.btn_Denunciations_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(0, 193);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(9, 32);
            this.panel7.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(0, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(9, 32);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 32);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 32);
            this.panel2.TabIndex = 7;
            // 
            // btn_Foco
            // 
            this.btn_Foco.BackColor = System.Drawing.Color.White;
            this.btn_Foco.FlatAppearance.BorderSize = 0;
            this.btn_Foco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Foco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Foco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Foco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Foco.Image = global::PortalDengue1.Properties.Resources.icons8_olhos_dos_desenhos_animados_24;
            this.btn_Foco.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Foco.Location = new System.Drawing.Point(9, 117);
            this.btn_Foco.Name = "btn_Foco";
            this.btn_Foco.Size = new System.Drawing.Size(174, 32);
            this.btn_Foco.TabIndex = 6;
            this.btn_Foco.Text = "    FOCO NO FOCO";
            this.btn_Foco.UseVisualStyleBackColor = false;
            this.btn_Foco.Click += new System.EventHandler(this.btn_Foco_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Cadastrar.Image = global::PortalDengue1.Properties.Resources.icons8_editar_usuário_masculino_24;
            this.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Cadastrar.Location = new System.Drawing.Point(10, 42);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(166, 32);
            this.btn_Cadastrar.TabIndex = 5;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Informação
            // 
            this.btn_Informação.BackColor = System.Drawing.Color.White;
            this.btn_Informação.FlatAppearance.BorderSize = 0;
            this.btn_Informação.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Informação.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Informação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Informação.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Informação.Image = global::PortalDengue1.Properties.Resources.icons8_domínio_26;
            this.btn_Informação.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Informação.Location = new System.Drawing.Point(10, 80);
            this.btn_Informação.Name = "btn_Informação";
            this.btn_Informação.Size = new System.Drawing.Size(166, 32);
            this.btn_Informação.TabIndex = 4;
            this.btn_Informação.Text = "    SOBRE O APP";
            this.btn_Informação.UseVisualStyleBackColor = false;
            this.btn_Informação.Click += new System.EventHandler(this.btn_Informação_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Sair.Image = global::PortalDengue1.Properties.Resources.icons8_desligar_24;
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Sair.Location = new System.Drawing.Point(0, 531);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(175, 32);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 32);
            this.panel1.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Login.Image = global::PortalDengue1.Properties.Resources.icons8_entrar_24;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Login.Location = new System.Drawing.Point(10, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(166, 32);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "LOGAR";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // Tela_inicial
            // 
            this.Tela_inicial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tela_inicial.Controls.Add(this.lbl_District5);
            this.Tela_inicial.Controls.Add(this.lbl_District4);
            this.Tela_inicial.Controls.Add(this.lbl_District3);
            this.Tela_inicial.Controls.Add(this.lbl_District2);
            this.Tela_inicial.Controls.Add(this.lbl_District1);
            this.Tela_inicial.Controls.Add(this.lbl_NumberCases);
            this.Tela_inicial.Controls.Add(this.lbl_Top5);
            this.Tela_inicial.Controls.Add(this.lbl_Districts);
            this.Tela_inicial.Controls.Add(this.cht_Graphic);
            this.Tela_inicial.Controls.Add(this.panel5);
            this.Tela_inicial.Controls.Add(this.pictureBox1);
            this.Tela_inicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tela_inicial.Location = new System.Drawing.Point(175, 0);
            this.Tela_inicial.Name = "Tela_inicial";
            this.Tela_inicial.Size = new System.Drawing.Size(939, 563);
            this.Tela_inicial.TabIndex = 2;
            // 
            // lbl_District5
            // 
            this.lbl_District5.AutoSize = true;
            this.lbl_District5.Location = new System.Drawing.Point(592, 276);
            this.lbl_District5.Name = "lbl_District5";
            this.lbl_District5.Size = new System.Drawing.Size(35, 13);
            this.lbl_District5.TabIndex = 15;
            this.lbl_District5.Text = "label8";
            // 
            // lbl_District4
            // 
            this.lbl_District4.AutoSize = true;
            this.lbl_District4.Location = new System.Drawing.Point(592, 263);
            this.lbl_District4.Name = "lbl_District4";
            this.lbl_District4.Size = new System.Drawing.Size(35, 13);
            this.lbl_District4.TabIndex = 14;
            this.lbl_District4.Text = "label7";
            // 
            // lbl_District3
            // 
            this.lbl_District3.AutoSize = true;
            this.lbl_District3.Location = new System.Drawing.Point(592, 250);
            this.lbl_District3.Name = "lbl_District3";
            this.lbl_District3.Size = new System.Drawing.Size(35, 13);
            this.lbl_District3.TabIndex = 13;
            this.lbl_District3.Text = "label6";
            // 
            // lbl_District2
            // 
            this.lbl_District2.AutoSize = true;
            this.lbl_District2.Location = new System.Drawing.Point(592, 238);
            this.lbl_District2.Name = "lbl_District2";
            this.lbl_District2.Size = new System.Drawing.Size(35, 13);
            this.lbl_District2.TabIndex = 12;
            this.lbl_District2.Text = "label5";
            // 
            // lbl_District1
            // 
            this.lbl_District1.AutoSize = true;
            this.lbl_District1.Location = new System.Drawing.Point(592, 225);
            this.lbl_District1.Name = "lbl_District1";
            this.lbl_District1.Size = new System.Drawing.Size(35, 13);
            this.lbl_District1.TabIndex = 11;
            this.lbl_District1.Text = "label4";
            // 
            // lbl_NumberCases
            // 
            this.lbl_NumberCases.AutoSize = true;
            this.lbl_NumberCases.Location = new System.Drawing.Point(552, 204);
            this.lbl_NumberCases.Name = "lbl_NumberCases";
            this.lbl_NumberCases.Size = new System.Drawing.Size(90, 13);
            this.lbl_NumberCases.TabIndex = 10;
            this.lbl_NumberCases.Text = "Número de casos";
            // 
            // lbl_Top5
            // 
            this.lbl_Top5.AutoSize = true;
            this.lbl_Top5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Top5.Location = new System.Drawing.Point(195, 160);
            this.lbl_Top5.Name = "lbl_Top5";
            this.lbl_Top5.Size = new System.Drawing.Size(447, 22);
            this.lbl_Top5.TabIndex = 9;
            this.lbl_Top5.Text = "TOP 5 BAIRROS COM MAIS CASOS CONFIRMADOS";
            // 
            // lbl_Districts
            // 
            this.lbl_Districts.AutoSize = true;
            this.lbl_Districts.Location = new System.Drawing.Point(671, 204);
            this.lbl_Districts.Name = "lbl_Districts";
            this.lbl_Districts.Size = new System.Drawing.Size(39, 13);
            this.lbl_Districts.TabIndex = 8;
            this.lbl_Districts.Text = "Bairros";
            // 
            // cht_Graphic
            // 
            chartArea3.Name = "ChartArea1";
            this.cht_Graphic.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cht_Graphic.Legends.Add(legend3);
            this.cht_Graphic.Location = new System.Drawing.Point(180, 210);
            this.cht_Graphic.Name = "cht_Graphic";
            this.cht_Graphic.Size = new System.Drawing.Size(631, 288);
            this.cht_Graphic.TabIndex = 1;
            this.cht_Graphic.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.btn_adm);
            this.panel5.Controls.Add(this.lb_AcessoUsuario);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lb_NomeUsuario);
            this.panel5.Controls.Add(this.pb_Logado);
            this.panel5.Controls.Add(this.lb_Usuario);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 531);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 32);
            this.panel5.TabIndex = 0;
            // 
            // btn_adm
            // 
            this.btn_adm.BackColor = System.Drawing.Color.Silver;
            this.btn_adm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_adm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adm.Location = new System.Drawing.Point(957, 0);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(9, 26);
            this.btn_adm.TabIndex = 1;
            this.btn_adm.UseVisualStyleBackColor = false;
            // 
            // lb_AcessoUsuario
            // 
            this.lb_AcessoUsuario.AutoSize = true;
            this.lb_AcessoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AcessoUsuario.Location = new System.Drawing.Point(91, 8);
            this.lb_AcessoUsuario.Name = "lb_AcessoUsuario";
            this.lb_AcessoUsuario.Size = new System.Drawing.Size(14, 15);
            this.lb_AcessoUsuario.TabIndex = 11;
            this.lb_AcessoUsuario.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Acesso:";
            // 
            // lb_NomeUsuario
            // 
            this.lb_NomeUsuario.AutoSize = true;
            this.lb_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeUsuario.Location = new System.Drawing.Point(165, 7);
            this.lb_NomeUsuario.Name = "lb_NomeUsuario";
            this.lb_NomeUsuario.Size = new System.Drawing.Size(19, 16);
            this.lb_NomeUsuario.TabIndex = 9;
            this.lb_NomeUsuario.Text = "---";
            // 
            // pb_Logado
            // 
            this.pb_Logado.Image = global::PortalDengue1.Properties.Resources.icons8_red_circle_48;
            this.pb_Logado.Location = new System.Drawing.Point(5, 0);
            this.pb_Logado.Name = "pb_Logado";
            this.pb_Logado.Size = new System.Drawing.Size(31, 32);
            this.pb_Logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logado.TabIndex = 6;
            this.pb_Logado.TabStop = false;
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Usuario.Location = new System.Drawing.Point(111, 8);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(57, 16);
            this.lb_Usuario.TabIndex = 7;
            this.lb_Usuario.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PortalDengue1.Properties.Resources.___removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1114, 563);
            this.Controls.Add(this.Tela_inicial);
            this.Controls.Add(this.BarraMenu);
            this.Name = "Frm_HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_HomePage_Load);
            this.BarraMenu.ResumeLayout(false);
            this.Tela_inicial.ResumeLayout(false);
            this.Tela_inicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Graphic)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel BarraMenu;
        private Panel Tela_inicial;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btn_Foco;
        private Button btn_Cadastrar;
        private Button btn_Informação;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        public Label lb_NomeUsuario;
        public PictureBox pb_Logado;
        public Label lb_Usuario;
        public Label lb_AcessoUsuario;
        public Label label1;
        public Button btn_Login;
        public Button btn_Denunciations;
        public Button btn_CasesRegister;
        public Panel panel7;
        public Panel panel8;
        public Panel panel9;
        public Button btn_Complaint;
        public System.Windows.Forms.DataVisualization.Charting.Chart cht_Graphic;
        private Label lbl_Districts;
        private Label lbl_Top5;
        private Button btn_adm;
        private Button btn_Sair;
        private Label lbl_NumberCases;
        private Label lbl_District1;
        private Label lbl_District5;
        private Label lbl_District4;
        private Label lbl_District3;
        private Label lbl_District2;
    }
}