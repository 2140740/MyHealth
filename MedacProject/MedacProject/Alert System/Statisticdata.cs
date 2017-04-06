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
    public partial class Statisticdata : Form
    {
        int fk_sns = 0;
        ServiceReference1.Service1Client web = new Service1Client();
        //Blood Pressure
        private float maxbloodpre;
        private float minbloodpre;
        private float medpre;
        //Heart Rate
        private float maxhr;
        private float minhr;
        private float avehr;
        //Oxygen Saturation
        private float maxos;
        private float minos;
        private float aveos;


        public Statisticdata()
        {
            InitializeComponent();
        }

        private void validatestatic_Click(object sender, EventArgs e)
        {
            try
            {
                fk_sns = Convert.ToInt32(pacientid.Text);

                PatientDC p = web.ValidadePatient(Convert.ToInt32(pacientid.Text));

                MessageBox.Show("Paciente: " + p.Firstname);

                if (p != null)
                {
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi encontrado paciente");
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                //Blood Pressure 3 days     
                int[] mtmax = web.ViewBloodPressureMax(fk_sns);
                int[] mtmin = web.ViewBloodPressureMin(fk_sns);
                int[] mtmaxthreedays = web.ViewBloodPressureMaxthreedays(fk_sns, DateTime.Now);
                int[] mtminthreedays = web.ViewBloodPressureMinthreedays(fk_sns, DateTime.Now);

                if (lastthreedaysbp.Checked)
                {
                    for (int i = 1; i <= mtmaxthreedays.Length; i++)
                    {
                        maxbloodpre = mtmaxthreedays.Max();
                    }
                    for (int i = 1; i <= mtminthreedays.Length; i++)
                    {
                        minbloodpre = mtminthreedays.Min();
                    }
                    medpre = (mtmaxthreedays.Sum() + mtminthreedays.Sum())/
                             (mtmaxthreedays.Length + mtminthreedays.Length);
                }
                //Blood Pressuser Calendar
                else if (choosedatespb.Checked)
                {
                    if (dateTimePickerbp2.Value.Hour > dateTimePickerbp.Value.Hour || dateTimePickerbp2.Value.Minute > dateTimePickerbp.Value.Minute
                        || dateTimePickerbp2.Value.Date > dateTimePickerbp.Value.Date || dateTimePickerbp2.Value.Second > dateTimePickerbp.Value.Second)
                    {
                        int[] bpchoosedatesmax = web.ViewBloodPressureMaxCalendar(fk_sns, dateTimePickerbp.Value.Date,
                            dateTimePickerbp2.Value.Date);
                        int[] bpchoosedatesmin = web.ViewBloodPressureMinCalendar(fk_sns, dateTimePickerbp.Value.Date,
                            dateTimePickerbp2.Value.Date);

                        for (int i = 1; i <= bpchoosedatesmax.Length; i++)
                        {
                            maxbloodpre = bpchoosedatesmax.Max();
                        }
                        for (int i = 1; i <= bpchoosedatesmin.Length; i++)
                        {
                            minbloodpre = bpchoosedatesmin.Min();
                        }
                        medpre = (bpchoosedatesmax.Sum() + bpchoosedatesmin.Sum()) /
                                 (bpchoosedatesmax.Length + bpchoosedatesmin.Length);
                    }
                    else
                    {
                        MessageBox.Show("A segunda data tem de ser superior à primeira", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else if(alltimebp.Checked)
                {
                    //Blood Pressure
                    for (int i = 1; i <= mtmax.Length; i++)
                    {
                        maxbloodpre = mtmax.Max();
                    }
                    for (int i = 1; i <= mtmin.Length; i++)
                    {
                        minbloodpre = mtmin.Min();
                    }
                    medpre = (mtmax.Sum() + mtmin.Sum())/(mtmax.Length + mtmin.Length);
                }

                boxmax.Text = maxbloodpre.ToString();
                boxmin.Text = minbloodpre.ToString();
                boxmed.Text = medpre.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Não existem valores nestes últimos três dias", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //Heart Rate 3 days
        private void btnshowhr_Click(object sender, EventArgs e)
        {
            try
            {
                if (lastthreedayshr.Checked)
                {
                    int[] threedayshr = web.ViewOxygenSaturationthreedays(fk_sns, DateTime.Now);

                    for (int i = 1; i <= threedayshr.Length; i++)
                    {
                        minhr = threedayshr.Min();
                        avehr = threedayshr.Sum()/threedayshr.Length;
                        maxhr = threedayshr.Max();
                    }
                }
                //Heart Rate Calendar
                else if (choosedateshr.Checked)
                {
                    if (dateTimePickerhr2.Value.Hour > dateTimePickerhr.Value.Hour || dateTimePickerhr2.Value.Minute > dateTimePickerhr.Value.Minute 
                        || dateTimePickerhr2.Value.Date > dateTimePickerhr.Value.Date || dateTimePickerhr2.Value.Second > dateTimePickerhr.Value.Second)
                    {
                        int[] hrchoosedates = web.ViewHeartRateCalendar(fk_sns, dateTimePickerhr.Value.Date,
                            dateTimePickerhr2.Value.Date);

                        for (int i = 1; i <= hrchoosedates.Length; i++)
                        {
                            minhr = hrchoosedates.Min();
                            avehr = hrchoosedates.Sum()/hrchoosedates.Length;
                            maxhr = hrchoosedates.Max();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A segunda data tem de ser superior à primeira", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                //All Heart Rate
                else if (alltimehr.Checked)
                {
                    int[] hr = web.ViewHearRate(fk_sns);

                    for (int i = 1; i <= hr.Length; i++)
                    {
                        maxhr = hr.Max();
                        minhr = hr.Min();
                        avehr = hr.Sum()/hr.Length;
                    }
                }

                boxminhr.Text = minhr.ToString();
                boxavehr.Text = avehr.ToString();
                boxmaxhr.Text = maxhr.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Não existem valores nestes últimos três dias", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //Oxygen Saturation 3 days
        private void btnshowos_Click(object sender, EventArgs e)
        {
            try
            {

                if (lastthreedaysos.Checked)
                {
                    int[] threedaysos = web.ViewOxygenSaturationthreedays(fk_sns, DateTime.Now);

                    for (int i = 1; i <= threedaysos.Length; i++)
                    {
                        minos = threedaysos.Min();
                        aveos = threedaysos.Sum()/threedaysos.Length;
                        maxos = threedaysos.Max();
                    }
                }

                //Oxygen Saturation Calendar
                else if (choosedatesos.Checked)
                {
                    if (dateTimePickeros2.Value.Hour > dateTimePickeros.Value.Hour || dateTimePickeros2.Value.Minute > dateTimePickeros.Value.Minute
                         || dateTimePickeros2.Value.Date > dateTimePickeros.Value.Date || dateTimePickeros2.Value.Second > dateTimePickeros.Value.Second)
                        {
                        int[] oschoosedates = web.ViewOxygenSaturationCalendar(fk_sns, dateTimePickeros.Value.Date,
                            dateTimePickeros2.Value.Date);

                        for (int i = 1; i <= oschoosedates.Length; i++)
                        {
                            minos = oschoosedates.Min();
                            aveos = oschoosedates.Sum()/oschoosedates.Length;
                            maxos = oschoosedates.Max();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A segunda data tem de ser superior à primeira", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                else if (alltimeos.Checked)
                {
                    //Oxygen Saturation
                    int[] os = web.ViewOxygenSaturation(fk_sns);

                    for (int i = 1; i <= os.Length; i++)
                    {
                        minos = os.Min();
                        aveos = os.Sum()/os.Length;
                        maxos = os.Max();
                    }

                }

                boxminos.Text = minos.ToString();
                boxaveos.Text = aveos.ToString();
                boxmaxos.Text = maxos.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Não existem valores nestes últimos três dias", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void Statisticdata_Load(object sender, EventArgs e)
        {
            //-----------------------------------------------------------BP
            dateTimePickerbp.Format = DateTimePickerFormat.Custom;
            dateTimePickerbp.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm:ss";
            dateTimePickerbp.MaxDate = DateTime.Today;
            //-----------------------------------------------------------BP2
            dateTimePickerbp2.Format = DateTimePickerFormat.Custom;
            dateTimePickerbp2.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm:ss";
            dateTimePickerbp2.MaxDate = DateTime.Today;
            //-----------------------------------------------------------OS
            dateTimePickeros.Format = DateTimePickerFormat.Custom;
            dateTimePickeros.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm:ss";
            dateTimePickeros.MaxDate = DateTime.Today;
            //-----------------------------------------------------------OS2
            dateTimePickeros2.Format = DateTimePickerFormat.Custom;
            dateTimePickeros2.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm:ss";
            dateTimePickeros2.MaxDate = DateTime.Today;
            //-----------------------------------------------------------HR
            dateTimePickerhr.Format = DateTimePickerFormat.Custom;
            dateTimePickerhr.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm:ss";
            dateTimePickerhr.MaxDate = DateTime.Today;
            //-----------------------------------------------------------HR2
            dateTimePickerhr2.Format = DateTimePickerFormat.Custom;
            dateTimePickerhr2.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm:ss";
            dateTimePickerhr2.MaxDate = DateTime.Today;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] mtmax = web.ViewBloodPressureMax(fk_sns);
            int[] mtmin = web.ViewBloodPressureMin(fk_sns);
            int[] hr = web.ViewHearRate(fk_sns);
            int[] os = web.ViewOxygenSaturation(fk_sns);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Equals("Register Patient"))
            {
                Register_Pacient FormRegistPacient = new Register_Pacient();
                DialogResult = FormRegistPacient.ShowDialog();
            }
            if (e.Node.Text.Equals("Update Patient"))
            {
                FormUpdate FormUpdatePacient = new FormUpdate();
                DialogResult = FormUpdatePacient.ShowDialog();
            }

            if (e.Node.Text.Equals("View Measurement"))
            {
                View_Measurement FormViewMeasurement = new View_Measurement();
                DialogResult = FormViewMeasurement.ShowDialog();
            }

            if (e.Node.Text.Equals("Statistic data"))
            {
                Statisticdata Formstatistics = new Statisticdata();
                DialogResult = Formstatistics.ShowDialog();
            }
            if (e.Node.Text.Equals("Register Doctor") || e.Node.Text.Equals("Login Doctor"))
            {
                Doctor FormDoctor = new Doctor();
                DialogResult = FormDoctor.ShowDialog();
            }
            if (e.Node.Text.Equals("Active Patients"))
            {
                ActivePatients FormActivePatients = new ActivePatients();
                DialogResult = FormActivePatients.ShowDialog();
            }
        }

        private void registerMedicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor FormDoctor = new Doctor();
            DialogResult = FormDoctor.ShowDialog();
        }

        private void activePatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivePatients FormActivePatients = new ActivePatients();
            DialogResult = FormActivePatients.ShowDialog();
        }
    }
}
