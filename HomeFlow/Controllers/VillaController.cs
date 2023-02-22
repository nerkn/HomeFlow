using Microsoft.AspNetCore.Mvc;


namespace HomeFlow.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class VillaController : ControllerBase
    {
        private List<Models.Villa> villas = new List<Models.Villa> {
                new Models.Villa("Fevzi", "Uzak", "Rent" ),
                new Models.Villa("Batikent", "Ankara", "Sale")
            };
        [HttpGet("All")]
        public ActionResult<List<Models.Villa>> GetAll()
        {
            return Ok(villas);
        }
        [HttpGet("id")]
        public ActionResult<Models.Villa> Get(int id)
        {
            Models.Villa myVilly = new ("Cali", "Guzel evdi", "Rent");

            return Ok(myVilly);
        }

    }
}
