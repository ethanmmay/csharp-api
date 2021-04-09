
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using learnAPIs.Models;
using learnAPIs.db;

namespace learnAPIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Dog>> Get()
        {
            try
            {
                return Ok(FakeDB.Dogs);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]

        public ActionResult<Dog> Create([FromBody] Dog newDog)
        {
            try
            {
                FakeDB.Dogs.Add(newDog);
                return newDog;
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}