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
        public Patient ValidadePatient(int id)
        {

            ModelMedacContainer context = new ModelMedacContainer();
            Patient pt = context.PatientSet.Where(i => i.SNS == id).First();

            Patient p = new WCFMedacService.Patient();
            p.FirstName = pt.FirstName;
            p.LastName = pt.LastName;
            p.Phone = pt.Phone;
            p.Email = pt.Email;
            p.BirthDate = pt.BirthDate;
            p.CC_BI = pt.CC_BI;
            p.SNS = pt.SNS;
            p.Address = pt.Address;
            p.Gender = pt.Gender;
            p.Allergies = pt.Allergies;
            p.Height = pt.Height;
            p.OtherContact = pt.OtherContact;

            return p;
        }

        public void RegisterPatient(string firstname, string lastname, int phone,
            string email, DateTime birthdate, int cc_bi, int sns,
            string address, char gender, string allergies, double height,
            int othercontact)
        {
            ModelMedacContainer context = new ModelMedacContainer();
            Patient pt = new Patient();

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


        public void RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate,
    int oxygensaturation, string date, string time, int fk_sns)
        {
            ModelMedacContainer context = new ModelMedacContainer();
            Measurement mt = new Measurement();

            mt.Bloodpressuremax = bloodpressuremax;
            mt.Bloodpressuremin = bloodpressuremin;
            mt.Hearrate = hearrate;
            mt.Oxygensaturation = oxygensaturation;
            mt.Date1 = date;
            mt.Time1 = time;
            mt.Fk_sns = fk_sns;

            context.MeasurementSet.Add(mt);
            context.SaveChanges();

        }

    }

}
