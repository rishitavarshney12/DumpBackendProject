using Employee.Domain.Contracts;
using Employee.Domain.Model.Dtos;
using Employee.Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpService _empService;

        public EmpController(IEmpService empService)
        {
            _empService = empService;
        }
        
        [HttpGet]
        [Route("GetBy")]

        public async Task<ActionResult<List<EmpTableDto>>> GetEmp(int id)
        {
            try
            {
                List<EmpTableDto> empTable = await _empService.GetBy(id);
                return empTable;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("GetAll")]

        public async Task<ActionResult<List<EmpTableDto>>> GetAllEmp()
        {
            try
            {
                List<EmpTableDto> empTable = await _empService.GetAll();
                return empTable;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        [Route("Save")]
        public async Task<ActionResult<short>> SaveEmp([FromBody] EmpTableDto empTableDto)
        {
            try
            {
                short empId = await _empService.Save(empTableDto);
                return empId;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
