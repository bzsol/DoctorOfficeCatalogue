using Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Assistant.DataProvider
{
    public class MedicationDataProvider
    {
        private const string server = "http://localhost:5000/api/medication";
        public static IEnumerable<Medication> GetMedications()
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
                    var meds = JsonConvert.DeserializeObject<IEnumerable<Medication>>(httpdata);
                    return meds;
                }

            }
        }

        public static void CreateMedication(Medication med)
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

        public static void UpdateMedication(Medication med)
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
