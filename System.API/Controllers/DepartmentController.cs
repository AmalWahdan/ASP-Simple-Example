using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.BL;

namespace System.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDeptManager _departmentManager;

        public DepartmentController(IDeptManager departmentManager)
        {
            _departmentManager = departmentManager;
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _departmentManager.GetDepartmentById(id);
            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }


    }
}
