using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceHealth : IServiceHealth
    {
        public Patient ValidadePatient(int id)
        {

            ModelMedacContainer context = new ModelMedacContainer();
            Patient pt = context.PatientSet.Where(i => i.SNS == id).First();

            Patient p = new WcfServiceLayer.Patient();
            p.Firstname = pt.Firstname;
            p.Lastname = pt.Lastname;
            p.Phone = pt.Phone;
            p.Email = pt.Email;
            p.Birthdate = pt.Birthdate;
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

            pt.Firstname = firstname;
            pt.Lastname = lastname;
            pt.Phone = phone;
            pt.Email = email;
            pt.Birthdate = birthdate;
            pt.CC_BI = cc_bi.ToString();
            pt.SNS = sns;
            pt.Address = address;
            pt.Gender = gender.ToString();
            pt.Allergies = allergies;
            pt.Height = height;
            pt.OtherContact = othercontact;

            context.PatientSet.Add(pt);
            context.SaveChanges();
        }
    }

}
