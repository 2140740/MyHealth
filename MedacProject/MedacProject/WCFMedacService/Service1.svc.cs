using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdatePatient(string firstname, string lastname, int phone,
            string email, DateTime birthdate, int cc_bi, int sns,
            string address, char gender, string allergies, double height,
            int othercontact)
        {
            Patient pt = new Patient();

            ModelMedacContainer context = new ModelMedacContainer();

            pt = context.PatientSet.FirstOrDefault(i => i.SNS == sns);

            try
            {

                if (pt != null)
                {
                    context.PatientSet.Remove(pt);
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
            catch (Exception e)
            {
                return false;
            }
            return true;
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
            catch (Exception e)
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

        //HEART RATE
        public List<int> ViewHearRate(int fk_sns)
        {
            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListHeartRate = new List<int>();

            var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns);

            foreach (var mte in m)
            {
                if (mte.BloodPressureMax != 0)
                {
                    ListHeartRate.Add(Convert.ToInt32(mte.HeartRate));
                }
            }

            return ListHeartRate;
        }

        //OXYGEN SATURATION
        public List<int> ViewOxygenSaturation(int fk_sns)
        {
            ModelMedacContainer context = new ModelMedacContainer();

            List<int> ListOxygenSaturation = new List<int>();

            var m = context.MeasurementSet.Where(i => i.Patient.SNS == fk_sns);

            foreach (var mte in m)
            {
                if (mte.BloodPressureMax != 0)
                {
                    ListOxygenSaturation.Add(Convert.ToInt32(mte.OxygenSaturation));
                }
            }

            return ListOxygenSaturation;
        }
    }
}
