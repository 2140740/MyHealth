using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alert_Sytem.ServiceMyHealthAlert;

namespace Alert_Sytem
{
    public partial class RegistarPaciente : Form
    {

        public RegistarPaciente()
        {
            InitializeComponent();
        }

        private void RegistarPaciente_Load(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            char gender = ' ';
            double height = 0.0;
            int othercontact = 0;
            try
            {
                if (!BoxFirstName.Text.Equals("") && !BoxLastName.Text.Equals("")
                    && !BoxPhone.Text.Equals("") && !BoxCC_BI.Text.Equals("")
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
                if (BoxBirthDate.Text.Equals(""))
                {
                    Convert.ToDateTime(BoxBirthDate.Text = "");
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
                    othercontact = 0;
                }
                else
                {
                    othercontact = Convert.ToInt32(BoxOtherContact.Text);
                }
            
            
            ServiceHealthClient web = new ServiceHealthClient();
                    web.RegisterPatient(BoxFirstName.Text, BoxLastName.Text,
                        Convert.ToInt32(BoxPhone.Text), BoxEmail.Text, Convert.ToDateTime(BoxBirthDate.Text),
                        Convert.ToInt32(BoxCC_BI.Text), Convert.ToInt32(BoxSNS.Text), 
                        BoxAddress.Text, gender, BoxAllergies.Text,
                        height, othercontact);

                MessageBox.Show("Paciente Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }     
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
