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

                else
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

        //Heart Rate
        private void btnshowhr_Click(object sender, EventArgs e)
        {
            if(lastthreedayshr.Checked)
            {
                int[] threedayshr = web.ViewOxygenSaturationthreedays(fk_sns, DateTime.Now);

                for (int i = 1; i <= threedayshr.Length; i++)
                {
                    minhr = threedayshr.Min();
                    avehr = threedayshr.Sum() / threedayshr.Length;
                    maxhr = threedayshr.Max();
                }
            }
            else
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

        //Oxygen Saturation 3 days
        private void btnshowos_Click(object sender, EventArgs e)
        {

            if (lastthreedaysos.Checked)
            {
                int[] threedaysos = web.ViewOxygenSaturationthreedays(fk_sns, DateTime.Now);

                for (int i = 1; i <= threedaysos.Length; i++)
                {
                    minos = threedaysos.Min();
                    aveos = threedaysos.Sum() / threedaysos.Length;
                    maxos = threedaysos.Max();
                }
            }

            else if(choosedatesos.Checked)
            {
                int[] threedaysos = web.ViewOxygenSaturationthreedays(fk_sns, DateTime.Now);

                for (int i = 1; i <= threedaysos.Length; i++)
                {
                    minos = threedaysos.Min();
                    aveos = threedaysos.Sum() / threedaysos.Length;
                    maxos = threedaysos.Max();
                }
            }
            else {
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

        private void Statisticdata_Load(object sender, EventArgs e)
        {
            dateTimePickerbp.MaxDate = DateTime.Today;
            dateTimePickerbp2.MaxDate = DateTime.Today;
            dateTimePickeros.MaxDate = DateTime.Today;
            dateTimePickeros2.MaxDate = DateTime.Today;
            dateTimePickerhr.MaxDate = DateTime.Today;
            dateTimePickerhr2.MaxDate = DateTime.Today;

        }
    }
}
