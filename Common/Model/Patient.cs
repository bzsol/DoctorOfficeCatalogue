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

        public string AgeGet {
            get {
                var age = ((DateTime.Now.Year - DateOfBirth.Year) - (DateTime.Now.DayOfYear < DateOfBirth.Year ? 1 : 0)).ToString();
                return $"{age} éves";
            }
        }
        public string Allergy { get; set; }
    }
}
