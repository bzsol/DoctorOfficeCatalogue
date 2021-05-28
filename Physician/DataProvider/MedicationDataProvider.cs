using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Physician.DataProvider
{
    public class MedicationDataProvider
    {
        private const string server = "http://localhost:5000/api/medication";
        public static IEnumerable<Common.Model.Medication> GetMedications()
        {

            using (var client = new HttpClient())
            {
                var respone = client.GetAsync(server).Result;

                if (!respone.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(respone.StatusCode.ToString());
                }
                else
                {
                    var httpdata = client.GetStringAsync(server).Result;
                    var meds = JsonConvert.DeserializeObject<IEnumerable<Common.Model.Medication>>(httpdata);
                    return meds;
                }

            }
        }

        public static void CreateMedication(Common.Model.Medication med)
        {
            using (var client = new HttpClient())
            {
                var httpdata = JsonConvert.SerializeObject(med);
                var httppacket = new StringContent(httpdata, Encoding.UTF8, "application/json");

                var response = client.PostAsync(server, httppacket).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateMedication(Common.Model.Medication med)
        {
            using (var client = new HttpClient())
            {
                var httpdata = JsonConvert.SerializeObject(med);
                var httppacket = new StringContent(httpdata, Encoding.UTF8, "application/json");

                var response = client.PutAsync(server, httppacket).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void DeleteMedication(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(server + "/" + id).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
