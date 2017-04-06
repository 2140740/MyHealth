using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFMedacService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        PatientDC ValidadePatient(int id);

        [OperationContract]
        bool RegisterPatient(string firstname, string lastname, int phone,
            string email, DateTime birthdate, int cc_bi, int sns,
            string address, char gender, string allergies, double height,
            int othercontact,bool logged, string numberDoctor);

        [OperationContract]
        void UpdatePatient(Patient patient);

        [OperationContract]
        void UpdateLogged(int fk_sns);

        [OperationContract]
        void UpdateLogged2(int fk_sns);

        [OperationContract]
        bool RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate,
            int oxygensaturation, DateTime date, TimeSpan time, int fk_sns);
        [OperationContract]
        bool RegisterDoctor(string firstname, string medicalid);

        [OperationContract]
        DoctorDC ValidadeDoctor(string id);

        [OperationContract]
        List<int> ViewBloodPressureMax(int fk_sns);

        [OperationContract]
        List<int> ViewBloodPressureMin(int fk_sns);

        [OperationContract]
        List<int> ViewBloodPressureMaxthreedays(int fk_sns, DateTime date);

        [OperationContract]
        List<int> ViewBloodPressureMinthreedays(int fk_sns, DateTime date);

        [OperationContract]
        List<int> ViewBloodPressureMaxCalendar(int fk_sns, DateTime date, DateTime date2);

        [OperationContract]
        List<int> ViewBloodPressureMinCalendar(int fk_sns, DateTime date, DateTime date2);

        [OperationContract]
        List<int> ViewHearRate(int fk_sns);

        [OperationContract]
        List<int> ViewHearRatethreedays(int fk_sns, DateTime date);

        [OperationContract]
        List<int> ViewHeartRateCalendar(int fk_sns, DateTime date, DateTime date2);

        [OperationContract]
        List<int> ViewOxygenSaturation(int fk_sns);

        [OperationContract]
        List<int> ViewOxygenSaturationthreedays(int fk_sns, DateTime date);

        [OperationContract]
        List<int> ViewOxygenSaturationCalendar(int fk_sns, DateTime date, DateTime date2);

        [OperationContract]
        List<DateTime> ViewTime(int fk_sns);

        [OperationContract]
        List<string> ViewActivePatients();

        //[OperationContract]
        //List<Measurement> ViewMeasurements(int fk_sns);
    }

    [DataContract]
    public class PatientDC
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
        private bool logged;
        private string numberDoctor;

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

        [DataMember]
        public bool Logged { get; set; }


        [DataMember]
        public string NumberDoctor
        {
            get { return numberDoctor; }
            set { numberDoctor = value; }
        }
    }

    [DataContract]
    public class MeasurementDC
    {
        private int bloodpressuremin;
        private int bloodpressuremax;
        private int heartrate;
        private int oxygensaturation;
        private DateTime date;
        private TimeSpan time;
        private int fk_sns;

        [DataMember]
        public int Bloodpressuremin
        {
            get
            {
                return bloodpressuremin;
            }

            set
            {
                bloodpressuremin = value;
            }
        }

        [DataMember]
        public int Bloodpressuremax
        {
            get
            {
                return bloodpressuremax;
            }

            set
            {
                bloodpressuremax = value;
            }
        }

        [DataMember]
        public int Heartrate
        {
            get
            {
                return heartrate;
            }

            set
            {
                heartrate = value;
            }
        }

        [DataMember]
        public int Oxygensaturation
        {
            get
            {
                return oxygensaturation;
            }

            set
            {
                oxygensaturation = value;
            }
        }

        [DataMember]
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        [DataMember]
        public TimeSpan Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        [DataMember]
        public int Fk_sns
        {
            get
            {
                return fk_sns;
            }

            set
            {
                fk_sns = value;
            }
        }
    }

    [DataContract]
    public class DoctorDC
    {
        private string name;
        private string medicalid;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Medicalid
        {
            get { return medicalid; }
            set { medicalid = value; }
        }

    }
}

