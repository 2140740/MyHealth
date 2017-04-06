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

namespace MedacProject
{
    public partial class MedicalID : Form
    {
        public MedicalID()
        {
            InitializeComponent();
        }

        private void data_Click(object sender, EventArgs e)
        {
            try
            {
                int patientid = int.Parse(PatientSNS.Text);

                ServiceHealthClient.Service1Client web = new Service1Client();

                PatientDC p = web.ValidadePatient(patientid);

                Properties.Settings.Default.Patient = patientid;
                Properties.Settings.Default.Save();

                string[] listview= {p.Firstname,p.LastName,Convert.ToString(p.BirthDate.ToShortDateString()),Convert.ToString(p.Sns)};

               

                foreach (string linha in listview)
                {
                    listView1.Items.Add(linha);
                }

                

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi encontrado paciente");
            }
        }

        private void MedicalID_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
