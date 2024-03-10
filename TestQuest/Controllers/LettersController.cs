using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestQuest.Context;
using TestQuest.Models;
using TestQuest.Models.ViewModels;

namespace TestQuest.Controllers
{
    [Route("api/Letters")]
    [ApiController]
    public class LettersController : ControllerBase
    {
        private readonly TestQuestContext _context;
        public LettersController(TestQuestContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllLetters")]
        public async Task<List<Letter>> GetAll() => await _context.Letters.ToListAsync();

        [HttpGet("GetLetter")]
        public async Task<Letter> GetLetter(int id) => await _context.Letters.FindAsync(id);        

        [HttpDelete("DeleteLetter")]
        public async Task<IActionResult> Delete(int id)
        {
            var letter = _context.Letters.Find(id);
            if (letter == null)
            {
                return BadRequest("Такого письма не существует");
            }

            try
            {
                _context.Letters.Remove(letter);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("SaveLetter")]
        public async Task<IActionResult> SaveLetter([FromBody]LetModel let)
        {
            Letter newLetter = new() { Header = let.Header, Text = let.Text,
                FromWhom = let.FromWhom, ToWhom = let.ToWhom, Date = DateTime.Now };

            try
            {
                _context.Letters.Add(newLetter);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
