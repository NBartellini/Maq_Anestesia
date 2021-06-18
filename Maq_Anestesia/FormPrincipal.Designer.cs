namespace Maq_Anestesia
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.DisplayMenu = new FontAwesome.Sharp.IconButton();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.Maximize = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.RestoreSize = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.CMasterBtn = new FontAwesome.Sharp.IconButton();
            this.CMaqBtn = new FontAwesome.Sharp.IconButton();
            this.CPatBtn = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.HomeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Info;
            this.panelContenedor.Controls.Add(this.panelTitleBar);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(960, 1030);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.panelTitleBar.Controls.Add(this.DisplayMenu);
            this.panelTitleBar.Controls.Add(this.Minimize);
            this.panelTitleBar.Controls.Add(this.Maximize);
            this.panelTitleBar.Controls.Add(this.CloseBtn);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.RestoreSize);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(251, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(709, 82);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // DisplayMenu
            // 
            this.DisplayMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DisplayMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            this.DisplayMenu.IconColor = System.Drawing.Color.MediumOrchid;
            this.DisplayMenu.IconSize = 40;
            this.DisplayMenu.Location = new System.Drawing.Point(6, 16);
            this.DisplayMenu.Name = "DisplayMenu";
            this.DisplayMenu.Rotation = 0D;
            this.DisplayMenu.Size = new System.Drawing.Size(50, 42);
            this.DisplayMenu.TabIndex = 5;
            this.DisplayMenu.UseVisualStyleBackColor = false;
            this.DisplayMenu.Click += new System.EventHandler(this.DisplayMenu_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimize.IconColor = System.Drawing.Color.Orchid;
            this.Minimize.IconSize = 28;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Minimize.Location = new System.Drawing.Point(579, 23);
            this.Minimize.Margin = new System.Windows.Forms.Padding(1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Rotation = 0D;
            this.Minimize.Size = new System.Drawing.Size(36, 36);
            this.Minimize.TabIndex = 3;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.AutoSize = true;
            this.Maximize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.Maximize.IconColor = System.Drawing.Color.Orchid;
            this.Maximize.IconSize = 30;
            this.Maximize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Maximize.Location = new System.Drawing.Point(628, 22);
            this.Maximize.Margin = new System.Windows.Forms.Padding(1);
            this.Maximize.Name = "Maximize";
            this.Maximize.Rotation = 0D;
            this.Maximize.Size = new System.Drawing.Size(38, 38);
            this.Maximize.TabIndex = 2;
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtn.IconColor = System.Drawing.Color.Orchid;
            this.CloseBtn.IconSize = 30;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CloseBtn.Location = new System.Drawing.Point(668, 23);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Rotation = 0D;
            this.CloseBtn.Size = new System.Drawing.Size(38, 38);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconSize = 43;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(72, 15);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(49, 43);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // RestoreSize
            // 
            this.RestoreSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreSize.AutoSize = true;
            this.RestoreSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RestoreSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreSize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.RestoreSize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.RestoreSize.IconColor = System.Drawing.Color.Orchid;
            this.RestoreSize.IconSize = 30;
            this.RestoreSize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RestoreSize.Location = new System.Drawing.Point(628, 21);
            this.RestoreSize.Margin = new System.Windows.Forms.Padding(1);
            this.RestoreSize.Name = "RestoreSize";
            this.RestoreSize.Rotation = 0D;
            this.RestoreSize.Size = new System.Drawing.Size(38, 38);
            this.RestoreSize.TabIndex = 4;
            this.RestoreSize.UseVisualStyleBackColor = true;
            this.RestoreSize.Visible = false;
            this.RestoreSize.Click += new System.EventHandler(this.RestoreSize_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.CMasterBtn);
            this.panelMenu.Controls.Add(this.CMaqBtn);
            this.panelMenu.Controls.Add(this.CPatBtn);
            this.panelMenu.Controls.Add(this.PanelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 1030);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // CMasterBtn
            // 
            this.CMasterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.CMasterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CMasterBtn.FlatAppearance.BorderSize = 0;
            this.CMasterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMasterBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CMasterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMasterBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.CMasterBtn.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.CMasterBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CMasterBtn.IconSize = 50;
            this.CMasterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CMasterBtn.Location = new System.Drawing.Point(0, 325);
            this.CMasterBtn.Name = "CMasterBtn";
            this.CMasterBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CMasterBtn.Rotation = 0D;
            this.CMasterBtn.Size = new System.Drawing.Size(251, 88);
            this.CMasterBtn.TabIndex = 15;
            this.CMasterBtn.Text = "Evaluación";
            this.CMasterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CMasterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CMasterBtn.UseMnemonic = false;
            this.CMasterBtn.UseVisualStyleBackColor = false;
            this.CMasterBtn.Click += new System.EventHandler(this.CMasterBtn_Click);
            // 
            // CMaqBtn
            // 
            this.CMaqBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.CMaqBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CMaqBtn.FlatAppearance.BorderSize = 0;
            this.CMaqBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMaqBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CMaqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMaqBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.CMaqBtn.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.CMaqBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CMaqBtn.IconSize = 50;
            this.CMaqBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CMaqBtn.Location = new System.Drawing.Point(0, 237);
            this.CMaqBtn.Name = "CMaqBtn";
            this.CMaqBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CMaqBtn.Rotation = 0D;
            this.CMaqBtn.Size = new System.Drawing.Size(251, 88);
            this.CMaqBtn.TabIndex = 13;
            this.CMaqBtn.Text = "Control de la máquina";
            this.CMaqBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CMaqBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CMaqBtn.UseVisualStyleBackColor = false;
            this.CMaqBtn.Click += new System.EventHandler(this.CMaqBtn_Click);
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
            this.CPatBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.CPatBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CPatBtn.IconSize = 50;
            this.CPatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPatBtn.Location = new System.Drawing.Point(0, 149);
            this.CPatBtn.Name = "CPatBtn";
            this.CPatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CPatBtn.Rotation = 0D;
            this.CPatBtn.Size = new System.Drawing.Size(251, 88);
            this.CPatBtn.TabIndex = 12;
            this.CPatBtn.Text = "Control de paciente";
            this.CPatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPatBtn.UseVisualStyleBackColor = false;
            this.CPatBtn.Click += new System.EventHandler(this.CPatBtn_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.PanelLogo.Controls.Add(this.HomeLabel);
            this.PanelLogo.Controls.Add(this.HomeBtn);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(251, 149);
            this.PanelLogo.TabIndex = 0;
            this.PanelLogo.UseWaitCursor = true;
            this.PanelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogo_Paint);
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.HomeLabel.Location = new System.Drawing.Point(12, 128);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(215, 18);
            this.HomeLabel.TabIndex = 1;
            this.HomeLabel.Text = "Simlador de mesa de anestesia";
            this.HomeLabel.UseWaitCursor = true;
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.HomeBtn.ForeColor = System.Drawing.Color.Thistle;
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            this.HomeBtn.IconColor = System.Drawing.Color.Thistle;
            this.HomeBtn.IconSize = 146;
            this.HomeBtn.Location = new System.Drawing.Point(32, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(174, 146);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.UseWaitCursor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.panelFormularios.Location = new System.Drawing.Point(251, 78);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(709, 952);
            this.panelFormularios.TabIndex = 2;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 1030);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(850, 898);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.panelContenedor.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton CMasterBtn;
        private FontAwesome.Sharp.IconButton CMaqBtn;
        private FontAwesome.Sharp.IconButton CPatBtn;
        private FontAwesome.Sharp.IconPictureBox HomeBtn;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton DisplayMenu;
        private FontAwesome.Sharp.IconButton RestoreSize;
        private FontAwesome.Sharp.IconButton Minimize;
        private FontAwesome.Sharp.IconButton Maximize;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.Panel panelFormularios;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    }
}

