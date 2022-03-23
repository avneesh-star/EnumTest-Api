using EnumTest.Data;
using EnumTest.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnumTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _context.Procedures.employeeSelectAllAsync();
            return Ok(data);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _context.Procedures.employeeSelectAsync(id);
            return Ok(data);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmpDto dto)
        {
            var result = await _context.Procedures.employeeInsertAsync(dto.Name, dto.Gender.ToString(), dto.City.ToString());
            return Ok(dto);
            
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] EmpDto dto)
        {
            var result = await _context.Procedures.employeeUpdateAsync(id,dto.Name,dto.Gender.ToString(),dto.City.ToString());
            var data = await _context.Procedures.employeeSelectAsync(id);
            return Ok(data);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _context.Procedures.employeeDeleteAsync(id);
            return Ok(data);
        }
    }
}
