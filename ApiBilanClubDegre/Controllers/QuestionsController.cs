using ApiBilanClubDegre.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiBilanClubDegre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly DataContext _context;
        public QuestionsController(DataContext context)
        {
                 _context= context;
        }
        [HttpGet]  
        public  async Task<ActionResult<List<Question>>> GetSuperQuestions()
        {
            return Ok(await _context.Questions.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Question>>> CreateQuestion(Question question)
        {
            _context.Questions.Add(question);
            await _context.SaveChangesAsync();


            return Ok(await _context.Questions.ToListAsync());
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Question>>> DeleteSuperQuestion(int id)
        {
            var dbQuestion = await _context.Questions.FindAsync(id);
            if (dbQuestion == null)
            {
                return BadRequest("Hero not Found");

            }
            _context.Questions.Remove(dbQuestion);
            await _context.SaveChangesAsync();

            return Ok(await _context.Questions.ToListAsync());
        }


    }
}
