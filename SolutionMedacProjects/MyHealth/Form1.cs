using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHealth.ServiceMyHealth;
using PhysiologicParametersDll;

namespace MyHealth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textPacientId.Text = Convert.ToString(Properties.Settings.Default.Patient);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ir À base de dados buscar o utente
            //copiar os dados do utente para o paciente


            
            //validade junto do web service se o paciente existe
            //se existir mostrar uma mensagemde boas vindas

            int patientid = int.Parse(textPacientId.Text);

            ServiceHealthClient web = new ServiceHealthClient();

            Patient p = web.ValidadePatient(patientid);

            MessageBox.Show("Bem vindo Sr.(a)" + p.Firstname);

            Properties.Settings.Default.Patient = patientid;
            Properties.Settings.Default.Save();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhysiologicParametersDll.PhysiologicParametersDll dll = new PhysiologicParametersDll.PhysiologicParametersDll();
            //utilizar o valor dos XXXX por exemplo para XXXX, deve ser utilizado nas settings
            //a definir pelo paciente
            dll.Initialize(MyProcessMetod,Convert.ToInt32(Convert.ToInt32(textBoxMedation.Text.ToString())*1000),true,true,true);
        }

        private void MyProcessMetod(string message)
        {
            int bloodPressureMin = 0;
            int bloodPressureMax = 0;
            int heartRate = 0;
            int oxygenSaturation = 0;
            int fk_sns = Convert.ToInt32(textPacientId.Text);
            DateTime date = DateTime.Now;
            TimeSpan time = DateTime.Now.TimeOfDay;

       char[] delimiterChars = { ' ', ';'};

            this.BeginInvoke(new MethodInvoker(delegate
                {          
                    
                if (checkBoxBP.Checked) {
                    if (message.Contains("BP"))
                    {
                        string[] bloodpre = message.Split(delimiterChars);
                        string[] texto = bloodpre[1].Split('-');
                        textbp.Text = texto[0] + "-" +texto[1];
                        bloodPressureMin = Convert.ToInt32(texto[0]);
                        bloodPressureMax = Convert.ToInt32(texto[1]);
                        date = DateTime.Parse(bloodpre[2]+" "+bloodpre[3]);
                        time =TimeSpan.Parse(bloodpre[3]);

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
                            date = Convert.ToDateTime(sp[4] + sp[5] + sp[6]);
                            time = TimeSpan.Parse(sp[6]);
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
                            date = Convert.ToDateTime(hr[4] + hr[5] + hr[6]);
                            time = TimeSpan.Parse(hr[6]);
                        }
                    }
                    
                    //tudo o que tiver entre as chavetas
                    try
                    {
                        ServiceHealthClient web = new ServiceHealthClient();
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
}
