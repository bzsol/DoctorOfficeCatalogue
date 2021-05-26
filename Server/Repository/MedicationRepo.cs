using Common.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server.Repository
{
    public class MedicationRepo
    {
        private const string datafile = "medications.json";

        // Deserialize Patient and Get the objects in the file
        public static IEnumerable<Medication> GetMedications()
        {
            if (File.Exists(datafile) && new FileInfo(datafile).Length > 0)
            {
                return JsonSerializer.Deserialize<IEnumerable<Medication>>(File.ReadAllText(datafile));
            }
            else
            {
                return new List<Medication>();
            }

        }

        // Serialize the objects to JSON to readable to other programs too
        public static void SavePatients(IEnumerable<Medication> meds)
        {
            File.WriteAllText(datafile, JsonSerializer.Serialize(meds));
        }
    }
}
