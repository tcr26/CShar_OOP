using StarCraft.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StarCraft.API.Controllers
{
    public class UnitController : ApiController
    {
        private List<UnitModel> units = new List<UnitModel>
        {
            new UnitModel {Id = 1, AttackPower = 5, AttackRange = 6, AttackRate = 1.7F, MovementSpeed = 1, Rank = "Private", ObjectName = "Marine",
                HitPoints = 45, ArmorPoints = 0, ConstructionTime = 20, Attributes = new List<string> {"Light", "Biological" }
            },
            new UnitModel {Id = 2, AttackPower = 5, AttackRange = 1, AttackRate = 1.8F, MovementSpeed = 1, Shield = 75, ShieldArmor = 0, Rank = "Zelka",
                ObjectName = "Zealot", HitPoints = 45, ArmorPoints = 0, ConstructionTime = 20, Attributes = new List<string> {"Light", "Biological" }
            },
            new UnitModel {Id = 3, AttackPower = 5, AttackRange = 1, AttackRate = 1, MovementSpeed = 2, Rank = "Predator", ArmorPoints = 0, HitPoints = 25, ConstructionTime = 20, ObjectName = "Zergling", HitPointsRegenerateRate = 2, Attributes = new List<string> { "Light", "Biological"} }
        };

        public IHttpActionResult Get(int id)
        {
            var unitFound = units.FirstOrDefault(x => x.Id == id);

            if (unitFound == null)
            {
                return NotFound();
            }

            return Ok(unitFound);
        }

        public IHttpActionResult Post([FromBody]UnitModel unitToAdd)
        {
            if (unitToAdd == null)
            {
                return NotFound();
            }

            units.Add(unitToAdd);

            return Ok();
        }

        public IHttpActionResult Put(int id, [FromBody]UnitModel unitToUpdate)
        {
            var unitId = units.FindIndex(x => x.Id == id);

            if (unitToUpdate == null)
            {
                return NotFound();
            }

            units.RemoveAt(unitId);

            units.Add(unitToUpdate);

            return Ok(unitToUpdate);
        }

        public IHttpActionResult Delete(int id)
        {
            var unitId = units.FirstOrDefault(x => x.Id == id);

            if (unitId == null)
            {
                return NotFound();
            }

            units.RemoveAll(x => x.Id == id);

            return Ok();
        }
    }
}