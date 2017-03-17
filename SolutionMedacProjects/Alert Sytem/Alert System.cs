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
using ServiceHealthClient = Alert_Sytem.ServiceMyHealthAlert.ServiceHealthClient;

namespace Alert_Sytem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistarPaciente formPaciente = new RegistarPaciente();

            DialogResult dialogResult = formPaciente.ShowDialog();
        }
    }
}
