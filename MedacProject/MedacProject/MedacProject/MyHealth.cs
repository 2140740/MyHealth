using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedacProject.ServiceHealthClient;
using PhysiologicParametersDll;
using System.Timers;


namespace MedacProject
{
    public partial class MyHealth : Form
    {

        public MyHealth()
        {
            InitializeComponent();
        }

        bool flag = false;
        ServiceHealthClient.Service1Client web = new Service1Client();
        int second = 1;
        int conta = 0;
        int valor;
        int limit = 600000;

        private void Form1_Load(object sender, EventArgs e)
        {
            textPacientId.Text = Convert.ToString(Properties.Settings.Default.Patient);

            textBoxMedation.Text = Convert.ToString(Properties.Settings.Default.Setting_delay);
        }

        private void monitoring_Click(object sender, EventArgs e)
        {
            PhysiologicParametersDll.PhysiologicParametersDll dll =
                new PhysiologicParametersDll.PhysiologicParametersDll();
            //utilizar o valor dos XXXX por exemplo para XXXX, deve ser utilizado nas settings
            //a definir pelo paciente

            dll.InitializeWithAlerts(MyProcessMetod, Convert.ToInt32(Convert.ToInt32(textBoxMedation.Text.ToString()) * 1000), true,
                true, true);
            flag = false;
        }

        private void MyProcessMetod(string message)
        {
            int bloodPressureMin = 0;
            int bloodPressureMax = 0;
            int heartRate = 0;
            int oxygenSaturation = 0;
            int fk_sns = Convert.ToInt32(textPacientId.Text);
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TimeSpan time = DateTime.Now.TimeOfDay;
            timer1.Interval = 1000;
            timer1.Start();


            char[] delimiterChars = {' ', ';'};

            if(flag == false) { 
            this.BeginInvoke(new MethodInvoker(delegate
            {
                    if (checkBoxBP.Checked)
                {
                    if (message.Contains("BP"))
                    {
                        string[] bloodpre = message.Split(delimiterChars);
                        string[] texto = bloodpre[1].Split('-');
                        textbp.Text = texto[0] + "-" + texto[1];
                        bloodPressureMax = Convert.ToInt32(texto[0]);
                        bloodPressureMin = Convert.ToInt32(texto[1]);
                        date = DateTime.Parse(bloodpre[2] + " " + bloodpre[3]);
                        time = TimeSpan.Parse(bloodpre[3]);
                        //---------------------------------------------------------------------------
                        if (bloodPressureMax > 180 || bloodPressureMin < 80)
                        {
                            if (timer1.Interval < 1800000)
                            {
                                valor = 30000/(Convert.ToInt32(textBoxMedation.Text)*1000);
                                if (timer1.Interval < limit)
                                {
                                    conta = conta + 1;
                                    if (conta == valor)
                                    {
                                        web.RegisterWarnings(fk_sns, "Warning", DateTime.Now.Date + DateTime.Now.TimeOfDay, false, "Blood Pressure");
                                    }

                                }
                            }
                            
                        }
                        else
                        {
                            limit = 600000;
                        }
                        //------------------------------------------------------------------------------
                    }
                }

                if (checkBoxSPO.Checked)
                {
                    oxygenSaturation = 0;
                    if (message.Contains("SPO2"))
                    {
                        string[] sp = message.Split(delimiterChars);
                        textspo.Text = sp[1];
                        oxygenSaturation = Convert.ToInt32(sp[1]);
                        date = Convert.ToDateTime(sp[2]);
                        time = TimeSpan.Parse(sp[3]);
                        //---------------------------------------------------------------------------
                        if (oxygenSaturation < 90)
                        {
                            if (timer1.Interval < 1800000)
                            {
                                valor = 30000 / (Convert.ToInt32(textBoxMedation.Text) * 1000);
                                if (timer1.Interval < limit)
                                {
                                    conta = conta + 1;
                                    if (conta == valor)
                                    {
                                        web.RegisterWarnings(fk_sns, "Warning", DateTime.Now.Date + DateTime.Now.TimeOfDay, false, "Oxygen Saturation");
                                    }

                                }
                            }

                        }
                        else
                        {
                            limit = 600000;
                        }
                        //------------------------------------------------------------------------------
                    }
                }

                if (checkBoxHr.Checked)
                {
                    heartRate = 0;
                    if (message.Contains("HR"))
                    {

                        string[] hr = message.Split(delimiterChars);
                        texthr.Text = hr[1];
                        heartRate = Convert.ToInt32(hr[1]);
                        date = Convert.ToDateTime(hr[2]);
                        time = TimeSpan.Parse(hr[3]);
                        //---------------------------------------------------------------------------
                        if (heartRate < 60 || heartRate > 120)
                        {
                            if (timer1.Interval < 1800000)
                            {
                                valor = 30000 / (Convert.ToInt32(textBoxMedation.Text) * 1000);
                                if (timer1.Interval < limit)
                                {
                                    conta = conta + 1;
                                    if (conta == valor)
                                    {
                                        web.RegisterWarnings(fk_sns, "Warning", DateTime.Now.Date + DateTime.Now.TimeOfDay, false, "Heart");
                                    }

                                }
                            }

                        }
                        else
                        {
                            limit = 600000;
                        }
                        //------------------------------------------------------------------------------
                    }
                }

                //tudo o que tiver entre as chavetas
                try
                {
                    web.RegisterMeasurement(bloodPressureMin, bloodPressureMax, heartRate,
                        oxygenSaturation, Convert.ToDateTime(date), time, fk_sns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }));

            }

        }

        private void validate_Click(object sender, EventArgs e)
        {
            try
            {
                int patientid = int.Parse(textPacientId.Text);

                PatientDC p = web.ValidadePatient(patientid);

                MessageBox.Show("Bem vindo Sr.(a)" + p.Firstname);

                Properties.Settings.Default.Patient = patientid;
                Properties.Settings.Default.Save();

                web.UpdateLogged(patientid);

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi encontrado paciente");
            }
        }

        private void medicalId_Click(object sender, EventArgs e)
        {
            MedicalID FormMedicalID = new MedicalID();
            DialogResult = FormMedicalID.ShowDialog();
        }

        private void textBoxMedation_TextChanged(object sender, EventArgs e)
        {
            int delay = int.Parse(textBoxMedation.Text);
            Properties.Settings.Default.Setting_delay = delay;
            Properties.Settings.Default.Save();
        }

        private void medline_Click(object sender, EventArgs e)
        {
            Medline FormMedline = new Medline();
            DialogResult = FormMedline.ShowDialog();
        }

        private void MyHealth_FormClosing(object sender, FormClosingEventArgs e)
        {
            int patientid = int.Parse(textPacientId.Text);
            web.UpdateLogged(patientid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
