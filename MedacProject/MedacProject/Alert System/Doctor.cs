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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            ServiceReference1.Service1Client web = new Service1Client();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.Service1Client web = new Service1Client();
                web.RegisterDoctor(textBox1.Text, textBox2.Text);

                MessageBox.Show("Médico Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client web = new Service1Client();
            string medicalid = "";
            try
            {
                medicalid = textBox3.Text;

                DoctorDC d = web.ValidadeDoctor(textBox3.Text);

                MessageBox.Show("Médico: " + d.Medicalid + d.Name);

                Properties.Settings.Default.MedicalID = medicalid;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi encontrado o médico");
            }
        }
    }
}
