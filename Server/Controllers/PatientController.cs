using Common.Model;
using Microsoft.AspNetCore.Mvc;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{

    [ApiController]
    [Route("api/patient")]
    public class PatientController : Controller
    {
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<Patient>> Get() {
            return Ok(PatientRepo.GetPatients());
        }

        // POST
        [HttpPost]
        public ActionResult Post([FromBody] Patient patient) {
            List<Patient> patients = PatientRepo.GetPatients().ToList();
            patient.ID = patients.Count < 1 ? 1 : patients.OrderByDescending(e => e.ID).FirstOrDefault().ID + 1;
            patients.Add(patient);
            PatientRepo.SavePatients(patients);
            return Ok();
        }
        // UPDATE
        [HttpPut]
        public ActionResult Put([FromBody] Patient patient)
        {
            var patients = PatientRepo.GetPatients().ToList();
            var ChoosenOne = patients.FirstOrDefault(e => e.ID.Equals(patient.ID));
            if (ChoosenOne.Equals(null))
            {
                return NotFound();
            }
            else
            {

                ChoosenOne.FirstName = patient.FirstName;
                ChoosenOne.LastName = patient.LastName;
                ChoosenOne.HomeAddress = patient.HomeAddress;
                ChoosenOne.HIS = patient.HIS;
                ChoosenOne.Intake = patient.Intake;
                ChoosenOne.Complaint = patient.Complaint;
                ChoosenOne.Diagnose = patient.Diagnose;
                PatientRepo.SavePatients(patients);
                return Ok();
            }
        }
        // DELETE
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var patients = PatientRepo.GetPatients().ToList();
            var ChoosenOne = patients.FirstOrDefault(e => e.ID.Equals(id));
            if (ChoosenOne.Equals(null))
            {
                return NotFound();
            }
            else
            {
                patients.Remove(ChoosenOne);
                PatientRepo.SavePatients(patients);
                return Ok();
            }

        }


    }
}
