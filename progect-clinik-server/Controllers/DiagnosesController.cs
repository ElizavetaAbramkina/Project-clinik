using Microsoft.AspNetCore.Mvc;
using top_clinik_dblayer;

namespace progect_clinik_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosesController : ControllerBase
    {
        private EntityGateway _db = new();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new
            {
                diagnoses = _db.GetDiagnoses(),
                status = "ok"
            });
        }
    }
}
