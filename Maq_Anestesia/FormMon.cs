using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace Maq_Anestesia
{
    public partial class FormMon : Form
    {
        FormPat fpat;
        FormMaq fMaq;
        double x;
        double t_hipoxic = -1;
        Random rnd = new Random();
        double Vcirc = 0;//L
        double t_change;
        double t_anes = 0;
        #region ECG
        double ECG;
        double Kb = 0.25;
        double Kp = 0.11;
        double Kpq = 0.1;
        double Kq = 0.01;
        double Kr = 0.035;
        double Ks = 0.025;
        double Kst = 0.15;
        double Kt = 0.10;
        int nn = 0;
        double Ap = 0.25;
        double Aq = 0.3;
        double Ar = 3.5;
        double As = 0.3;
        double At = 0.3;
        double TCard;
        double tECG;
        double x2;
        #endregion
        #region anestesia
        bool flag_anes = false;
        double Vol_blood = 0;
        double Vol_tej = 0;
        double Vol_tot_a = 0;
        double Tau = 0;
        double G_card = 0;
        #endregion
        #region Valores de FGF
        double FGF;
        double FiO2=0.21;
        double LastFiO2 = 0.21;
        double FiNO2;
        bool flag_hipoxic = false;
        double dial;
        #endregion
        #region Valores del Paciente seteado por el usuario
        double R;
        double E;
        double W;
        double A;
        double FCard;
        double PAS;
        double PAD;
        double Temp;
        double ET;
        double CRF;
        double delay = 0;
        #endregion
        #region Valores de máquina seteados por el usuario
        int ModoVentilatorio = 0; // 0 para VCV, 1 para PCV
        double Vcte;
        int FrecRespi;
        double Fcte; //l/min
        double peep;
        double tPau;
        double tInsp;
        double ttot; //tiempo total por inspiración
        #endregion
        #region Valores a modificar para generar gráficas de respirador
        bool RespiEmpty = true;
        bool PatientEmpty = true;
        double Vol;//l
        double F;//l/min
        double Paw;//cmH2O
        int i = 0;

        #endregion
        #region Valores de Oximetria modificables
        double SatO2;
        double PiO2;
        double PAO2;
        double DAaO2;
        double PaO2;
        double PaCO2 = 40; //mmHg
        bool FGFEmpty = true;
        #endregion
        public FormMon(FormPat f1, FormMaq f2)
        {
            InitializeComponent();
            
            //Desde acá comentar
            fpat = f1;
            fMaq = f2;
            fpat.PatUpdated += new FormPat.UpdatePatHandlers(FormPat_SendClicked);
            fMaq.RespMaqUpdated += new FormMaq.UpdateRespMaqHandlers(FormMaq_SendClicked);
            fMaq.FGFMaqUpdated += new FormMaq.UpdateFGFMaqHandlers(FGF_SendClicked);
        }
        #region Actualización de datos
        private void FGF_SendClicked(object sender, FGFMaqUpdateEventArgs e)
        {
            LastFiO2 = FiO2;
            dial = e.Dial;
            FGF = e.F_G_F;
            FiO2 = (e.Frac_O2);
            FiNO2 = e.Frac_NO2;
            PiO2 = 760-(FiO2) * 47;
            PAO2 = PiO2 - PaCO2 / 0.8;
            if (PAO2 > 139)
            {
                PAO2 = 139 + rnd.Next(0, 3) * 1-1* rnd.Next(0, 3);
            }
            //System.Diagnostics.Debug.WriteLine(dial.ToString());
            if (dial > 0)
            {
                flag_anes = true;
                
                
                System.Diagnostics.Debug.WriteLine(dial.ToString());
            }
            FGFEmpty = false;
            t_change = 0;
            if (FiNO2 == 0.5)
            {
                flag_hipoxic = true;


            }
            else
            {
                flag_hipoxic = false;
                t_hipoxic = 0;
            }
            
        }
        private void FormMaq_SendClicked(object sender, RespMaqUpdateEventArgs e)
        {
            ModoVentilatorio = e.Modo_Vent; // 0 para VCV, 1 para PCV
            Vcte = e.Vol_Corriente;
            FrecRespi = e.Frec_Respi;
            peep = e.PEEP;
            tPau = e.T_Pausa;//s
            tInsp = e.T_Insp;//s
            ttot = (60 / FrecRespi); //tiempo total por respiración en s
            Fcte = 60 * Vcte / tInsp; ; //l/min
            RespiEmpty = false;

        }
        private void FormPat_SendClicked(object sender, PatUpdateEventArgs e)
        {
            R = e.Resistencia;
            E = e.Elastancia;
            W = e.Weight;
            A = e.Edad;
            Temp = e.Temp;
            FCard = e.FrecCard;
            PAD = e.PresDias;
            PAS = e.PresSis;
            ET = e.ETCO2;
            this.DAaO2 = 2.5 + 0.21 * A;
            PatientEmpty = false;
            CRF = W * 3 / 70.0;//L
            Vol_blood = W * 3 / 70.0;
            Vol_tej = W / 10.0;
            G_card = FCard * 0.06;
            TCard = 60 / FCard; //segundos por latido

        }
        #endregion

        #region Arrastrar minimizar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitleMon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleMon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ECGGraph_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Tabs_DrawItem(object sender, DrawItemEventArgs e)
        {

            //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(135, 111, 133)), e.Bounds);
            //    break; 
            //case 1: 
            //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(149, 127, 147)), e.Bounds); 
            Graphics g = e.Graphics;
            TabPage tp = Tabs.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            // Este sera el rectangulo que se dibujara sobre el titutlo del tab 
            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 3, e.Bounds.Width, e.Bounds.Height + 3);

            // Este sera el color por defecto del tab no seleccionado 
            SolidBrush sb = new SolidBrush(Color.FromArgb(135, 111, 133));

            // color del tab que se selecciona
            if (Tabs.SelectedIndex == e.Index)
                sb.Color = Color.FromArgb(253, 138, 114);//coral

            // aplica el color sobre el tabpage actual 
            g.FillRectangle(sb, headerRect);

            //escribe el texto que tenia el tab 
            g.DrawString(tp.Text, Tabs.Font, new SolidBrush(Color.White), headerRect, sf);

        }
        #endregion
        private void chart2_Click(object sender, EventArgs e)
        {

        }



        //#endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            double aux;
            LabelFrecVal.Text = FrecRespi.ToString();
            LabelVentMode.Text = "VCV";
            LabelPEEPVal.Text = peep.ToString();
            LabelPIPVal.Text = Math.Round((R * Fcte + E * Vcte + peep), 2).ToString();
            LabelPplatVal.Text = Math.Round((E * Vcte + peep),2).ToString();
            LabelVtVal.Text = Vcte.ToString();
            LabelVMVal.Text = (FrecRespi * Vcte).ToString();
            FrecCardVal.Text = Math.Round(FCard, 0).ToString();
            Psistlabel.Text = Math.Round(PAS, 0).ToString();
            Pdiastlabel.Text = Math.Round(PAD, 0).ToString();
            Tlabel.Text = Math.Round(Temp, 2).ToString();
            FGFVal.Text = Math.Round(FGF, 2).ToString();
            FiO2Val.Text = Math.Round(FiO2 * 100, 1).ToString();


            etcolabel.Text = Math.Round(ET, 2).ToString();
            #region Chart Areas
            //defino limites en y y en x
            SetChartAreas(chartPres, 0, Math.Round(4 * ttot, 2), 0.00, Math.Round((R * Fcte + E * Vcte + peep), 1), 5.0);
            //defino limites en y y en x
            SetChartAreas(chartVol, 0, Math.Round(4 * ttot, 2), 0.00, Math.Round(Vcte + 0.1, 3), 0.1);
            //defino limites en y y en x
            SetChartAreas(chartFlow, 0, Math.Round(4 * ttot, 2), Math.Round(-Vcte * E / R - 1, 0), Math.Round(Fcte + 1, 0), Math.Round((Math.Round(-Vcte * E / R - 1, 0) - Math.Round(Fcte + 1, 0)) / 5.0, 0));
            SetChartAreas(ECGChart,0, Math.Round(TCard, 2),-2,4,2);
            #endregion
        
            #region Ecuaciones de respirador
            if (ModoVentilatorio == 0)
            {
                VCVMode();
            }
            //si el tiempo esta dentro del rango [0, t inspiratorio] en este caso cada vez que el modulo de menor a 0.8 segundos
            if (flag_hipoxic == true)//si FiNo2=FiO2=50%
            {
                
                aux = - (12 / 90.0) * (((t_hipoxic) / 60.0)-delay);
                if (aux < 0)
                {
                    FiO2 = 0.5 + aux;
                    FiO2Val.Text = Math.Round(FiO2 * 100, 1).ToString();
                    System.Diagnostics.Debug.WriteLine(t_hipoxic.ToString());
                    LastFiO2 = FiO2;
                    
                }
                    

                
                t_hipoxic += 0.01;
                
            }

            #endregion
            #region Oximetria y anestesia
            
            if (FGFEmpty == false)
                SpO2();
            #endregion

            ECG_plot();



        }

        private void ECG_plot()
        {
            //TCard
            //tECG x2
            #region cuando llego al final de la respiración
            if ((TCard - x2) < 0.01)//para que sea periódico y que la ventana no se mueva
            {

                x2 = 0;
                nn = 0;

            }
            #endregion
            if (x2 <= Kb*TCard) //antes de onda P
            {
                if (x2 == 0)
                {
                    tECG = 0;
                }
                //controlado por volumen
                //el flujo es cte, el volumen es la integral de una cte (aka una lineal)

                ECG = 0;

            }
            else if (x2 <= (Kb + Kp)* TCard)// onda P
            {
                if (x2 == (Kb + 0.01)* TCard)
                {
                    tECG = 0;
                }

                ECG = -Ap / 2 * Math.Cos((2 * Math.PI * tECG + 15) / Kp) + Ap / 2;
                //ECG = 1;
            }
            else if (x2 <= (Kb + Kp + Kpq)* TCard)// entre onda P y Q
            {
                if (x2 == (Kb + Kp + 0.01)* TCard)
                {
                    tECG = 0;
                }

                ECG = 0;
            }
            else if (x2 <= (Kb + Kp + Kpq + Kq)* TCard)// onda Q
            {
                if (x2 == (Kb + Kp + Kpq + 0.01)* TCard)
                {
                    tECG = 0;
                }

                ECG = 1;
                //ECG = Aq * (time - 0.1 * Kq + 0.1)*(19.78*Math.PI/Kq)*Math.Exp(-2*Math.Pow(6*Math.PI/Kq*(time - 0.1*Kq+0.1), 2)) ;
                //ECG = -1;
                //ECG = -Aq * Math.Cos((Math.PI * time) / (0.5 * Kq)) - Aq;
                ECG = Aq * Math.Cos((2 * Math.PI * tECG) / (0.5 * Kq) + Math.PI) - Aq;
            }
            else if (x2 <= (Kb + Kp + Kpq + Kq + Kr)* TCard)// onda R
            {
                if (x2 == (Kb + Kp + Kpq + Kq + 0.01)* TCard)
                {
                    tECG = 0;
                }

                ECG = Ar * Math.Sin(Math.PI * tECG / Kr + Math.PI / 2);

                //ECG = 3;
            }
            else if (x2 <= (Kb + Kp + Kpq + Kq + Kr + Ks)* TCard)// onda S
            {
                if (x2 == (Kb + Kp + Kpq + Kq + Kr)* TCard)
                {
                    tECG = 0;
                }


                //ECG = -As*0.1* time * 19.78*Math.PI/Ks*Math.Exp(-2*Math.Pow(6*Math.PI/Ks*0.1* time, 2));
                ECG = -1.2 * Math.Cos((Math.PI * tECG) / (Ks) + Math.PI) - As;

            }
            else if (x2 <= (Kb + Kp + Kpq + Kq + Kr + Ks + Kst)* TCard)// entre onda S y T
            {
                if (x2 == (Kb + Kp + Kpq + Kq + Kr + Ks + 0.01)* TCard)
                {
                    tECG = 0;
                }

                ECG = 0;
            }
            else if (x2 <= (Kb + Kp + Kpq + Kq + Kr + Ks + Kst + Kt)* TCard)// onda T
            {
                if (x2 == (Kb + Kp + Kpq + Kq + Kr + Ks + Kst + 0.01)*TCard)
                {
                    tECG = 0;
                }

                ECG = -At * Math.Cos((Math.PI * tECG) / (0.5 * Kt) + Math.PI / 2) + At;
                //ECG = 1;
            }
            else if (x2 > (Kb + Kp + Kpq + Kq + Kr + Ks + Kst + Kt)* TCard && x2 <= TCard)
            {
                if (x2 == (Kb + Kp + Kpq + Kq + Kr + Ks + Kst + Kt + 0.01)*TCard)
                {
                    tECG = 0;
                }


                ECG = 0;
            }
            #region plot
            //vas añadiendo punto por punto en el grafico
            if (nn < TCard / 0.01 - 1)
            {
                if (nn < ECGChart.Series[0].Points.Count)
                {
                    #region pintar puntos posteriores blancos
                    if (nn < TCard / 0.01 - 6)
                    {
                        ECGChart.Series[0].Points[nn + 1].Color = Color.White;
                        ECGChart.Series[0].Points[nn + 2].Color = Color.White;
                        ECGChart.Series[0].Points[nn+ 3].Color = Color.White;
                        ECGChart.Series[0].Points[nn + 4].Color = Color.White;
                        ECGChart.Series[0].Points[nn + 5].Color = Color.White;

                    }
                    #endregion
                    ECGChart.Series[0].Points.RemoveAt(nn);

                    //meter punto blancoque se vaya moviendo en el punto siguiente

                }
                ECGChart.Series[0].Points.InsertXY(nn, x2, ECG);

                nn += 1;
                x2 += 0.01;
                tECG += 0.01;

            }
            else
            {
                i = 0;
            }

            #endregion
            //voy sumandole el paso entre puntos
        }
        private void VCVMode()
        {
            #region cuando llego al final de la respiración
            if ((4 * ttot - x) < 0.01 & x > (tInsp + tPau))//para que sea periódico y que la ventana no se mueva
            {

                x = 0;
                i = 0;

            }
            #endregion
            for (int j = 0; j < 4; j++)
            {
                if (ttot * j < x & x <= tInsp + ttot * j)
                {
                    //controlado por volumen
                    //el flujo es cte, el volumen es la integral de una cte (aka una lineal)
                    F = Fcte;
                    Vol = Fcte * (x - ttot * j) / 60;//como el flujo es l/min y x es en segundos, x a minutos
                    Paw = E * Vol + R * F + peep;//ecuacion conocida de Paw
                }
                else if (tInsp + ttot * j < x & x <= (tInsp + tPau) + ttot * j)//en la pausa respiratoria (desde el incio pasa la inspiracion y después los segundos
                                                                               //de pausa respiratoria: el F se vuelve 0, el volumen se mantiene
                {
                    F = 0;
                    Vol = Vcte;
                    Paw = E * Vol + R * F + peep;
                }
                else if (x > (tInsp + tPau) + ttot * j && x <= ttot * (j + 1))
                //el resto es la espiracion - no se para que le puse la condicion podria ir el else 
                //en la espiracion pasa a ser controlado sobre volumen so
                //si Paw tiene que ser =PEEP (porque a esa presion hay que llegar
                //entonces EV=-RF (para que se anulen)
                //=> EV=-RdV/dt ---> resuelvo--->y da la ecuación de abajo de Volumen
                {
                    Vol = Vcte * Math.Exp(-(E / R) * ((x - ttot * j - (tInsp + tPau)) / 60));
                    F = Vol * (-E / R);
                    Paw = peep + R * F + E * Vol;
                }
            }
            #region plot
            //vas añadiendo punto por punto en el grafico
            if (i < 400 * ttot - 1)
            {
                if (i < chartPres.Series[0].Points.Count)
                {
                    #region pintar puntos posteriores blancos
                    if (i < 400 * ttot - 6)
                    {
                        PaintNextWhite(chartPres, 5);
                        PaintNextWhite(chartFlow, 5);
                        PaintNextWhite(chartVol, 5);
                    }
                    #endregion
                    chartPres.Series[0].Points.RemoveAt(i);
                    chartFlow.Series[0].Points.RemoveAt(i);
                    chartVol.Series[0].Points.RemoveAt(i);
                    //meter punto blancoque se vaya moviendo en el punto siguiente

                }
                chartPres.Series[0].Points.InsertXY(i, x, Paw);
                chartFlow.Series[0].Points.InsertXY(i, x, F);
                chartVol.Series[0].Points.InsertXY(i, x, Vol);
                //value.Text = Paw.ToString();
                i += 1;
                x += 0.01;
            }
            else
            {
                i = 0;
            }
            #endregion

            
        }
        private double[] Sevofl()
        {
            double coef_part = 0.6;
            double[] dev = new double[2];
            double res=0;
            double resf=0;
            double CAM = 2;
            double CAM_frac = (dial / 1.25)/CAM; //(lock que llega al alveolo)/CAM
            double Vol_capt = CAM_frac * coef_part * G_card*10 / Math.Sqrt(t_anes/60.0);//ml/min
            //no deberia ser instantaneo
            double Fe_an = (dial / 1.25) - Vol_capt / (FrecRespi * Vcte*1000);
            FeAnLab.Text = Math.Round(Fe_an*100, 1).ToString();
            
            double Ptot = PAO2 / FiO2;
            double Ppan = (dial / 125) * Ptot;
            if (Ppan > 0)
            {
                //a partir del gráfico
                if (t_anes >= 0 && t_anes < 50)
                {
                    resf = -0.001;
                    Ppan = 0.034* t_anes + Ppan;
                    if ((Ppan >= 0 && Ppan < 1.4)&&t_anes<10)
                    {
                        if (PAS < 140)
                        {
                            res = (2.5/900);
                        }
                        else
                        {
                            res = 0;
                        }
                        
                    }
                    else if ((Ppan >= 1.4 && Ppan < 2.3) && t_anes < 20)
                    {
                        res = 0;
                    }
                    else if ((Ppan >= 2.3 && Ppan < 2.6) && t_anes < 50)
                    {
                        res = -(8.75 / 400);
                    }
                    else
                    {
                        res = 0;
                    }

                }
                else if(t_anes < 80)
                {
                    Ppan = 1.5;
                    res = -(10.0 / 1100.0);
                    resf = -0.001;
                }
                else
                {
                    resf=0.001;
                    if (PAS < 80)
                    {
                        res = 0.001;
                    }
                }

            }
            else
            {
                res = 0.0;
            }
            
            t_anes += 0.01;
            dev[0] = res;
            dev[1] = resf;
            return dev;

        }
        private void SpO2()
        {
            double SatO2;
            double[] aux=Sevofl();
            PaO2 = PAO2 - DAaO2;
            PAS = PAS + aux[0];
            FCard = FCard + aux[1];
            FrecCardVal.Text = Math.Round(FCard, 0).ToString(); 
            //System.Diagnostics.Debug.WriteLine(Ppan.ToString(), (PAS - res).ToString());
            PaO2Val.Text = Math.Round(PaO2, 2).ToString();
            Psistlabel.Text = Math.Round(PAS, 0).ToString();
            if (PaO2 <= 51.05263158)
            {
                SatO2 = 2 * PaO2 - 10;
            }
            else
            {
                SatO2 = 0.1 * PaO2 + 87;
                if (SatO2 > 100)
                {
                    SatO2 = 100.0;
                }

            }
            SpO2Val.Text = Math.Round(SatO2, 2).ToString();
        }
        public void SetChartAreas(Chart chart1, double xmin, double xmax, double ymin, double ymax, double inter)
        {
            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;
            chart1.ChartAreas[0].AxisY.Maximum = ymax;//esto lo tngo que cambiar para que se ajuste al Paw maximo
            chart1.ChartAreas[0].AxisY.Minimum = ymin;
            chart1.ChartAreas[0].AxisY.Interval = inter;
            chart1.Series[0].ChartType = SeriesChartType.Line;
        }
        private void PaintNextWhite(Chart c, int cant)
        {
            if (c.Series.Count > 0)
            {
                for (int j = 1; j <= cant; j++)
                    c.Series[0].Points[i + j].Color = Color.White;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (RespiEmpty == false && PatientEmpty == false&& FiO2>0 && FGF>0)
            {

                if (timer1.Enabled)
                {
                    timer1.Stop();
                    btnTimerP.Text = "Start";
                    btnStartM.Text = "Start";
                    t_change = 0;
                }
                else //si no esta funcionando el timer lo haces funcionar y cambias el boton para que diga stop
                {
                    timer1.Start();
                    btnTimerP.Text = "Stop";
                    btnStartM.Text = "Stop";
                }

                delay = (Vcirc + CRF) / FGF; //min
                Vol_tot_a = Vcirc + CRF + Vol_blood + Vol_tej;
                Tau = delay;//min
                if(flag_anes == true && t_anes == -1)
                {
                    t_anes = 0;
                    
                }

                if (flag_hipoxic == true && t_hipoxic==-1 )
                {
                    t_hipoxic = 0;
                    
                }

                
            }
            else
            { //uno de los dos no es verdadero
                string message;
                
                 if (!(FGF > 0)) 
                {
                    message = "El flujo de gases frescos entregado al paciente debe ser mayor a 0.";
                }
                else if (!(FiO2 > 0))
                {
                    message = "La fracción inspirada de oxígeno debe ser mayor a 0";
                }
                else if (RespiEmpty == true && PatientEmpty == true)
                {
                    message = "Se deben ingresar los parámetros de la máquina y del paciente";
                }
                else if (RespiEmpty == true && PatientEmpty == false)
                {
                    message = "Se deben ingresar los parámetros de la máquina";
                }
                else
                {
                    message = "Se deben ingresar los parámetros del paciente";
                }

                string caption = "Parametros no ingresados";
                MessageBoxButtons buttons = MessageBoxButtons.OK;


                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);

            }

        }

        private void FormMon_Load(object sender, EventArgs e)
        {
            //configuro para que el timer corra, el boton que le da Play diga start al principio de todo y el tipo de grafico
            timer1.Tick += timer1_Tick;
            timer1.Interval = 10;
            btnTimerP.Text = "Start";
            btnStartM.Text = "Start";
            chartPres.Series[0].ChartType = SeriesChartType.Line;
            chartFlow.Series[0].ChartType = SeriesChartType.Line;
            chartVol.Series[0].ChartType = SeriesChartType.Line;
        }

        private void chartVent_Click(object sender, EventArgs e)
        {

        }


    }
}