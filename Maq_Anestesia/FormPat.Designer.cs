namespace Maq_Anestesia
{
    partial class FormPat
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
            this.TitlePat = new System.Windows.Forms.Panel();
            this.MaximizeP = new FontAwesome.Sharp.IconButton();
            this.RestoreSizeP = new FontAwesome.Sharp.IconButton();
            this.MinimizeP = new FontAwesome.Sharp.IconButton();
            this.CloseBtnP = new FontAwesome.Sharp.IconButton();
            this.panelFormPat = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.etco2val = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TempVal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.predeterminados = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PdiastText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PsisText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.frecC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AgeVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PatWe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResPac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ElastPac = new System.Windows.Forms.TextBox();
            this.sendPatBtn = new System.Windows.Forms.Button();
            this.TitlePat.SuspendLayout();
            this.panelFormPat.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePat
            // 
            this.TitlePat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.TitlePat.Controls.Add(this.MaximizeP);
            this.TitlePat.Controls.Add(this.RestoreSizeP);
            this.TitlePat.Controls.Add(this.MinimizeP);
            this.TitlePat.Controls.Add(this.CloseBtnP);
            this.TitlePat.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitlePat.Location = new System.Drawing.Point(0, 0);
            this.TitlePat.Name = "TitlePat";
            this.TitlePat.Size = new System.Drawing.Size(960, 52);
            this.TitlePat.TabIndex = 3;
            this.TitlePat.Paint += new System.Windows.Forms.PaintEventHandler(this.TitlePat_Paint);
            this.TitlePat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePat_MouseDown);
            // 
            // MaximizeP
            // 
            this.MaximizeP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeP.AutoSize = true;
            this.MaximizeP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximizeP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeP.FlatAppearance.BorderSize = 0;
            this.MaximizeP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeP.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.MaximizeP.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeP.IconColor = System.Drawing.Color.NavajoWhite;
            this.MaximizeP.IconSize = 30;
            this.MaximizeP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MaximizeP.Location = new System.Drawing.Point(880, 10);
            this.MaximizeP.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeP.Name = "MaximizeP";
            this.MaximizeP.Rotation = 0D;
            this.MaximizeP.Size = new System.Drawing.Size(36, 36);
            this.MaximizeP.TabIndex = 8;
            this.MaximizeP.UseVisualStyleBackColor = true;
            this.MaximizeP.Click += new System.EventHandler(this.MaximizeP_Click);
            // 
            // RestoreSizeP
            // 
            this.RestoreSizeP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreSizeP.AutoSize = true;
            this.RestoreSizeP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RestoreSizeP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreSizeP.FlatAppearance.BorderSize = 0;
            this.RestoreSizeP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreSizeP.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.RestoreSizeP.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.RestoreSizeP.IconColor = System.Drawing.Color.NavajoWhite;
            this.RestoreSizeP.IconSize = 30;
            this.RestoreSizeP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RestoreSizeP.Location = new System.Drawing.Point(882, 9);
            this.RestoreSizeP.Margin = new System.Windows.Forms.Padding(1);
            this.RestoreSizeP.Name = "RestoreSizeP";
            this.RestoreSizeP.Rotation = 0D;
            this.RestoreSizeP.Size = new System.Drawing.Size(36, 36);
            this.RestoreSizeP.TabIndex = 7;
            this.RestoreSizeP.UseVisualStyleBackColor = true;
            this.RestoreSizeP.Visible = false;
            this.RestoreSizeP.Click += new System.EventHandler(this.RestoreSizeP_Click);
            // 
            // MinimizeP
            // 
            this.MinimizeP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeP.AutoSize = true;
            this.MinimizeP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimizeP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeP.FlatAppearance.BorderSize = 0;
            this.MinimizeP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeP.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.MinimizeP.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeP.IconColor = System.Drawing.Color.NavajoWhite;
            this.MinimizeP.IconSize = 28;
            this.MinimizeP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MinimizeP.Location = new System.Drawing.Point(844, 9);
            this.MinimizeP.Margin = new System.Windows.Forms.Padding(1);
            this.MinimizeP.Name = "MinimizeP";
            this.MinimizeP.Rotation = 0D;
            this.MinimizeP.Size = new System.Drawing.Size(34, 34);
            this.MinimizeP.TabIndex = 6;
            this.MinimizeP.UseVisualStyleBackColor = true;
            this.MinimizeP.Click += new System.EventHandler(this.MinimizeP_Click);
            // 
            // CloseBtnP
            // 
            this.CloseBtnP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtnP.AutoSize = true;
            this.CloseBtnP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtnP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtnP.FlatAppearance.BorderSize = 0;
            this.CloseBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtnP.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.CloseBtnP.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtnP.IconColor = System.Drawing.Color.NavajoWhite;
            this.CloseBtnP.IconSize = 30;
            this.CloseBtnP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CloseBtnP.Location = new System.Drawing.Point(922, 11);
            this.CloseBtnP.Margin = new System.Windows.Forms.Padding(1);
            this.CloseBtnP.Name = "CloseBtnP";
            this.CloseBtnP.Rotation = 0D;
            this.CloseBtnP.Size = new System.Drawing.Size(36, 36);
            this.CloseBtnP.TabIndex = 5;
            this.CloseBtnP.UseVisualStyleBackColor = true;
            this.CloseBtnP.Click += new System.EventHandler(this.CloseBtnP_Click);
            // 
            // panelFormPat
            // 
            this.panelFormPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.panelFormPat.Controls.Add(this.label19);
            this.panelFormPat.Controls.Add(this.label20);
            this.panelFormPat.Controls.Add(this.etco2val);
            this.panelFormPat.Controls.Add(this.label18);
            this.panelFormPat.Controls.Add(this.label16);
            this.panelFormPat.Controls.Add(this.label17);
            this.panelFormPat.Controls.Add(this.TempVal);
            this.panelFormPat.Controls.Add(this.label15);
            this.panelFormPat.Controls.Add(this.predeterminados);
            this.panelFormPat.Controls.Add(this.label13);
            this.panelFormPat.Controls.Add(this.label14);
            this.panelFormPat.Controls.Add(this.PdiastText);
            this.panelFormPat.Controls.Add(this.label11);
            this.panelFormPat.Controls.Add(this.label12);
            this.panelFormPat.Controls.Add(this.PsisText);
            this.panelFormPat.Controls.Add(this.label7);
            this.panelFormPat.Controls.Add(this.label10);
            this.panelFormPat.Controls.Add(this.frecC);
            this.panelFormPat.Controls.Add(this.label9);
            this.panelFormPat.Controls.Add(this.label8);
            this.panelFormPat.Controls.Add(this.AgeVal);
            this.panelFormPat.Controls.Add(this.label1);
            this.panelFormPat.Controls.Add(this.label6);
            this.panelFormPat.Controls.Add(this.PatWe);
            this.panelFormPat.Controls.Add(this.label4);
            this.panelFormPat.Controls.Add(this.label5);
            this.panelFormPat.Controls.Add(this.ResPac);
            this.panelFormPat.Controls.Add(this.label3);
            this.panelFormPat.Controls.Add(this.label2);
            this.panelFormPat.Controls.Add(this.ElastPac);
            this.panelFormPat.Controls.Add(this.sendPatBtn);
            this.panelFormPat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormPat.Location = new System.Drawing.Point(0, 0);
            this.panelFormPat.Name = "panelFormPat";
            this.panelFormPat.Size = new System.Drawing.Size(960, 400);
            this.panelFormPat.TabIndex = 4;
            this.panelFormPat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormPat_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label19.Location = new System.Drawing.Point(679, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 20);
            this.label19.TabIndex = 69;
            this.label19.Text = "mmHg";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label20.Location = new System.Drawing.Point(421, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 20);
            this.label20.TabIndex = 68;
            this.label20.Text = "EtCO2";
            // 
            // etco2val
            // 
            this.etco2val.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etco2val.Location = new System.Drawing.Point(536, 247);
            this.etco2val.Name = "etco2val";
            this.etco2val.Size = new System.Drawing.Size(124, 26);
            this.etco2val.TabIndex = 67;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label18.Location = new System.Drawing.Point(28, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(222, 25);
            this.label18.TabIndex = 66;
            this.label18.Text = "Parámetros del paciente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label16.Location = new System.Drawing.Point(679, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 20);
            this.label16.TabIndex = 65;
            this.label16.Text = "°C";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label17.Location = new System.Drawing.Point(421, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 20);
            this.label17.TabIndex = 64;
            this.label17.Text = "Temperatura";
            // 
            // TempVal
            // 
            this.TempVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempVal.Location = new System.Drawing.Point(536, 203);
            this.TempVal.Name = "TempVal";
            this.TempVal.Size = new System.Drawing.Size(124, 26);
            this.TempVal.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label15.Location = new System.Drawing.Point(320, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 20);
            this.label15.TabIndex = 62;
            this.label15.Text = "Predeterminados";
            // 
            // predeterminados
            // 
            this.predeterminados.DisplayMember = "0";
            this.predeterminados.FormattingEnabled = true;
            this.predeterminados.Items.AddRange(new object[] {
            "Paciente sano",
            "EPOC",
            "Hipotension",
            "Hipertension"});
            this.predeterminados.Location = new System.Drawing.Point(469, 71);
            this.predeterminados.Name = "predeterminados";
            this.predeterminados.Size = new System.Drawing.Size(140, 24);
            this.predeterminados.TabIndex = 61;
            this.predeterminados.SelectedIndexChanged += new System.EventHandler(this.predeterminados_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label13.Location = new System.Drawing.Point(283, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 60;
            this.label13.Text = "mmHg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label14.Location = new System.Drawing.Point(26, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 40);
            this.label14.TabIndex = 59;
            this.label14.Text = "Presión\r\ndiastólica";
            // 
            // PdiastText
            // 
            this.PdiastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdiastText.Location = new System.Drawing.Point(141, 305);
            this.PdiastText.Name = "PdiastText";
            this.PdiastText.Size = new System.Drawing.Size(124, 26);
            this.PdiastText.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label11.Location = new System.Drawing.Point(283, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "mmHg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label12.Location = new System.Drawing.Point(25, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 40);
            this.label12.TabIndex = 56;
            this.label12.Text = "Presión \r\nSistólica";
            // 
            // PsisText
            // 
            this.PsisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PsisText.Location = new System.Drawing.Point(140, 259);
            this.PsisText.Name = "PsisText";
            this.PsisText.Size = new System.Drawing.Size(124, 26);
            this.PsisText.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(284, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "lat/min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label10.Location = new System.Drawing.Point(26, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Frec. card.";
            // 
            // frecC
            // 
            this.frecC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frecC.Location = new System.Drawing.Point(141, 212);
            this.frecC.Name = "frecC";
            this.frecC.Size = new System.Drawing.Size(124, 26);
            this.frecC.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(679, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "años";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label8.Location = new System.Drawing.Point(421, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Edad";
            // 
            // AgeVal
            // 
            this.AgeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeVal.Location = new System.Drawing.Point(536, 161);
            this.AgeVal.Name = "AgeVal";
            this.AgeVal.Size = new System.Drawing.Size(124, 26);
            this.AgeVal.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(679, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(421, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Peso";
            // 
            // PatWe
            // 
            this.PatWe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatWe.Location = new System.Drawing.Point(536, 118);
            this.PatWe.Name = "PatWe";
            this.PatWe.Size = new System.Drawing.Size(124, 26);
            this.PatWe.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(283, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "cmH20*min/l";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(25, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Resistencia";
            // 
            // ResPac
            // 
            this.ResPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResPac.Location = new System.Drawing.Point(140, 166);
            this.ResPac.Name = "ResPac";
            this.ResPac.Size = new System.Drawing.Size(124, 26);
            this.ResPac.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(283, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "cmH2O/l";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Elastancia";
            // 
            // ElastPac
            // 
            this.ElastPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElastPac.Location = new System.Drawing.Point(140, 119);
            this.ElastPac.Name = "ElastPac";
            this.ElastPac.Size = new System.Drawing.Size(124, 26);
            this.ElastPac.TabIndex = 40;
            // 
            // sendPatBtn
            // 
            this.sendPatBtn.Location = new System.Drawing.Point(794, 189);
            this.sendPatBtn.Name = "sendPatBtn";
            this.sendPatBtn.Size = new System.Drawing.Size(140, 43);
            this.sendPatBtn.TabIndex = 2;
            this.sendPatBtn.Text = "send";
            this.sendPatBtn.UseVisualStyleBackColor = true;
            this.sendPatBtn.Click += new System.EventHandler(this.sendPatBtn_Click);
            // 
            // FormPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 400);
            this.Controls.Add(this.TitlePat);
            this.Controls.Add(this.panelFormPat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(980, 515);
            this.MinimumSize = new System.Drawing.Size(960, 340);
            this.Name = "FormPat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPat";
            this.Shown += new System.EventHandler(this.FormPat_Shown);
            this.TitlePat.ResumeLayout(false);
            this.TitlePat.PerformLayout();
            this.panelFormPat.ResumeLayout(false);
            this.panelFormPat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitlePat;
        private System.Windows.Forms.Panel panelFormPat;
        private FontAwesome.Sharp.IconButton RestoreSizeP;
        private FontAwesome.Sharp.IconButton MinimizeP;
        private FontAwesome.Sharp.IconButton CloseBtnP;
        private FontAwesome.Sharp.IconButton MaximizeP;
        private System.Windows.Forms.Button sendPatBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox etco2val;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TempVal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox predeterminados;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PdiastText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PsisText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox frecC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AgeVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PatWe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ResPac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ElastPac;
    }
}