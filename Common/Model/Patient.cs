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
                return $"{FirstName} {LastName}";
            }
        }

        public string HomeAddress { get; set; }

        public DateTime Intake { get; set; }

        // Health Insurance Card -> TAJ
        public string HIS { get; set; }

        public string Complaint { get; set; }

        public string Diagnose { get; set; }
    }
}
