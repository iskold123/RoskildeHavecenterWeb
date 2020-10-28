using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanteShopService.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlanteShopService.Controllers
{
    [Route("api/localItems")]
    [ApiController]
    public class PlanterController : ControllerBase
    {
        private static List<Plante> _data = new List<Plante>()
        {
            new Plante(1, "Rose", "Albertine", 400, 199),
            new Plante(2, "Busk", "Aronia", 200, 169),
            new Plante(3, "FrugtOgBaer", "AromaÆble", 350, 399),
            new Plante(4, "Rhododendron", "Astrid", 40, 269),
            new Plante(5, "Rose", "The dark lady", 100, 199)
        };

        // GET: api/<PlanterController>
        [HttpGet]
        public IEnumerable<Plante> GetAllPlanter()
        {
            return _data;
        }

        // GET api/<PlanterController>/5
        [HttpGet]
        [Route("{id}")]
        public Plante GetPlanteById(int id)
        {
            return _data.Find(p => p.PlanteId == id);
        }

        // GET api/<PlanterController>/5
        //[HttpGet]
        //[Route(("Type{type}"))]
        //public IEnumerable<Plante> GetPlanteByType(string type)
        //{
        //    return _data.Find();
        //}

        // POST api/<PlanterController>
        [HttpPost]
        public void Post([FromBody] Plante value)
        {
            _data.Add(value);
        }
    }
}
