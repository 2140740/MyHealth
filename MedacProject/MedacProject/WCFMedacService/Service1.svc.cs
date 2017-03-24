using System;
using System.Collections.Generic;
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
            else { 
               
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


        public bool RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate,
    int oxygensaturation, DateTime date, TimeSpan time, int fk_sns)
        {
            Measurement mte = new Measurement();

            try
            {
                ModelMedacContainer context = new ModelMedacContainer();
                

                Patient p = context.PatientSet.FirstOrDefault(i => i.SNS == fk_sns);

                if (p!= null) { 
                    mte.BloodPressureMax = bloodpressuremax;
                    mte.BloodPressureMin = bloodpressuremin;
                    mte.HeartRate = hearrate;
                    mte.OxygenSaturation = oxygensaturation;
                    mte.Date = Convert.ToDateTime(date);
                    mte.Time = Convert.ToString(time);
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

    }

}
