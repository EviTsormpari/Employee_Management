using Employee_Management.Models;
using Employee_Management.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Net; 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee_Management.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class YpalController : ControllerBase
    {
        private IYpal _YpalRepo;

        public YpalController(IYpal yp)
        {
            _YpalRepo = yp;
        }
        // GET: api/<YpalController>
        [HttpGet]
        public ActionResult<IEnumerable<Ypal>> GetAllYpal()
        {
            return _YpalRepo.GetAllYpal().ToList();
        }

        // GET api/<YpalController>/5
        [HttpGet("{id}")]
        public ActionResult<Ypal> GetYpal(string id)
        {
            var yp = _YpalRepo.GetYpal(id);
            if(yp == null ) { return NotFound(); } else { return yp; }
        }

        // POST api/<YpalController>
        [HttpPost]
        public ActionResult CreateYpal(Ypal yp)
        {
            var ypal = new Ypal();
            ypal.YpalID = yp.YpalID;
            ypal.YpalEmail = yp.YpalEmail;
            ypal.YpalName = yp.YpalName;

            _YpalRepo.CreateYpal(ypal);
            return Ok();
        }

        // PUT api/<YpalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<YpalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
