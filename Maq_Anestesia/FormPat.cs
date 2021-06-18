using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Maq_Anestesia
{
    public partial class FormPat : Form
    {
        public delegate void UpdatePatHandlers(object sender, PatUpdateEventArgs e);
        //y declaro que va a haber un evento de update (que despues pasa cuando mandas send)
        public event UpdatePatHandlers PatUpdated;
        public delegate void EventClose(object sender);
        //y declaro que va a haber un evento de update (que despues pasa cuando mandas send)
        public event EventClose PatClosed;
        public FormPat(int flag)
        {
            InitializeComponent();
            if (flag == 1)
            {

                sendPatBtn.Location = new Point(535, 181);


            }
        }
        #region Resize
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
            this.panelFormPat.Region = region;
            this.Invalidate();
        }





        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        #region Activar desactivar botones
        //Método de activación del botón
        //private void AcivateButton(object senderBtn, Color color)
        //{
        //    //El boton es diferente a nulo
        //    if (senderBtn != null)
        //    {
        //        //casteamos al tipo de FontAwesome.Sharp
        //        currentBtn = (IconButton)senderBtn;
        //        //cambiamos color, alineamiento de texto e imagen, relacion entre ambos
        //        currentBtn.BackColor = Color.FromArgb(68, 40, 68);
        //        currentBtn.ForeColor = color;
        //        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        //        currentBtn.IconColor = color;
        //        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        //        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        //        //Borde izquierdo
        //        leftBorderBtn.BackColor = color;
        //        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        //        leftBorderBtn.Visible = true;
        //        leftBorderBtn.BringToFront();
        //        //Icono de hijo actual (para volver a Home)
        //        iconCurrentChildForm.IconColor = color;
        //    }

        //}
        //Mètodo de reiniciar
        //private void Reset()
        //{
        //    DisableButton();
        //    leftBorderBtn.Visible = false;
        //    iconCurrentChildForm.IconChar = IconChar.ClinicMedical;
        //    iconCurrentChildForm.IconColor = Color.MediumOrchid;

        //}

        //Método para desactivación del botón
        //private void DisableButton()
        //{
        //    if (currentBtn != null)
        //    {
        //        currentBtn.BackColor = Color.FromArgb(30, 17, 30);
        //        currentBtn.ForeColor = Color.FromName("Menu");
        //        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        //        currentBtn.IconColor = Color.FromName("Menu");
        //        currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
        //        currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
        //    }
        //}

        #endregion

        #region Drag window

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitlePat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitlePat_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Botones de la barra de título


        //Hay qe capturar la posiciòn y tamaño antes de maximizar para rstaurar
        int lxp, lyp; //Posiciòn
        int swp, shp; //tamaño






        private void RestoreSizeP_Click(object sender, EventArgs e)
        {
            MaximizeP.Visible = true;
            RestoreSizeP.Visible = false;
            this.Size = new Size(swp, shp);
            this.Location = new Point(lxp, lyp);
        }

        private void MinimizeP_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeP_Click(object sender, EventArgs e)
        {
            lxp = this.Location.X;
            lyp = this.Location.Y;
            swp = this.Size.Width;
            shp = this.Size.Height;
            //En estado maximizado, el boton maximizar es no visible y el restaurar si
            MaximizeP.Visible = false;
            RestoreSizeP.Visible = true;
            //tamaño de Maximo de la pantalla principal por defecto
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPat_Shown(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, 0);
        }

        private void panelFormPat_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void predeterminados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (predeterminados.SelectedIndex == 0)//Persona sana
            {
                ElastPac.Text = "18";
                ResPac.Text = "0.2085";
                PatWe.Text = "70";
                AgeVal.Text = "30";
                frecC.Text = "80";
                PsisText.Text = "122";
                PdiastText.Text = "81";
                TempVal.Text = "36.7";
                etco2val.Text = "38";
            }
            else if (predeterminados.SelectedIndex == 1) //EPOC
            {
                ElastPac.Text = "14.2857";
                ResPac.Text = "0.3333";
                PatWe.Text = "70";
                AgeVal.Text = "81";
                frecC.Text = "65";
                PsisText.Text = "110";
                PdiastText.Text = "65";
                TempVal.Text = "36.8";
                etco2val.Text = "44";
            }
            else if (predeterminados.SelectedIndex == 2)//Hipotension
            {
                ElastPac.Text = "18";
                ResPac.Text = "0.2085";
                PatWe.Text = "70";
                AgeVal.Text = "30";
                frecC.Text = "63";
                PsisText.Text = "85";
                PdiastText.Text = "60";
                TempVal.Text = "37";
                etco2val.Text = "35";
            }
            else if (predeterminados.SelectedIndex == 3)//Hipertension
            {
                ElastPac.Text = "18";
                ResPac.Text = "0.2085";
                PatWe.Text = "70";
                AgeVal.Text = "60";
                frecC.Text = "115";
                PsisText.Text = "135";
                PdiastText.Text = "90";
                TempVal.Text = "36.8";
                etco2val.Text = "40";
            }
        }

        private void CloseBtnP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar los controles del paciente?", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                PatClosed(this);
                //Reset();
            }
        }
        #endregion

        #region send data
        private void sendPatBtn_Click(object sender, EventArgs e)
        {
            string E = ElastPac.Text;
            string R = ResPac.Text;
            string W = PatWe.Text;
            string Age = AgeVal.Text;
            string FrecCard = frecC.Text;
            string PS = PsisText.Text;
            string PD = PdiastText.Text;
            string Temp = TempVal.Text;
            string Et = etco2val.Text;
            //guardo las cosas
            PatUpdateEventArgs args = new PatUpdateEventArgs(R, E, W, Age, FrecCard, PD, PS, Temp, Et);
            if (PatUpdated != null)
            {
                PatUpdated(this, args);
            }
            else
            {
                string message = "No se puede actualizar las configuraciones de la máquina sin abrir primero el monitor multiparamétrico.";

                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }


        }
        #endregion

    }
    #region Evento Update
    public class PatUpdateEventArgs : System.EventArgs
    {
        //donde vas a guaradr tus strings
        private double R;
        private double E;
        private double W;
        private double A;
        private double FrecC;
        private double PAS;
        private double PAD;
        private double T;
        private double ET;

        //constructor de clase
        //una funcion que te construya la clase argumentos de update a la cual le pases los strings
        //estos strings lo va a guardar como un conjunto de datos que te los va a mandar todos juntos a Form1 con el nombre de "e"

        public PatUpdateEventArgs(string RR, string EE, string WW, string AA, string FrecC, string PADs, string PASs, string TT, string ET)
        {
            string Rtxt = RR;
            string Etxt = EE;
            string Wtxt = WW;
            string Atxt = AA;
            string FCtxt = FrecC;
            string PADtxt = PADs;
            string PAStxt = PASs;
            string Ttxt = TT;
            string ETtxt = ET;

            //tryparse ve si se puede pasara numeros y devuelve un boolean, si no es un numero entra al if 
            if (!Double.TryParse(Rtxt, out this.R) || !Double.TryParse(Etxt, out this.E) || !Double.TryParse(Wtxt, out this.W) || !Double.TryParse(Atxt, out this.A) || !Double.TryParse(FCtxt, out this.E) || !Double.TryParse(PADtxt, out this.PAD) || !Double.TryParse(PAStxt, out this.PAS) || !Double.TryParse(Ttxt, out this.T) || !Double.TryParse(ETtxt, out this.ET))
            {
                //si entre es porque es un texto, asi que voy a poner error y no voy a hacer nada con las variables
                string message = "Uno de los parámetros ingresados no es un número, es negativo o posee un caracter que no es un número. Vuelva a intentarlo.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string caption = "Error en parámetros ingresados";
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            else
            {   //si estoy aca es porque si era un numero, asi que lo convierto con Parse a un numero

                this.R = Double.Parse(Rtxt);
                this.E = Double.Parse(Etxt);
                this.W = Double.Parse(Wtxt);
                this.A = Double.Parse(Atxt);
                this.FrecC = Double.Parse(FCtxt);
                this.PAS = Double.Parse(PAStxt);
                this.PAD = Double.Parse(PADtxt);
                this.T = Double.Parse(Ttxt);
                this.ET = Double.Parse(ETtxt);

            }
        }
        // propiedades que pueden ver todos los "oyentes"
        //es decir cuando llames a "e" en Form 1
        //vas a poder llamar estas propiedades Amplitud y Frecuencia (con mayusc)
        //como e.Amplitud y e.Frecuencia
        //y al hacer esto te devuelve los parametros que guardaste como amplitud y frecuencia (en minusc)
        public double ETCO2
        {
            get
            {
                return ET;
            }
        }
        public double Resistencia
        {
            get
            {
                return R;
            }
        }

        public double Edad
        {
            get
            {
                return A;
            }
        }

        public double Elastancia
        {
            get
            {
                return E;
            }
        }

        public double Weight
        {
            get
            {
                return W;
            }
        }

        public double FrecCard
        {
            get
            {
                return FrecC;
            }
        }
        public double PresSis
        {
            get
            {
                return PAS;
            }
        }
        public double PresDias
        {
            get
            {
                return PAD;
            }
        }
        public double Temp
        {
            get
            {
                return T;
            }
        }
    }
    #endregion
}
