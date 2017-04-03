using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFMedacService;

namespace WCFMedacService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public PatientDC ValidadePatient(int id)
        {
            PatientDC p = new PatientDC();

            ModelMedacContainer context = new ModelMedacContainer();
            Patient pt = context.PatientSet.FirstOrDefault(i => i.SNS == id);

            if (pt == null)
                return null;
            else
            {
                p.PatientID = pt.Id;
                p.Firstname = pt.FirstName;
                p.LastName = pt.LastName;
                p.Phone = pt.Phone;
                p.Email = pt.Email;
                p.BirthDate = pt.BirthDate;
                p.Cc_bi = pt.CC_BI;
                p.Sns = pt.SNS;
                p.Address = pt.Address;
                p.Gender = Convert.ToChar(pt.Gender);
                p.Allergies = pt.Allergies;
                p.Height = Convert.ToDouble(pt.Height);
                p.Othercontact = Convert.ToInt32(pt.OtherContact);

                return p;
            }
        }

        public bool RegisterPatient(string firstname, string lastname, int phone,
            string email, DateTime birthdate, int cc_bi, int sns,
            string address, char gender, string allergies, double height,
            int othercontact)
        {
            Patient pt = new Patient();
            try
            {

                if (pt != null)
                {
                    ModelMedacContainer context = new ModelMedacContainer();

                    pt.FirstName = firstname;
                    pt.LastName = lastname;
                    pt.Phone = phone;
                    pt.Email = email;
                    pt.BirthDate = birthdate;
                    pt.CC_BI = cc_bi;
                    pt.SNS = sns;
                    pt.Address = address;
                    pt.Gender = gender.ToString();
                    pt.Allergies = allergies;
                    pt.Height = height;
                    pt.OtherContact = othercontact.ToString();

                    context.PatientSet.Add(pt);
                    context.SaveChanges();
                }
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

        public void UpdatePatient(Patient patient)
        {
            ModelMedacContainer context = new ModelMedacContainer();
            Patient pt = context.PatientSet.First(i => i.Id == patient.Id);

                if (pt != null)
                {
                    pt.Id = pt.Id;
                    pt.FirstName = patient.FirstName;
                    pt.LastName = patient.LastName;
                    pt.Phone = patient.Phone;
                    pt.Email = patient.Email;
                    pt.BirthDate = patient.BirthDate;
                    pt.CC_BI = patient.CC_BI;
                    pt.SNS = patient.SNS;
                    pt.Address = patient.Address;
                    pt.Gender = patient.Gender;
                    pt.Allergies = patient.Allergies;
                    pt.Height = patient.Height;
                    pt.OtherContact = patient.OtherContact;

                    context.SaveChanges();
                }
        }

 

        public bool RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate,
            int oxygensaturation, DateTime date, TimeSpan time, int fk_sns)
        {
            Measurement mte = new Measurement();

            try
            {
                ModelMedacContainer context = new ModelMedacContainer();


                Patient p = context.PatientSet.FirstOrDefault(i => i.SNS == fk_sns);

                if (p != null)
                {
                    mte.BloodPressureMax = bloodpressuremax;
                    mte.BloodPressureMin = bloodpressuremin;
                    mte.HeartRate = hearrate;
                    mte.OxygenSaturation = oxygensaturation;
                    mte.Date = Convert.ToDateTime(date);
                    mte.Time = time;
                    mte.Patient = p;

                    context.MeasurementSet.Add(mte);
                    context.SaveChanges();

                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //Blood Pressure MAX
        public List<int> ViewBloodPressureMax(int fk_sns)
        {
            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListbloodpressureMax = new List<int>();

            var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns);

            foreach (var mte in m)
            {
                if (mte.BloodPressureMax != 0)
                {
                    ListbloodpressureMax.Add(Convert.ToInt32(mte.BloodPressureMax));
                }
            }

            return ListbloodpressureMax;

        }

        //Blood Pressure MIN 3 days
        public List<int> ViewBloodPressureMaxthreedays(int fk_sns, DateTime date)
        {
            int x = -3;

            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListbloodpressureMax = new List<int>();

            DateTime dateForButton = DateTime.Now.AddDays(x);


            do
            {
                var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns).Where(z => z.Date.Day == dateForButton.Day);
                foreach (var mte in m)
                {
                    if (mte.BloodPressureMax != 0)
                    {
                        ListbloodpressureMax.Add(Convert.ToInt32(mte.BloodPressureMax));
                    }
                }
                x = x + 1;
                dateForButton = DateTime.Now.AddDays(x);
            } while (x <= 0);

            return ListbloodpressureMax;
        }

        //Blood Pressure MIN
        public List<int> ViewBloodPressureMin(int fk_sns)
        {
            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListbloodpressureMin = new List<int>();

            var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns);

            foreach (var mte in m)
            {
                if (mte.BloodPressureMax != 0)
                {

                    ListbloodpressureMin.Add(Convert.ToInt32(mte.BloodPressureMin));
                }
            }

            return ListbloodpressureMin;
        }

        //Blood Pressure MIN 3 days
        public List<int> ViewBloodPressureMinthreedays(int fk_sns, DateTime date)
        {
            int x = -3;

            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListbloodpressureMin = new List<int>();

            DateTime dateForButton = DateTime.Now.AddDays(x);


            do
            {
                var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns).Where(z => z.Date.Day == dateForButton.Day);
                foreach (var mte in m)
                {
                    if (mte.BloodPressureMin != 0)
                    {
                        ListbloodpressureMin.Add(Convert.ToInt32(mte.BloodPressureMin));
                    }
                }
                x = x + 1;
                dateForButton = DateTime.Now.AddDays(x);
            } while (x <= 0);

            return ListbloodpressureMin;
        }

        ////Blood Pressure MAX Calendar
        //List<int> ViewBloodPressureMaxCalendar(int fk_sns, DateTime date, DateTime date2)
        //{
            
        //}

        ////Blood Pressure MIN Calendar
        //List<int> ViewBloodPressureMinCalendar(int fk_sns, DateTime date, DateTime date2)
        //{
            
        //}

        //HEART RATE
        public List<int> ViewHearRate(int fk_sns)
        {
            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListHeartRate = new List<int>();

            var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns);

            foreach (var mte in m)
            {
                if (mte.HeartRate != 0)
                {
                    ListHeartRate.Add(Convert.ToInt32(mte.HeartRate));
                }
            }

            return ListHeartRate;
        }

        //Heart Rate 3 days
        public List<int> ViewHearRatethreedays(int fk_sns, DateTime date)
        {
            int x = -3;

            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListHeartRate = new List<int>();

            DateTime dateForButton = DateTime.Now.AddDays(x);


            do
            {
                var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns).Where(z => z.Date.Day == dateForButton.Day);
                foreach (var mte in m)
                {
                    if (mte.HeartRate != 0)
                    {
                        ListHeartRate.Add(Convert.ToInt32(mte.HeartRate));
                    }
                }
                x = x + 1;
                dateForButton = DateTime.Now.AddDays(x);
            } while (x <= 0);

            return ListHeartRate;
        }

        ////Heart Rate Calendar
        //List<int> ViewHearRateCalendar(int fk_sns, DateTime date, DateTime date2)
        //{
            
        //}

        //OXYGEN SATURATION
        public List<int> ViewOxygenSaturation(int fk_sns)
        {
            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListOxygenSaturation = new List<int>();

            var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns);

            foreach (var mte in m)
            {
                if (mte.OxygenSaturation != 0)
                {
                    ListOxygenSaturation.Add(Convert.ToInt32(mte.OxygenSaturation));
                }
            }
            return ListOxygenSaturation;
        }


        //OxygenSaturation 3 days
        public List<int> ViewOxygenSaturationthreedays(int fk_sns, DateTime date)
        {
            int x = -3;

            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListOxygenSaturation = new List<int>();

            DateTime dateForButton = DateTime.Now.AddDays(x);

            
            do
            {
                var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns).Where(z => z.Date.Day == dateForButton.Day);
                foreach (var mte in m)
                {
                    if (mte.OxygenSaturation != 0)
                    {
                        ListOxygenSaturation.Add(Convert.ToInt32(mte.OxygenSaturation));
                    }
                }
                x = x + 1;
                dateForButton = DateTime.Now.AddDays(x);
            } while (x<=0);

            return ListOxygenSaturation;
        }

        //OxygenSaturation Calendar
        public List<int> ViewOxygenSaturationCalendar(int fk_sns, DateTime date, DateTime date2)
        {
            int x = 0;

            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListOxygenSaturation = new List<int>();

            do
            {
                
                var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns).Where(z => z.Date.Day == date.Day);
                foreach (var mte in m)
                {
                    if (mte.OxygenSaturation != 0)
                    {
                        ListOxygenSaturation.Add(Convert.ToInt32(mte.OxygenSaturation));
                    }
                }

                date = date.AddDays(1);
            } while (date.Day <= date2.Day);

            return ListOxygenSaturation;
        }
    }
}
