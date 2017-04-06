using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alert_System.ServiceReference1;

namespace Alert_System
{
    public partial class Alerts : Form
    {
        public Alerts()
        {
            InitializeComponent();
        }

        int fk_sns = 0;
        ServiceReference1.Service1Client web = new Service1Client();


        private void Alerts_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fk_sns = Convert.ToInt32(patientsns.Text);

                PatientDC p = web.ValidadePatient(Convert.ToInt32(patientsns.Text));

                MessageBox.Show("Paciente: " + p.Firstname);
            }
            catch (Exception)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] w = web.ViewWarnings(fk_sns);



            foreach (string linha in w)
            {
                string[] ola = linha.Split(' ');
                for (int i = 0; i < ola.Length; i++)
                {
                    listView1.Items.Add(ola[i]);
                }
                
            }

            
            
        }
    }
}
