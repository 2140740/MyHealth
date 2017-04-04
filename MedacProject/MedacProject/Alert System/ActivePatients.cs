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
    public partial class ActivePatients : Form
    {
        ServiceReference1.Service1Client web = new Service1Client();

        public ActivePatients()
        {
            InitializeComponent();
        }

        private void ActivePatients_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

           
            listView1.Columns.Add("First Name");
            listView1.Columns[0].Width = 261;

            String[] Patients = web.ViewActivePatients();
            //Blood Pressure
            for (int i = 0; i <= Patients.Length; i++)
            {
                string linha = Patients[i];
                listView1.Items.Add(linha);
            }
            
        }

    }
}
