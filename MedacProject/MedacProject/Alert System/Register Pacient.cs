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
    public partial class Register_Pacient : Form
    {
        public Register_Pacient()
        {
            InitializeComponent();
        }

        private void Register_Pacient_Load(object sender, EventArgs e)
        {

        }

        private void savepatient_Click(object sender, EventArgs e)
        {
            char gender = ' ';
            double height = 0.0;
            string othercontact;
            string medicalid = Properties.Settings.Default.MedicalID;
            try
            {
                if (!BoxFirstName.Text.Equals("") && !BoxLastName.Text.Equals("")
                    && !BoxPhone.Text.Equals("") && !BoxCCbi.Text.Equals("")
                    && !BoxSNS.Text.Equals("") && !BoxGender.SelectedItem.Equals(""))
                {
                    if (BoxGender.SelectedItem.Equals("Male"))
                    {
                        gender = 'M';
                    }
                    else
                    {
                        gender = 'F';
                    }
                }

                if (BoxEmail.Text.Equals(""))
                {
                    BoxEmail.Text = "";
                }
                if (BoxBirthday.Text.Equals(""))
                {
                    Convert.ToDateTime(BoxBirthday.Text = "");
                }
                if (BoxAddress.Text.Equals(""))
                {
                    BoxAddress.Text = "";
                }
                if (BoxAllergies.Text.Equals(""))
                {
                    BoxAllergies.Text = "";
                }
                if (BoxHeight.Text.Equals(""))
                {
                    height = 0.0;
                }
                else
                {
                    height = Convert.ToDouble(BoxHeight.Text);
                }
                if (BoxOtherContact.Text.Equals(""))
                {
                    othercontact = "";
                }
                else
                {
                    othercontact = BoxOtherContact.Text;
                }
                bool logged = false;
                


                ServiceReference1.Service1Client web = new Service1Client();

                DoctorDC doctor = web.ValidadeDoctor(medicalid);
                if (doctor != null)
                {
                    web.RegisterPatient(BoxFirstName.Text, BoxLastName.Text,
                        Convert.ToInt32(BoxPhone.Text), BoxEmail.Text, Convert.ToDateTime(BoxBirthday.Text),
                        Convert.ToInt32(BoxCCbi.Text), Convert.ToInt32(BoxSNS.Text),
                        BoxAddress.Text, gender, BoxAllergies.Text,
                        height, othercontact, logged, medicalid);

                    MessageBox.Show("Paciente Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta o médico fazer login", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
