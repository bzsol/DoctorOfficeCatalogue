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
    [Route("api/medication")]
    public class MedicationController : Controller
    {
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<Medication>> Get()
        {
            return Ok(MedicationRepo.GetMedications());
        }

        // POST
        [HttpPost]
        public ActionResult Post([FromBody] Medication med)
        {
            List<Medication> meds = MedicationRepo.GetMedications().ToList();
            med.ID = meds.Count < 1 ? 1 : meds.OrderByDescending(e => e.ID).FirstOrDefault().ID + 1;
            meds.Add(med);
            MedicationRepo.SavePatients(meds);
            return Ok();
        }
        // UPDATE
        [HttpPut]
        public ActionResult Put([FromBody] Medication med)
        {
            var meds = MedicationRepo.GetMedications().ToList();
            var selected = meds.FirstOrDefault(e => e.ID.Equals(med.ID));
            if (selected.Equals(null))
            {
                return NotFound();
            }
            else
            {
                selected.ID = med.ID;
                selected.MedicationName = med.MedicationName;
                selected.ActiveIngredient = med.ActiveIngredient;
                selected.MinimumAge = med.MinimumAge;
                selected.MaximumAge = med.MaximumAge;
                selected.Dosage = med.Dosage;
                selected.Packaging = med.Packaging;
                selected.Description = med.Description;
                MedicationRepo.SavePatients(meds);
                return Ok();
            }
        }
        // DELETE
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var meds = MedicationRepo.GetMedications().ToList();
            var selected = meds.FirstOrDefault(e => e.ID.Equals(id));
            if (selected.Equals(null))
            {
                return NotFound();
            }
            else
            {
                meds.Remove(selected);
                MedicationRepo.SavePatients(meds);
                return Ok();
            }

        }
    }
}
