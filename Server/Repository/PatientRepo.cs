using Common.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server.Repository
{
    public class PatientRepo
    {
        private const string datafile = "patients.json";

        // Deserialize Patient and Get the objects in the file

        public static IEnumerable<Patient> GetPatients() {
            if (File.Exists(datafile))
            {
                return JsonSerializer.Deserialize<IEnumerable<Patient>>(File.ReadAllText(datafile));
            }
            else {
                return new List<Patient>();
            }
        
        }

        // Serialize the objects to JSON to readable to other programs too
        public static void SavePatients(IEnumerable<Patient> patients) {
            File.WriteAllText(datafile, JsonSerializer.Serialize(patients));
        }

    }
}
