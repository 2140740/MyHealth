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
    public partial class FormUpdate : Form
    {
        int fk_sns = 0;
        ServiceReference1.Service1Client web = new Service1Client();
        PatientDC p;

        public FormUpdate()
        {
            InitializeComponent();

        }

        private void validate_Click(object sender, EventArgs e)
        {
            fk_sns = Convert.ToInt32(boxvalidate.Text);

            p = web.ValidadePatient(Convert.ToInt32(boxvalidate.Text));

            if (p == null)
            {
                MessageBox.Show("Não existe pacientes com o sns: "+ fk_sns);
            }
            else
            {
                MessageBox.Show("Bem vindo Sr.(a)" + p.Firstname);

                BoxFirstName_old.Text = p.Firstname;
                BoxLastName_old.Text = p.LastName;
                BoxPhone_old.Text = Convert.ToString(p.Phone);
                BoxEmail_old.Text = p.Email;
                BoxBirthday_old.Text = Convert.ToString(p.BirthDate);
                BoxCCbi_old.Text = Convert.ToString(p.Cc_bi);
                BoxSNS_old.Text = Convert.ToString(p.Sns);
                BoxAddress_old.Text = p.Address;
                BoxGender_old.Text = Convert.ToString(p.Gender);
                BoxAllergies_old.Text = p.Allergies;
                BoxHeight_old.Text = Convert.ToString(p.Height);
                BoxOtherContact_old.Text = Convert.ToString(p.Othercontact);

            }
        }

        private void update_information_Click(object sender, EventArgs e)
        {
            char gender = ' ';
            double height = 0.0;
            int othercontact = 0;
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
                if (BoxOthercontact.Text.Equals(""))
                {
                    othercontact = 0;
                }
                else
                {
                    othercontact = Convert.ToInt32(BoxOthercontact.Text);
                }

                ServiceReference1.Service1Client web = new Service1Client();
                web.UpdatePatient(BoxFirstName.Text, BoxLastName.Text,
                    Convert.ToInt32(BoxPhone.Text), BoxEmail.Text, Convert.ToDateTime(BoxBirthday.Text),
                    Convert.ToInt32(BoxCCbi.Text), Convert.ToInt32(BoxSNS.Text),
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
