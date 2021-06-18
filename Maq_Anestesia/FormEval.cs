using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Maq_Anestesia
{
    public partial class FormEval : Form
    {
        public delegate void EventClose(object sender);
        //y declaro que va a haber un evento de update (que despues pasa cuando mandas send)
        public event EventClose EvClosed;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public FormEval()
        {
            InitializeComponent();
            // Para que cambie en la activación del botón
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 61);
            panelMenu.Controls.Add(leftBorderBtn);

        }

        private void FormEval_Load(object sender, EventArgs e)
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
            }

        }
        //Mètodo de reiniciar
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

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
        #region Arrastrar formulario
        //Para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void TitleEval_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleEval_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region botones de barra de título
        //Hay qe capturar la posiciòn y tamaño antes de maximizar para rstaurar
        int lxe, lye; //Posiciòn
        int swe, she; //tamaño
        private void panelFormEv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaximizeEv_Click(object sender, EventArgs e)
        {
            lxe = this.Location.X;
            lye = this.Location.Y;
            swe = this.Size.Width;
            she = this.Size.Height;
            //En estado maximizado, el boton maximizar es no visible y el restaurar si
            MaximizeEv.Visible = false;
            RestoreSizeEv.Visible = true;
            //tamaño de Maximo de la pantalla principal por defecto
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void RestoreSizeEv_Click(object sender, EventArgs e)
        {
            MaximizeEv.Visible = true;
            RestoreSizeEv.Visible = false;
            this.Size = new Size(swe, she);
            this.Location = new Point(lxe, lye);

        }

        private void FormEval_Shown(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, 2 * (Height + 2));
        }



        private void CloseBtnEv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar los controles del paciente?", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                EvClosed(this);
                //Reset();
            }

        }



        private void MinimizeEv_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

        #region Botones Menu
        private void EvPatBtn_Click(object sender, EventArgs e)
        {


            AcivateButton(sender, RGBColors.color1);
            //creo el form
            if (!String.Equals(this.panelformulario.Tag, "frmEvPat"))
            {
                if (this.panelformulario.Controls.Count > 0)
                    this.panelformulario.Controls.RemoveAt(0);
                FormPat frmEvPat = new FormPat(1);
                frmEvPat.Size = new Size(960, 402);
                frmEvPat.TopLevel = false;
                frmEvPat.FormBorderStyle = FormBorderStyle.None;
                frmEvPat.Dock = DockStyle.Fill;

                this.panelformulario.Controls.Add(frmEvPat);
                this.panelformulario.Tag = "frmEvPat";
                frmEvPat.Show();
                frmEvPat.BringToFront();

            }
            else
            {
                this.panelformulario.Controls.RemoveAt(0);
                this.panelformulario.Tag = "";
                DisableButton();
            }

        }

        private void panelformulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaqErrorBtn_Click(object sender, EventArgs e)
        {
            if (!String.Equals(this.panelformulario.Tag, "frmMaqError"))
            {
                if (this.panelformulario.Controls.Count > 0)
                    this.panelformulario.Controls.RemoveAt(0);
                MaqError frmMaqError = new MaqError();
                frmMaqError.Size = new Size(960, 402);
                frmMaqError.TopLevel = false;
                frmMaqError.FormBorderStyle = FormBorderStyle.None;
                frmMaqError.Dock = DockStyle.Fill;

                this.panelformulario.Controls.Add(frmMaqError);
                this.panelformulario.Tag = "frmMaqError";
                frmMaqError.Show();
                frmMaqError.BringToFront();

            }
            else
            {
                this.panelformulario.Controls.RemoveAt(0);
                this.panelformulario.Tag = "";
                DisableButton();
            }
        }

        private void TestParBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
