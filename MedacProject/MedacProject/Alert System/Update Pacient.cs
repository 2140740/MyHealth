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

                boxid.Text = Convert.ToString(p.PatientID);
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
            try
            {
                ServiceReference1.Service1Client web = new Service1Client();

                Patient p = new Patient();

                p.Id = Convert.ToInt32(boxid.Text);
                p.FirstName = BoxFirstName.Text;
                p.LastName = BoxLastName.Text;
                p.Phone = Convert.ToInt32(BoxPhone.Text);
                p.Email = BoxEmail.Text;
                p.BirthDate = Convert.ToDateTime(BoxBirthday.Text);
                p.CC_BI = Convert.ToInt32(BoxCCbi.Text);
                p.SNS = Convert.ToInt32(BoxSNS.Text);
                p.Address = BoxAddress.Text;

                if (BoxGender.SelectedItem.Equals("Male"))
                {
                    p.Gender = "M";
                }
                else
                {
                    p.Gender = "F";
                }
                p.Allergies = BoxAllergies.Text;
                if (BoxHeight.Text.Equals(""))
                {
                    p.Height = 0.0;
                }
                else
                {
                    p.Height = Convert.ToDouble(BoxHeight.Text);
                }
                if (BoxOthercontact.Text.Equals(""))
                {
                    p.OtherContact = "";
                }
                else
                {
                    p.OtherContact = BoxOthercontact.Text;
                }

                web.UpdatePatient(p);

                MessageBox.Show("Paciente alterado com sucesso", "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Falta preencher campos obrigatórios (*)","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
