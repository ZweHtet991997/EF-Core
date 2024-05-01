using EFCore_CRUD_Operation.DBServices;
using EFCore_CRUD_Operation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_CRUD_Operation.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDBService _service;

        public EmployeeController(EmployeeDBService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("api/employee")]
        public async Task<IActionResult> Create([FromBody] EmployeeModel model)
        {
            var dataResult = await _service.Create(model);
            return dataResult > 0 ? Ok() : BadRequest();
        }

        [HttpGet]
        [Route("api/employee")]
        public async Task<IActionResult> GetEmployee()
        {
            return Json(await _service.GetEmployee());
        }

        [HttpPut]
        [Route("api/employee")]
        public async Task<IActionResult> Update([FromBody] EmployeeModel model)
        {
            var dataResult = await _service.Update(model);
            return dataResult > 0 ? Ok() : BadRequest();
        }

        [HttpDelete]
        [Route("api/employee")]
        public async Task<IActionResult> Delete(int Id)
        {
            var dataResult = await _service.Delete(Id);
            return dataResult > 0 ? Ok() : BadRequest();
        }
    }
}
