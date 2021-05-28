using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class Patient
    {
        public long ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }

        public string HomeAddress { get; set; }

        public string Intake { get; set; }

        // Health Insurance Card -> TAJ
        public string HIS { get; set; }

        public string Complaint { get; set; }

        public string Diagnose { get; set; }

        public DateTime DateOfBirth { get; set;}

        public int Age { get; set; }

        public static int CalculateAge(DateTime date)
        {         
            return ((DateTime.Now.Year - date.Year) - (DateTime.Now.DayOfYear < date.DayOfYear ? 1 : 0));
        }

        public string AgeGet {
            get {
                return $"{Age} éves";
            }
        }
        public string Allergy { get; set; }
        public List<string> Medications { get; set; }

        public string GetMedications
        {
            get
            {
                return string.Join("\n", Medications);
            }
        }
    }
}
