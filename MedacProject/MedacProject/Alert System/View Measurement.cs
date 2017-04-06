using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alert_System.ServiceReference1;

namespace Alert_System
{
    public partial class View_Measurement : Form
    {
        int numberseries = 0;
        int fk_sns = 0;
        ServiceReference1.Service1Client web = new Service1Client();

        public View_Measurement()
        {
            InitializeComponent();
        }

        private void View_Measurement_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fk_sns = Convert.ToInt32(textBox8.Text);

                PatientDC p = web.ValidadePatient(Convert.ToInt32(textBox8.Text));

                MessageBox.Show("Paciente: " + p.Firstname);

                oxygengraph.Enabled = true;
                heartrategraph.Enabled = true;
                pressuregraph.Enabled = true;


                listBox1.Enabled = true;
                checkshowvaluebp.Enabled = true;
                savegraph.Enabled = true;
                checkshowvaluesos.Enabled = true;
                checkshowvaluehr.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi encontrado paciente");
            }
        }

        private void pressuregraph_Click(object sender, EventArgs e)
        {
            //BloodPressureMax
            if(numberseries == 0)
            {
                numberseries = 1;
            int[] mtmax = web.ViewBloodPressureMax(fk_sns);

            string[] hora = web.ViewTime(fk_sns);

            chart1.Series.Add("Blood Pressure Max");

            chart1.Series["Blood Pressure Max"].ChartArea = "ChartArea1";

            chart1.Titles.Add("Blood Pressure");

            chart1.Series["Blood Pressure Max"].Color = Color.Red;

            chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 1; i <= mtmax.Length; i++)
            {
                string ola = hora[i];
                chart1.Series[numberseries].Points.AddXY(ola, Convert.ToInt32(mtmax[i - 1]));
            }
            //BloodPressureMin
            int[] mtmin = web.ViewBloodPressureMin(fk_sns);

            chart1.Series.Add("Blood Pressure Min");

            chart1.Series["Blood Pressure Min"].ChartArea = "ChartArea1";

            chart1.Series["Blood Pressure Min"].Color = Color.Blue;

            chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            numberseries = 2;
            for (int i = 1; i <= mtmin.Length; i++)
            {
                chart1.Series[numberseries].Points.AddY(Convert.ToInt32(mtmin[i - 1]));
            }
            }
            else if (numberseries == 1)
            {
                numberseries = 2;
                int[] mtmax = web.ViewBloodPressureMax(fk_sns);

                string[] hora = web.ViewTime(fk_sns);

                chart1.Series.Add("Blood Pressure Max");

                chart1.Series["Blood Pressure Max"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Blood Pressure");

                chart1.Series["Blood Pressure Max"].Color = Color.Red;

                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= mtmax.Length; i++)
                {
                    string ola = hora[i];
                    chart1.Series[numberseries].Points.AddXY(ola, Convert.ToInt32(mtmax[i - 1]));
                }
                //BloodPressureMin

                int[] mtmin = web.ViewBloodPressureMin(fk_sns);

                chart1.Series.Add("Blood Pressure Min");

                chart1.Series["Blood Pressure Min"].ChartArea = "ChartArea1";

                chart1.Series["Blood Pressure Min"].Color = Color.Blue;

                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                numberseries = 3;
                for (int i = 1; i <= mtmin.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(mtmin[i - 1]));
                }
            }
            else if (numberseries == 2)
            {
                numberseries = 3;
                int[] mtmax = web.ViewBloodPressureMax(fk_sns);

                string[] hora = web.ViewTime(fk_sns);

                chart1.Series.Add("Blood Pressure Max");

                chart1.Series["Blood Pressure Max"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Blood Pressure");

                chart1.Series["Blood Pressure Max"].Color = Color.Red;

                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= mtmax.Length; i++)
                {
                    string ola = hora[i];
                    chart1.Series[numberseries].Points.AddXY(ola, Convert.ToInt32(mtmax[i - 1]));
                }
                //BloodPressureMin

                int[] mtmin = web.ViewBloodPressureMin(fk_sns);

                chart1.Series.Add("Blood Pressure Min");

                chart1.Series["Blood Pressure Min"].ChartArea = "ChartArea1";

                chart1.Series["Blood Pressure Min"].Color = Color.Blue;

                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                numberseries = 4;
                for (int i = 1; i <= mtmin.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(mtmin[i - 1]));
                }
            }
        }

        private void heartrategraph_Click(object sender, EventArgs e)
        {
            if (numberseries == 0)
            {
                numberseries = 1;
            //Heart Rate
            int[] hr = web.ViewHearRate(fk_sns);

            
            chart1.Series.Add("Heart Rate");

            chart1.Series["Heart Rate"].ChartArea = "ChartArea1";

            chart1.Titles.Add("Heart Rate");

            chart1.Series["Heart Rate"].Color = Color.Green;

            chart1.Series["Heart Rate"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 1; i <= hr.Length; i++)
            {
                chart1.Series[numberseries].Points.AddY(Convert.ToInt32(hr[i - 1]));
            }
            }else if (numberseries == 1)
            {
                numberseries = 2;
                //Heart Rate
                int[] hr = web.ViewHearRate(fk_sns);

                chart1.Series.Add("Heart Rate");

                chart1.Series["Heart Rate"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Heart Rate");

                chart1.Series["Heart Rate"].Color = Color.Green;

                chart1.Series["Heart Rate"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= hr.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(hr[i - 1]));
                }
            }
            else if (numberseries == 2)
            {
                numberseries = 3;
                //Heart Rate
                int[] hr = web.ViewHearRate(fk_sns);


                chart1.Series.Add("Heart Rate");

                chart1.Series["Heart Rate"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Heart Rate");

                chart1.Series["Heart Rate"].Color = Color.Green;

                chart1.Series["Heart Rate"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= hr.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(hr[i - 1]));
                }
            }
            else if (numberseries == 3)
            {
                numberseries = 4;
                //Heart Rate
                int[] hr = web.ViewHearRate(fk_sns);


                chart1.Series.Add("Heart Rate");

                chart1.Series["Heart Rate"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Heart Rate");

                chart1.Series["Heart Rate"].Color = Color.Green;

                chart1.Series["Heart Rate"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= hr.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(hr[i - 1]));
                }
            }
        }

        private void oxygengraph_Click(object sender, EventArgs e)
        {
            if (numberseries == 0)
            {
                numberseries = 1;

                //Oxygen Saturation
                int[] os = web.ViewOxygenSaturation(fk_sns);

                chart1.Series.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].Color = Color.DeepPink;

                chart1.Series["Oxygen Saturation"].ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= os.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(os[i - 1]));
                }
            }
            else if (numberseries == 1)
            {
                numberseries = 2;
                //Oxygen Saturation
                int[] os = web.ViewOxygenSaturation(fk_sns);

                chart1.Series.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].Color = Color.DeepPink;

                chart1.Series["Oxygen Saturation"].ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= os.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(os[i - 1]));
                }
            }
            else if (numberseries == 2)
            {
                numberseries = 3;
                //Oxygen Saturation
                int[] os = web.ViewOxygenSaturation(fk_sns);

                chart1.Series.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].Color = Color.DeepPink;

                chart1.Series["Oxygen Saturation"].ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= os.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(os[i - 1]));
                }
            }
            else if (numberseries == 3)
            {
                numberseries = 4;
                //Oxygen Saturation
                int[] os = web.ViewOxygenSaturation(fk_sns);

                chart1.Series.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].ChartArea = "ChartArea1";

                chart1.Titles.Add("Oxygen Saturation");

                chart1.Series["Oxygen Saturation"].Color = Color.DeepPink;

                chart1.Series["Oxygen Saturation"].ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= os.Length; i++)
                {
                    chart1.Series[numberseries].Points.AddY(Convert.ToInt32(os[i - 1]));
                }
            }
        }

        private void statisticData_Click(object sender, EventArgs e)
        {
            Statisticdata Formstatistics = new Statisticdata();
            DialogResult = Formstatistics.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.Equals("Point") && chart1.Series.IsUniqueName("Blood"))
            {
                //definição do tipo de gráfico
                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            }
            else if (listBox1.SelectedItem.Equals("FastPoint") && chart1.Series.IsUniqueName("Blood"))
            {
                //definição do tipo de gráfico
                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            }
            else if (listBox1.SelectedItem.Equals("Bubble") && chart1.Series.IsUniqueName("Blood"))
            {
                //definição do tipo de gráfico
                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            }
            else if (listBox1.SelectedItem.Equals("Line") && chart1.Series.IsUniqueName("Blood"))
            {
                //definição do tipo de gráfico
                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            else if (listBox1.SelectedItem.Equals("Spline") && chart1.Series.IsUniqueName("Blood"))
            {
                //definição do tipo de gráfico
                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            else if (listBox1.SelectedItem.Equals("Column") && chart1.Series.IsUniqueName("Blood"))
            {
                //definição do tipo de gráfico
                chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            //---------------------------------------------------------------------------------
            if (listBox1.SelectedItem.Equals("Point") && chart1.Series.IsUniqueName("Oxygen"))
            {
                //definição do tipo de gráfico
                chart1.Series["Oxygen Saturation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            }
            else if (listBox1.SelectedItem.Equals("FastPoint") && chart1.Series.IsUniqueName("Oxygen"))
            {
                //definição do tipo de gráfico
                chart1.Series["Oxygen Saturation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            }
            else if (listBox1.SelectedItem.Equals("Bubble") && chart1.Series.IsUniqueName("Oxygen"))
            {
                //definição do tipo de gráfico
                chart1.Series["Oxygen Saturation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            }
            else if (listBox1.SelectedItem.Equals("Line") && chart1.Series.IsUniqueName("Oxygen"))
            {
                //definição do tipo de gráfico
                chart1.Series["Oxygen Saturation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            else if (listBox1.SelectedItem.Equals("Spline") && chart1.Series.IsUniqueName("Oxygen"))
            {
                //definição do tipo de gráfico
                chart1.Series["Oxygen Saturation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            else if (listBox1.SelectedItem.Equals("Column") && chart1.Series.IsUniqueName("Oxygen"))
            {
                //definição do tipo de gráfico
                chart1.Series["Oxygen Saturation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            //---------------------------------------------------------------------------------
            if (listBox1.SelectedItem.Equals("Point") && chart1.Series.IsUniqueName("Heart"))
            {
                //definição do tipo de gráfico
                chart1.Series["Heart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            }
            else if (listBox1.SelectedItem.Equals("FastPoint") && chart1.Series.IsUniqueName("Heart"))
            {
                //definição do tipo de gráfico
                chart1.Series["Heart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            }
            else if (listBox1.SelectedItem.Equals("Bubble") && chart1.Series.IsUniqueName("Heart"))
            {
                //definição do tipo de gráfico
                chart1.Series["Heart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            }
            else if (listBox1.SelectedItem.Equals("Line") && chart1.Series.IsUniqueName("Heart"))
            {
                //definição do tipo de gráfico
                chart1.Series["Heart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            else if (listBox1.SelectedItem.Equals("Spline") && chart1.Series.IsUniqueName("Heart"))
            {
                //definição do tipo de gráfico
                chart1.Series["Heart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            else if (listBox1.SelectedItem.Equals("Column") && chart1.Series.IsUniqueName("Heart"))
            {
                //definição do tipo de gráfico
                chart1.Series["Heart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }

        }

        private void savegraph_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                chart1.SaveImage(sfd.FileName, format);
                MessageBox.Show("Imagem Gravada com sucesso", "Sucesso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Imagem Não Gravada", "Gravação", MessageBoxButtons.OK);
            }
            
        }

        private void checkshowvaluebp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowvaluebp.Checked && chart1.Series.IsUniqueName("Blood"))
            {
                chart1.Series["Blood Pressure Max"].IsValueShownAsLabel = true;
                chart1.Series["Blood Pressure Min"].IsValueShownAsLabel = true;
            }
            else
            {
                chart1.Series["Blood Pressure Max"].IsValueShownAsLabel = false;
                chart1.Series["Blood Pressure Min"].IsValueShownAsLabel = false;
            }
        }

        private void checkshowvaluehr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowvaluehr.Checked && chart1.Series.IsUniqueName("Heart"))
            {
                chart1.Series["Heart Rate"].IsValueShownAsLabel = true;
            }
            else
            {
                chart1.Series["Heart Rate"].IsValueShownAsLabel = false;
            }
        }

        private void checkshowvaluesos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowvaluesos.Checked && chart1.Series.IsUniqueName("Oxygen"))
            {
                chart1.Series["Oxygen Saturation"].IsValueShownAsLabel = true;
            }
            else
            {
                chart1.Series["Oxygen Saturation"].IsValueShownAsLabel = false;
            }
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
