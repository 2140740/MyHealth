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
            ServiceHealthClient web = new ServiceHealthClient();
            
        }
    }
}
