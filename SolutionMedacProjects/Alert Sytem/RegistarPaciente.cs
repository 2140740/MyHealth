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
            char gender;

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
                    ServiceHealthClient web = new ServiceHealthClient();
                    web.RegisterPatient(BoxFirstName.Text, BoxLastName.Text,
                        Convert.ToInt32(BoxPhone.Text), BoxEmail.Text, Convert.ToDateTime(BoxBirthDate.Text),
                        Convert.ToInt32(BoxCC_BI.Text), Convert.ToInt32(BoxSNS.Text), BoxAddress.Text,
                        gender, BoxAllergies.Text,
                        Convert.ToDouble(BoxHeight.Text), Convert.ToInt32(BoxOtherContact.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
