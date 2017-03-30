using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alert_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewMeasurement_Click(object sender, EventArgs e)
        {
            View_Measurement FormViewMeasurement = new View_Measurement();

            DialogResult = FormViewMeasurement.ShowDialog();
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Pacient FormRegistPacient = new Register_Pacient();

            DialogResult = FormRegistPacient.ShowDialog();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate FormUpdatePacient = new FormUpdate();

            DialogResult = FormUpdatePacient.ShowDialog();
        }
    }
}
