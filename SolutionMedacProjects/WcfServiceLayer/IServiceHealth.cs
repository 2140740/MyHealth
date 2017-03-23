using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceHealth
    {

        [OperationContract]
        Patient ValidadePatient(int id);

        [OperationContract]
        void RegisterPatient(string firstname, string lastname, int phone,
            string email, DateTime birthdate, int cc_bi, int sns,
            string address, char gender, string allergies, double height,
            int othercontact);
        
        [OperationContract]
        void RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate,
            int oxygensaturation, string date, string time, int fk_sns);
            
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.


    [DataContract]
    public class Paciente
    {
        private string firstname;
        private string lastname;
        private int phone;
        private string email;
        private DateTime birthdate;
        private int cc_bi;
        private int sns;
        private string address;
        private char gender;
        private string allergies;
        private double height;
        private int othercontact;

        [DataMember]
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        [DataMember]
        public int PatientID { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }

        [DataMember]
        public string Lastname
        {
            get { return lastname; }

            set { lastname = value; }
        }

        [DataMember]
        public int Phone
        {
            get { return phone; }

            set { phone = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }

            set { email = value; }
        }

        [DataMember]
        public DateTime Birthdate
        {
            get { return birthdate; }

            set { birthdate = value; }
        }

        [DataMember]
        public int Cc_bi
        {
            get { return cc_bi; }

            set { cc_bi = value; }
        }

        [DataMember]
        public int Sns
        {
            get { return sns; }

            set { sns = value; }
        }

        [DataMember]
        public string Address
        {
            get { return address; }

            set { address = value; }
        }

        [DataMember]
        public char Gender
        {
            get { return gender; }

            set { gender = value; }
        }

        [DataMember]
        public string Allergies
        {
            get { return allergies; }

            set { allergies = value; }
        }

        [DataMember]
        public double Height
        {
            get { return height; }

            set { height = value; }
        }

        [DataMember]
        public int Othercontact
        {
            get { return othercontact; }

            set { othercontact = value; }
        }
    }

    [DataContract]
    public partial class Measurement
    {
        private int bloodpressuremin;
        private int bloodpressuremax;
        private int hearrate;
        private int oxygensaturation;
        private string date;
        private string time;
        private int fk_sns;

        public int Bloodpressuremin
        {
            get { return bloodpressuremin; }

            set { bloodpressuremin = value; }
        }

        public int Bloodpressuremax
        {
            get { return bloodpressuremax; }

            set { bloodpressuremax = value; }
        }

        public int Hearrate
        {
            get { return hearrate; }

            set { hearrate = value; }
        }

        public int Oxygensaturation
        {
            get { return oxygensaturation; }

            set { oxygensaturation = value; }
        }

        public string Date1
        {
            get { return date; }

            set { date = value; }
        }

        public string Time1
        {
            get { return time; }

            set { time = value; }
        }

        public int Fk_sns
        {
            get { return fk_sns; }

            set { fk_sns = value; }
        }

    }


}
        
