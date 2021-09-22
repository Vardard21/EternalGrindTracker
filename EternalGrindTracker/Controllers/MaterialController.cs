
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EternalGrindTracker.Controllers
{
    public class MaterialController : ApiController
    {
        List<Material> Materials= new List<Material>();
        public MaterialController()
        {
                Materials.Add(new Material { Id = 0, Name="FlawedPrisms", Amount=23474, Left=48026,Element="NULL"});
                Materials.Add(new Material { Id = 1, Name = "LegendaryMerits", Amount = 205, Left = 193, Element = "NULL" });
                Materials.Add(new Material { Id = 2, Name = "WaterUrn", Amount = 411, Left = 189, Element = "Water" });

        }
        // GET: api/Material
        public List<Material> Get()
        {
            return Materials;
        }

        // GET: api/Material/5
        public Material Get(int id)
        {
            return Materials.Where(x=> x.Id==id).FirstOrDefault();
        }

        // POST: api/Material
        public void Post([FromBody]string value)
        {
        }
        // DELETE: api/Material/5
        public void Delete(int id)
        {
        }
    }
}
