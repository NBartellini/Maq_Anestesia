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
    public partial class FormMaq : Form

    {
       
        //guardo las cosas
        //int ModoV; // 0 para VCV, 1 para PCV
        #region Parametros de FGF
        double LastLowO = 0;
        double LastHighO = 0;
        double LastLowN = 0;
        double LastHighN = 0;
        double LastLowFA = 0;
        double LastHighFA = 0;
        double LowO2 = 0;
        double LowNO2 = 0;
        double LowFA = 0;

        double HighO2 = 0;
        double HighFA = 0;
        double HighNO2 = 0;
        double FO2 = 0;
        double FNO2 = 0;
        double FA = 0;
        double FGF = 0;
        double FiNO2 = 0;
        double FiO2 = 0;

        #endregion
        #region Parametros del respirador
        double V;
        int F;
        double P;
        double tP;
        double frac;
        #endregion
        #region parametros de anestesia
        double dial = 0;
        #endregion
        #region Declaracion Evento Respi Update
        public delegate void UpdateRespMaqHandlers(object sender, RespMaqUpdateEventArgs e);
        //y declaro que va a haber un evento de update (que despues pasa cuando mandas send)
        public event UpdateRespMaqHandlers RespMaqUpdated;
        #endregion
        #region Declaracion Evento FGF Update
        public delegate void UpdateFGFMaqHandlers(object sender, FGFMaqUpdateEventArgs e);
        //y declaro que va a haber un evento de update (que despues pasa cuando mandas send)
        public event UpdateFGFMaqHandlers FGFMaqUpdated;
        #endregion
        public delegate void EventClose(object sender);
        //y declaro que va a haber un evento de update (que despues pasa cuando mandas send)
        public event EventClose MaqClosed;
        public FormMaq()
        {
            InitializeComponent();
            F = (int)FResp.Value;
            P = (double)Pres_P.Value;
            V = (double)Vcte.Value;
            tP = 0;
            frac = 1 / 3;
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedItem = 0;
            anes_select.SelectedIndex = 0;
            anes_select.SelectedItem = 0;
        }
        #region mover panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitleMaq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleMaq_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

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
            this.panelFormMaq.Region = region;
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



        private void FormMaq_Load(object sender, EventArgs e)
        {

        }
        #region Botones de la barra de título


        //Hay qe capturar la posiciòn y tamaño antes de maximizar para rstaurar
        int lxq, lyq; //Posiciòn
        int swq, shq; //tamaño
        private void CloseBtnMaq_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar los controles del paciente?", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                MaqClosed(this);
                //Reset();
            }
        }



        private void MinimizeMaq_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeMaq_Click(object sender, EventArgs e)
        {
            lxq = this.Location.X;
            lyq = this.Location.Y;
            swq = this.Size.Width;
            shq = this.Size.Height;
            //En estado maximizado, el boton maximizar es no visible y el restaurar si
            MaximizeMaq.Visible = false;
            RestoreSizeMaq.Visible = true;
            //tamaño de Maximo de la pantalla principal por defecto
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void RestoreSizeMaq_Click(object sender, EventArgs e)
        {
            MaximizeMaq.Visible = true;
            RestoreSizeMaq.Visible = false;
            this.Size = new Size(swq, shq);
            this.Location = new Point(lxq, lyq);
        }
        #endregion

        private void panelFormMaq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Respirador_Click(object sender, EventArgs e)
        {

        }

        private void SendResp_Click(object sender, EventArgs e)
        {
            RespMaqUpdateEventArgs argsR = new RespMaqUpdateEventArgs(0, V, F, P, tP, frac);
            if (RespMaqUpdated != null)
            {
                RespMaqUpdated(this, argsR);
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

        private void RelIE_Click(object sender, EventArgs e)
        {

        }

        private void FResp_ValueChanged(object sender, EventArgs e)
        {
            F = (int)FResp.Value;
        }

        private void Vcte_ValueChanged(object sender, EventArgs e)
        {
            V = (double)Vcte.Value;
        }

        private void PEEP_ValueChanged(object sender, EventArgs e)
        {
            P = (double)Pres_P.Value;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0) //relación 1:3
            {
                frac = 1.0 / 4.0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                frac = 1.0 / 3.0;
            }
            else
            {
                string message = "Ponga una relacion inspiracion-espiracion";
                string caption = "Parametros no ingresados";
                MessageBoxButtons buttons = MessageBoxButtons.OK;


                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }

        }

        private void TPausa_CheckedChanged(object sender, EventArgs e)
        {
            if (TPausa.Checked == true)
            {
                tP = 0.5;
            }
            else
            {
                tP = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        #region TODO LO DE FGF
        private void OxPerc_Scroll(object sender, EventArgs e)
        {
            if ((FAPerc.Value == 0 && FAPercLow.Value == 0) && LastHighO == 1 && OxPerc.Value == 0&&OxPercLow.Value == 0)
            {
                OxPerc.Value = 1;
                labelHighO2.Text = (OxPerc.Value).ToString();
                HighO2 = OxPerc.Value;
                LastHighO = 1;
                string message = "Para apagar el flujo de oxígeno debe encender el aire médico.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                labelHighO2.Text = (OxPerc.Value).ToString();
                HighO2 = OxPerc.Value;
                if (LastHighO > HighO2 && NO2Perc.Value >= 1)
                {
                    NO2Perc.Value = NO2Perc.Value - 1;
                    HighNO2 = NO2Perc.Value;
                    labelHighNO2.Text = (NO2Perc.Value).ToString();
                }


            }



        }

        private void sendGFSis_Click(object sender, EventArgs e)
        {
            FA = HighFA + LowFA;
            FO2 = HighO2 + LowO2;
            FNO2 = HighNO2 + LowNO2;
            FGF = FA + FNO2 + FO2;
            FiO2 = (FA * 0.21 + FO2) / FGF;
            FiNO2 = FNO2 / FGF;
            if (FiO2 >= 0.21 || FGF != 0)
            {
                FGFMaqUpdateEventArgs argsFGF = new FGFMaqUpdateEventArgs(FiO2, FiNO2, FGF, dial);
                if (FGFMaqUpdated != null)
                {
                    FGFMaqUpdated(this, argsFGF);
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
            else
            {
                string message = "El FGF = 0 o FiO2 < 21%. Por favor, intentelo de nuevo.";

                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }


        }

        private void FAPerc_Scroll(object sender, EventArgs e)
        {
            if ((OxPerc.Value == 0 && OxPercLow.Value == 0) && LastHighFA == 1 && FAPerc.Value == 0 && FAPercLow.Value == 0)
            {
                FAPerc.Value = 1;
                labelHighFA.Text = (FAPerc.Value).ToString();
                HighFA = FAPerc.Value;
                LastHighFA = 0.1;
                string message = "Para apagar el flujo de aire médico debe encender el flujo de oxígeno.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                labelHighFA.Text = FAPerc.Value.ToString();
                HighFA = FAPerc.Value;
            }


        }

        private void NO2Perc_Scroll(object sender, EventArgs e)
        {
            labelHighNO2.Text = NO2Perc.Value.ToString();
            HighNO2 = NO2Perc.Value;
            if (LastHighN < HighNO2 && OxPerc.Value <= 14 && (OxPerc.Value - NO2Perc.Value <= 0 || OxPerc.Value == 0))
            {
                OxPerc.Value = OxPerc.Value + 1;
                HighO2 = OxPerc.Value;
                labelHighO2.Text = (OxPerc.Value).ToString();
            }
        }

        private void OxPercLow_Scroll(object sender, EventArgs e)
        {

            if ((FAPerc.Value == 0 && FAPercLow.Value == 0) && LastLowO == 0.1 && OxPerc.Value == 0&& OxPercLow.Value == 0)
            {
                OxPercLow.Value = 1;
                labelLowO2.Text = (OxPercLow.Value / 10.0).ToString();
                LowO2 = OxPercLow.Value / 10.0;
                LastLowO = 0.1;
                string message = "Para apagar el flujo de oxígeno debe encender el aire médico.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                labelLowO2.Text = (OxPercLow.Value / 10.0).ToString();
                LowO2 = OxPercLow.Value / 10.0;
                if (LastLowO > LowO2 && NO2PercLow.Value >= 1)
                {
                    NO2PercLow.Value = NO2PercLow.Value - 1;
                    LowNO2 = NO2PercLow.Value / 10.0;
                    labelLowNO2.Text = (NO2PercLow.Value / 10.0).ToString();
                }
            }


        }


        private void FAPercLow_Scroll(object sender, EventArgs e)
        {
            if ((OxPerc.Value == 0 && OxPercLow.Value == 0) && LastLowFA == 0.1 && FAPercLow.Value == 0 && FAPerc.Value == 0)
            {
                FAPercLow.Value = 1;
                labelLowFA.Text = (FAPercLow.Value / 10.0).ToString();
                LowFA = FAPercLow.Value / 10.0;
                LastLowFA = 0.1;
                string message = "Para apagar el flujo de aire médico debe encender el flujo de oxígeno.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                labelLowFA.Text = (FAPercLow.Value / 10.0).ToString();
                LowFA = FAPercLow.Value / 10.0;
            }

        }

        private void NO2PercLow_Scroll(object sender, EventArgs e)
        {
            labelLowNO2.Text = (NO2PercLow.Value / 10.0).ToString();
            LowNO2 = NO2PercLow.Value / 10.0;
            if (LastLowN < LowNO2 && OxPercLow.Value <= 9 && (OxPercLow.Value - NO2PercLow.Value <= 0 || OxPercLow.Value == 0))
            {
                OxPercLow.Value = OxPercLow.Value + 1;
                LowO2 = OxPercLow.Value / 10.0;
                labelLowO2.Text = (OxPercLow.Value / 10.0).ToString();
            }
        }
        #endregion
        private void AlarmasSet_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void OxPercLow_ValueChanged(object sender, EventArgs e)
        {
            LastLowO = OxPercLow.Value / 10.0;
        }

        private void NO2PercLow_ValueChanged(object sender, EventArgs e)
        {
            LastLowN = NO2PercLow.Value / 10.0;

        }

        private void OxPerc_ValueChanged(object sender, EventArgs e)
        {
            LastHighO = OxPerc.Value;
        }

        private void NO2Perc_ValueChanged(object sender, EventArgs e)
        {
            LastHighN = NO2Perc.Value;
        }

        private void FAPercLow_ValueChanged(object sender, EventArgs e)
        {
            LastLowFA = FAPercLow.Value / 10.0;
        }

        private void FAPerc_ValueChanged(object sender, EventArgs e)
        {
            LastHighFA = FAPerc.Value;
        }

        private void anestIn_Scroll(object sender, EventArgs e)
        {
            if ((FAPerc.Value == 0 && FAPercLow.Value == 0) && (OxPerc.Value == 0 && OxPercLow.Value == 0))
            {
                labelPercAnest.Text = 0.ToString();
                dial = 0.0;
                dial_anes.Value = 0;
                string message = "Para anestesiar el paciente, primero ingrese un flujo de aire médico o de oxígeno.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                labelPercAnest.Text = (dial_anes.Value / 2.0).ToString();
                dial = dial_anes.Value / 2.0;
               
            }
        }

        private void anes_select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Anestesia_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void FormMaq_Shown(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Height + 2);
        }


    }
    #region Evento Update
    public class FGFMaqUpdateEventArgs : System.EventArgs
    {
        //donde vas a guaradr tus strings
        double FiO2;
        double FGF;
        double FiNO2;
        double dial;
        //constructor de clase
        //una funcion que te construya la clase argumentos de update a la cual le pases los strings
        //estos strings lo va a guardar como un conjunto de datos que te los va a mandar todos juntos a Form1 con el nombre de "e"

        public FGFMaqUpdateEventArgs(double fiO2, double fiNO2, double fgf, double d)
        {
            this.FGF = fgf;
            this.FiO2 = fiO2;
            this.FiNO2 = fiNO2;
            this.dial = d;
            
            //if (FiO2 < 0.21)
            //{

            //}
            //else
            //{

            //}
        }

        public double Dial
        {
            get
            {
                return dial;
            }
        }
        public double F_G_F
        {
            get
            {
                return FGF;
            }
        }
        public double Frac_O2
        {
            get
            {
                return FiO2;
            }
        }
        public double Frac_NO2
        {
            get
            {
                return FiNO2;
            }
        }
    }
    public class RespMaqUpdateEventArgs : System.EventArgs
    {
        //donde vas a guaradr tus strings
        int ModoVentilatorio; // 0 para VCV, 1 para PCV
        double Vcte;
        int FrecRespi;
        double peep;
        double tPau;
        double tInsp;
        //constructor de clase
        //una funcion que te construya la clase argumentos de update a la cual le pases los strings
        //estos strings lo va a guardar como un conjunto de datos que te los va a mandar todos juntos a Form1 con el nombre de "e"

        public RespMaqUpdateEventArgs(int MVent, double VV, int FF, double PP, double tPP, double frac)
        {
            this.ModoVentilatorio = 0;
            this.Vcte = VV;
            this.FrecRespi = FF;
            this.peep = PP;
            this.tPau = tPP;
            this.tInsp = (((double)(60 / FrecRespi)) - tPau) * frac;

        }
        // propiedades que pueden ver todos los "oyentes"
        //es decir cuando llames a "e" en Form 1
        //vas a poder llamar estas propiedades Amplitud y Frecuencia (con mayusc)
        //como e.Amplitud y e.Frecuencia
        //y al hacer esto te devuelve los parametros que guardaste como amplitud y frecuencia (en minusc)
        public int Modo_Vent
        {
            get
            {
                return ModoVentilatorio;
            }
        }
        public int Frec_Respi
        {
            get
            {
                return FrecRespi;
            }
        }

        public double Vol_Corriente
        {
            get
            {
                return Vcte;
            }
        }
        public double PEEP
        {
            get
            {
                return peep;
            }
        }
        public double T_Insp
        {
            get
            {
                return tInsp;
            }
        }
        public double T_Pausa
        {
            get
            {
                return tPau;
            }
        }
    }
    #endregion
}
