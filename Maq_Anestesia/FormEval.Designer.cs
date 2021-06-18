namespace Maq_Anestesia
{
    partial class FormEval
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitleEval = new System.Windows.Forms.Panel();
            this.RestoreSizeEv = new FontAwesome.Sharp.IconButton();
            this.MaximizeEv = new FontAwesome.Sharp.IconButton();
            this.MinimizeEv = new FontAwesome.Sharp.IconButton();
            this.CloseBtnEv = new FontAwesome.Sharp.IconButton();
            this.panelFormEv = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.TestParBtn = new FontAwesome.Sharp.IconButton();
            this.MaqErrorBtn = new FontAwesome.Sharp.IconButton();
            this.EvPatBtn = new FontAwesome.Sharp.IconButton();
            this.CPatBtn = new FontAwesome.Sharp.IconButton();
            this.panelformulario = new System.Windows.Forms.Panel();
            this.TitleEval.SuspendLayout();
            this.panelFormEv.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelformulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(142, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario de control de profesor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleEval
            // 
            this.TitleEval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.TitleEval.Controls.Add(this.RestoreSizeEv);
            this.TitleEval.Controls.Add(this.MaximizeEv);
            this.TitleEval.Controls.Add(this.MinimizeEv);
            this.TitleEval.Controls.Add(this.CloseBtnEv);
            this.TitleEval.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleEval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleEval.Location = new System.Drawing.Point(0, 0);
            this.TitleEval.Name = "TitleEval";
            this.TitleEval.Size = new System.Drawing.Size(960, 52);
            this.TitleEval.TabIndex = 3;
            this.TitleEval.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleEval_Paint);
            this.TitleEval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleEval_MouseDown);
            // 
            // RestoreSizeEv
            // 
            this.RestoreSizeEv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreSizeEv.AutoSize = true;
            this.RestoreSizeEv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RestoreSizeEv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreSizeEv.FlatAppearance.BorderSize = 0;
            this.RestoreSizeEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreSizeEv.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.RestoreSizeEv.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.RestoreSizeEv.IconColor = System.Drawing.Color.MidnightBlue;
            this.RestoreSizeEv.IconSize = 30;
            this.RestoreSizeEv.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RestoreSizeEv.Location = new System.Drawing.Point(884, 1);
            this.RestoreSizeEv.Margin = new System.Windows.Forms.Padding(1);
            this.RestoreSizeEv.Name = "RestoreSizeEv";
            this.RestoreSizeEv.Rotation = 0D;
            this.RestoreSizeEv.Size = new System.Drawing.Size(36, 36);
            this.RestoreSizeEv.TabIndex = 16;
            this.RestoreSizeEv.UseVisualStyleBackColor = true;
            this.RestoreSizeEv.Visible = false;
            this.RestoreSizeEv.Click += new System.EventHandler(this.RestoreSizeEv_Click);
            // 
            // MaximizeEv
            // 
            this.MaximizeEv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeEv.AutoSize = true;
            this.MaximizeEv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximizeEv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeEv.FlatAppearance.BorderSize = 0;
            this.MaximizeEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeEv.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.MaximizeEv.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeEv.IconColor = System.Drawing.Color.MidnightBlue;
            this.MaximizeEv.IconSize = 30;
            this.MaximizeEv.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MaximizeEv.Location = new System.Drawing.Point(884, 5);
            this.MaximizeEv.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeEv.Name = "MaximizeEv";
            this.MaximizeEv.Rotation = 0D;
            this.MaximizeEv.Size = new System.Drawing.Size(36, 36);
            this.MaximizeEv.TabIndex = 15;
            this.MaximizeEv.UseVisualStyleBackColor = true;
            this.MaximizeEv.Click += new System.EventHandler(this.MaximizeEv_Click);
            // 
            // MinimizeEv
            // 
            this.MinimizeEv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeEv.AutoSize = true;
            this.MinimizeEv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimizeEv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeEv.FlatAppearance.BorderSize = 0;
            this.MinimizeEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeEv.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.MinimizeEv.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeEv.IconColor = System.Drawing.Color.MidnightBlue;
            this.MinimizeEv.IconSize = 28;
            this.MinimizeEv.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MinimizeEv.Location = new System.Drawing.Point(844, 3);
            this.MinimizeEv.Margin = new System.Windows.Forms.Padding(1);
            this.MinimizeEv.Name = "MinimizeEv";
            this.MinimizeEv.Rotation = 0D;
            this.MinimizeEv.Size = new System.Drawing.Size(34, 34);
            this.MinimizeEv.TabIndex = 14;
            this.MinimizeEv.UseVisualStyleBackColor = true;
            this.MinimizeEv.Click += new System.EventHandler(this.MinimizeEv_Click);
            // 
            // CloseBtnEv
            // 
            this.CloseBtnEv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtnEv.AutoSize = true;
            this.CloseBtnEv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtnEv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtnEv.FlatAppearance.BorderSize = 0;
            this.CloseBtnEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtnEv.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.CloseBtnEv.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtnEv.IconColor = System.Drawing.Color.MidnightBlue;
            this.CloseBtnEv.IconSize = 30;
            this.CloseBtnEv.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CloseBtnEv.Location = new System.Drawing.Point(922, 5);
            this.CloseBtnEv.Margin = new System.Windows.Forms.Padding(1);
            this.CloseBtnEv.Name = "CloseBtnEv";
            this.CloseBtnEv.Rotation = 0D;
            this.CloseBtnEv.Size = new System.Drawing.Size(36, 36);
            this.CloseBtnEv.TabIndex = 13;
            this.CloseBtnEv.UseVisualStyleBackColor = true;
            this.CloseBtnEv.Click += new System.EventHandler(this.CloseBtnEv_Click);
            // 
            // panelFormEv
            // 
            this.panelFormEv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.panelFormEv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormEv.Controls.Add(this.panelformulario);
            this.panelFormEv.Controls.Add(this.panelMenu);
            this.panelFormEv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormEv.Location = new System.Drawing.Point(0, 0);
            this.panelFormEv.Name = "panelFormEv";
            this.panelFormEv.Size = new System.Drawing.Size(960, 402);
            this.panelFormEv.TabIndex = 4;
            this.panelFormEv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormEv_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.TestParBtn);
            this.panelMenu.Controls.Add(this.MaqErrorBtn);
            this.panelMenu.Controls.Add(this.EvPatBtn);
            this.panelMenu.Controls.Add(this.CPatBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 400);
            this.panelMenu.TabIndex = 2;
            // 
            // TestParBtn
            // 
            this.TestParBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.TestParBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestParBtn.FlatAppearance.BorderSize = 0;
            this.TestParBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestParBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TestParBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestParBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.TestParBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.TestParBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.TestParBtn.IconSize = 50;
            this.TestParBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestParBtn.Location = new System.Drawing.Point(0, 183);
            this.TestParBtn.Name = "TestParBtn";
            this.TestParBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TestParBtn.Rotation = 0D;
            this.TestParBtn.Size = new System.Drawing.Size(251, 61);
            this.TestParBtn.TabIndex = 15;
            this.TestParBtn.Text = "Test";
            this.TestParBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestParBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TestParBtn.UseVisualStyleBackColor = false;
            this.TestParBtn.Click += new System.EventHandler(this.TestParBtn_Click);
            // 
            // MaqErrorBtn
            // 
            this.MaqErrorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.MaqErrorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaqErrorBtn.FlatAppearance.BorderSize = 0;
            this.MaqErrorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaqErrorBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MaqErrorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaqErrorBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.MaqErrorBtn.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.MaqErrorBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.MaqErrorBtn.IconSize = 50;
            this.MaqErrorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaqErrorBtn.Location = new System.Drawing.Point(0, 122);
            this.MaqErrorBtn.Name = "MaqErrorBtn";
            this.MaqErrorBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MaqErrorBtn.Rotation = 0D;
            this.MaqErrorBtn.Size = new System.Drawing.Size(251, 61);
            this.MaqErrorBtn.TabIndex = 14;
            this.MaqErrorBtn.Text = "Errores de máquina";
            this.MaqErrorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaqErrorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MaqErrorBtn.UseVisualStyleBackColor = false;
            this.MaqErrorBtn.Click += new System.EventHandler(this.MaqErrorBtn_Click);
            // 
            // EvPatBtn
            // 
            this.EvPatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.EvPatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EvPatBtn.FlatAppearance.BorderSize = 0;
            this.EvPatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EvPatBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EvPatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvPatBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.EvPatBtn.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.EvPatBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.EvPatBtn.IconSize = 50;
            this.EvPatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EvPatBtn.Location = new System.Drawing.Point(0, 61);
            this.EvPatBtn.Name = "EvPatBtn";
            this.EvPatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EvPatBtn.Rotation = 0D;
            this.EvPatBtn.Size = new System.Drawing.Size(251, 61);
            this.EvPatBtn.TabIndex = 13;
            this.EvPatBtn.Text = "Paciente";
            this.EvPatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EvPatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EvPatBtn.UseVisualStyleBackColor = true;
            this.EvPatBtn.Click += new System.EventHandler(this.EvPatBtn_Click);
            // 
            // CPatBtn
            // 
            this.CPatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.CPatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CPatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPatBtn.FlatAppearance.BorderSize = 0;
            this.CPatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPatBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CPatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPatBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.CPatBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CPatBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CPatBtn.IconSize = 50;
            this.CPatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPatBtn.Location = new System.Drawing.Point(0, 0);
            this.CPatBtn.Name = "CPatBtn";
            this.CPatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CPatBtn.Rotation = 0D;
            this.CPatBtn.Size = new System.Drawing.Size(251, 61);
            this.CPatBtn.TabIndex = 12;
            this.CPatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPatBtn.UseVisualStyleBackColor = false;
            // 
            // panelformulario
            // 
            this.panelformulario.Controls.Add(this.label1);
            this.panelformulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformulario.Location = new System.Drawing.Point(251, 0);
            this.panelformulario.Name = "panelformulario";
            this.panelformulario.Size = new System.Drawing.Size(707, 400);
            this.panelformulario.TabIndex = 3;
            this.panelformulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelformulario_Paint);
            // 
            // FormEval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 402);
            this.Controls.Add(this.TitleEval);
            this.Controls.Add(this.panelFormEv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(980, 515);
            this.MinimumSize = new System.Drawing.Size(960, 340);
            this.Name = "FormEval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormEval";
            this.Load += new System.EventHandler(this.FormEval_Load);
            this.Shown += new System.EventHandler(this.FormEval_Shown);
            this.TitleEval.ResumeLayout(false);
            this.TitleEval.PerformLayout();
            this.panelFormEv.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelformulario.ResumeLayout(false);
            this.panelformulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TitleEval;
        private System.Windows.Forms.Panel panelFormEv;
        private FontAwesome.Sharp.IconButton MaximizeEv;
        private FontAwesome.Sharp.IconButton MinimizeEv;
        private FontAwesome.Sharp.IconButton CloseBtnEv;
        private FontAwesome.Sharp.IconButton RestoreSizeEv;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton TestParBtn;
        private FontAwesome.Sharp.IconButton MaqErrorBtn;
        private FontAwesome.Sharp.IconButton EvPatBtn;
        private FontAwesome.Sharp.IconButton CPatBtn;
        private System.Windows.Forms.Panel panelformulario;
    }
}