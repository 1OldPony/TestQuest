using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestQuest.Context;
using TestQuest.Models;

namespace TestQuest.Controllers
{
    [Route("api/Accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly TestQuestContext _context;
        public AccountsController(TestQuestContext context)
        {
            _context = context;
        }

        [HttpGet("GetEmpNames")]
        public async Task<List<string>> GetEmpNames()
        {
            var employes = await _context.Employes.ToListAsync();

            List<string> names = new();
            foreach (var emp in employes)
            {
                names.Add(emp.EmployeName);
            }

            return names;
        }

        [HttpGet("PassCheck")]
        public async Task<IActionResult> PassCheck(string name, string password)
        {
            var emp = await _context.Employes.FindAsync(name);
            if (emp == null)
            {
                return BadRequest("Такого сотрудника не существует");
            }

            if (emp.Password == password)
                return Ok();
            else
                return Unauthorized("Пароль не верный");
        }

        [HttpPost("CreateEmp")]
        public async Task<IActionResult> CreateEmp([FromBody]Employe emp)
        {
            try
            {
                _context.Employes.Add(emp);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return Ok();
        }
    }
}
