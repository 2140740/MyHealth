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
            textPacientId.Text = Properties.Settings.Default.Patient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ir À base de dadso buscar o utente
            //copiar os dados do utente para o paciente


            
            //validade junto do web service se o paciente existe
            //se existir mostrar uma mensagemde boas vindas

            int patientid = int.Parse(textPacientId.Text);

            ServiceHealthClient web = new ServiceHealthClient();

            Patient p = web.ValidadePatient(patientid);

            MessageBox.Show("Bem vindo Sr.(a)" + p.Firstname);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhysiologicParametersDll.PhysiologicParametersDll dll = new PhysiologicParametersDll.PhysiologicParametersDll();
            //utilizar o valor dos 5000 por exemplo para 12000, deve ser utilizado nas settings
            //a definir pelo paciente
            dll.Initialize(MyProcessMetod,5000,true,true,true);
        }

        private void MyProcessMetod(string message)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (checkBoxBP.Checked) {
                    if (message.Contains("BP"))
                    {
                        textbp.Text = message;
                    }
                }

                if (checkBoxSPO.Checked)
                {
                    if (message.Contains("SPO2"))
                    {
                        textspo.Text = message;
                    }
                }

                if (checkBoxHr.Checked)
                {
                    if (message.Contains("HR"))
                    {
                        texthr.Text = message;
                    }
                }
                //tudo o que tiver entre as chavetas
                    richTextBox1.AppendText(message + Environment.NewLine);
            }));
            
        }
    }
}
