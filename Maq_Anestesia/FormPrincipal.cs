
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Maq_Anestesia
{
    public partial class FormPrincipal : Form
    {
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        
        public FormPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            // Para que cambie en la activación del botón
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 88);
            panelMenu.Controls.Add(leftBorderBtn);
            panelMenu.Width = 251;
            HomeBtn.Size = new Size(174, 146);
            if (this.panelFormularios.Controls.Count > 0)
                this.panelFormularios.Controls.RemoveAt(0);
            FormMon frmMon = new FormMon(frmP, frmMaq);
            frmMon.TopLevel = false;
            frmMon.FormBorderStyle = FormBorderStyle.None;
            frmMon.Dock = DockStyle.Fill;
            this.panelFormularios.Controls.Add(frmMon);
            frmMon.Show();
            frmMon.BringToFront();



        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Estructuras

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 88, 155);
            public static Color color2 = Color.FromArgb(201, 230, 7);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(101, 192, 251);
            //public static Color color5 = Color.FromArgb(149, 127, 147);
            //public static Color color6 = Color.FromArgb(135, 111, 133);
        }
        #endregion

        #region Activar desactivar botones
        //Método de activación del botón
        private void AcivateButton(object senderBtn, Color color)
        {
            //El boton es diferente a nulo
            if (senderBtn != null)
            {   
                //casteamos al tipo de FontAwesome.Sharp
                currentBtn = (IconButton)senderBtn;
                //cambiamos color, alineamiento de texto e imagen, relacion entre ambos
                currentBtn.BackColor = Color.FromArgb(68, 40, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Borde izquierdo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono de hijo actual (para volver a Home)
                iconCurrentChildForm.IconColor = color;
            }

        }
        //Mètodo de reiniciar
        private void Reset()
        {   
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.ClinicMedical;
            iconCurrentChildForm.IconColor = Color.MediumOrchid;
            
        }
        private void ResetAll()
        {
            currentBtn = (IconButton)CPatBtn;
            DisableButton();
            currentBtn = (IconButton)CMaqBtn;
            DisableButton();
            currentBtn = (IconButton)CMasterBtn;
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.ClinicMedical;
            iconCurrentChildForm.IconColor = Color.MediumOrchid;

        }



        //Método para desactivación del botón
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 17, 30);
                currentBtn.ForeColor = Color.FromName("Menu");
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromName("Menu");
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        #endregion

        #region Cambiar tamaño de ventana

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }


        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }


        


        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        

        #region Drag window
        //Para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones de la barra de título
        private void panelTitleBar_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar la aplicación?", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }

        //Hay qe capturar la posiciòn y tamaño antes de maximizar para rstaurar
        int lx, ly; //Posiciòn
        int sw, sh; //tamaño


        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            //En estado maximizado, el boton maximizar es no visible y el restaurar si
            Maximize.Visible = false;
            RestoreSize.Visible = true;
            //tamaño de Maximo de la pantalla principal por defecto
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void DisplayMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 251)
            {
                panelMenu.Width = 80;
                panelFormularios.Width = 709+171;
                panelFormularios.Location = new Point(80, 78);
                CMaqBtn.Text = "";
                CPatBtn.Text = "";
                CMasterBtn.Text = "";
                HomeLabel.Visible = false;
                HomeBtn.Size = new Size(65, 74);
                HomeBtn.Location = new Point(3, 52);
                //DisplayMenu.Location = new Point(107,22); 251; 78
                //iconCurrentChildForm.Location = new Point();
            }
            else
            {
                panelMenu.Width = 251;
                panelFormularios.Width = 709;
                panelFormularios.Location = new Point(251, 78);
                CMaqBtn.Text = "Control de la máquina";
                CPatBtn.Text = "Control de paciente";
                CMasterBtn.Text = "Evaluación";
                HomeBtn.Location = new Point(32, 3);
                HomeBtn.Size = new Size(174, 146);
                HomeLabel.Visible = true;
                //DisplayMenu.Location = new Point(6, 16);
                //iconCurrentChildForm.Location = new Point(72, 15);
            }
        }

        private void RestoreSize_Click(object sender, EventArgs e)
        {
            Maximize.Visible = true;
            RestoreSize.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

        }
        #endregion

        #region Botones del Menu

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        //Incializo los otros form
        FormPat frmP = new FormPat(0);
        FormMaq frmMaq = new FormMaq();
        FormEval frmEv = new FormEval();
        
        private void CPatBtn_Click(object sender, EventArgs e)
        {
            AcivateButton(sender, RGBColors.color1);
            
            if (frmP.Visible==true)
            {
                frmP.Hide();
                Reset();
            }
            else
            {
                frmP.Show();
            }
            ////frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormulario(frm, 0);
            frmP.PatClosed += new FormPat.EventClose(Form_ClosePat);

        }

        private void Form_ClosePat(object sender)
        {
            currentBtn = (IconButton)CPatBtn;
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.ClinicMedical;
            iconCurrentChildForm.IconColor = Color.MediumOrchid;
        }
        private void Form_CloseEv(object sender)
        {
            currentBtn = (IconButton)CMasterBtn;
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.ClinicMedical;
            iconCurrentChildForm.IconColor = Color.MediumOrchid;
        }
        private void Form_CloseMaq(object sender)
        {
            currentBtn = (IconButton)CMaqBtn;
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.ClinicMedical;
            iconCurrentChildForm.IconColor = Color.MediumOrchid;
        }

        private void CMaqBtn_Click(object sender, EventArgs e)
        {
            AcivateButton(sender, RGBColors.color2);
            if (frmMaq.Visible == true)
            {
                frmMaq.Hide();
                Reset();
            }
            else
            {
                frmMaq.Show();
            }
            frmMaq.MaqClosed += new FormMaq.EventClose(Form_CloseMaq);

        }


        private void CMasterBtn_Click(object sender, EventArgs e)
        {
            AcivateButton(sender, RGBColors.color4);
            if (frmEv.Visible == true)
            {
                frmEv.Hide();
                Reset();
            }
            else
            {
                frmEv.Show();
            }
            frmEv.EvClosed += new FormEval.EventClose(Form_CloseEv);

        }





        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {
            if((frmP.Visible == true)|| (frmMaq.Visible == true)|| (frmEv.Visible == true))
            {
                string msg = "¿Desea cerrar los paneles de control abiertos?";

                if (MessageBox.Show(msg, "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmEv.Hide();
                    frmP.Hide();
                    frmMaq.Hide();
                    ResetAll();
                }

            }
          

        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {

        }


        #endregion


    }
}
