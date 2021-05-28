using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class Medication
    {
        public long ID { get; set; }
        public string MedicationName { get; set; }
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public string ActiveIngredient { get; set; }
        public string Dosage { get; set; }
        public string Packaging { get; set; }
        public string Description { get; set; }
    }
}
