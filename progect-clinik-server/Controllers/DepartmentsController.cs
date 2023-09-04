using Microsoft.AspNetCore.Mvc;
using progect_clinik_models.Models;
using top_clinik_dblayer;

namespace progect_clinik_server.Controllers
{
    /// <summary>
    /// Represents all actions with Departments
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsControllers : ControllerBase
    {
        private EntityGateway _db = new();

        /// <summary>
        /// Returns shorten info about all departments: id and name
        /// </summary>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new
            {
                departments = _db.GetDepartments().Select(x => new
                {
                    x.Id,
                    x.Name
                }),
                status = "ok"
            });
        }

        /// <summary>
        /// return full info about department
        /// </summary>
        [HttpGet("{department_id:guid}")]
        public IActionResult GetById(Guid department_id)
        {
            var potentialDepartment = _db.GetDepartments(x => x.Id == department_id).FirstOrDefault();   

            if (potentialDepartment is null)
                return NotFound(new
                {
                    status = "fail", 
                    message = $"Department with {department_id} id is not found"
                });

            return Ok(new
            {
                department = potentialDepartment,
                status = "ok"
            });
        }

        /// <summary>
        /// deletes department by id
        /// </summary>
        [HttpDelete]
        public IActionResult DeleteById(Guid department_id)
        {
            var potentialDepartment = _db.GetDepartments(x => x.Id == department_id).FirstOrDefault();

            if (potentialDepartment is null)
                return NotFound(new
                {
                    status = "fail",
                    message = $"Department with {department_id} id is not found"
                });

            _db.Delete(potentialDepartment);
            return Ok(new
            {
                status = "ok"
            });
        }

        /// <summary>
        /// add or update department entity
        /// </summary>
        /// <param name="department">Name is mandatory</param>
        [HttpPost]
        public IActionResult AddOrUpdate([FromBody] Department department)
        {
            _db.AddOrUpdate(department);
            return Ok(new
            {
                status = "ok",
                id = department.Id
            });
        }

    }
}
