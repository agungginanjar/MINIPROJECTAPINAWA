using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace MINIPROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScuserController : ControllerBase
    {
        private readonly DataContextScuser _context;

        public ScuserController(DataContextScuser context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SCUSER>>> Get()
        {
            return Ok(await _context.SCUSER.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SCUSER>> Get(int id)
        {
            var SCUSER = await _context.SCUSER.FindAsync(id);
            if (SCUSER == null)
                return BadRequest("Hero not found.");
            return Ok(SCUSER);
        }

        [HttpPost]
        public async Task<ActionResult<List<SCUSER>>> AddHero(SCUSER hero)
        {
            _context.SCUSER.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SCUSER.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<SCUSER>>> UpdateHero(SCUSER request)
        {
            var db = await _context.SCUSER.FindAsync(request.Id);
            if (db == null)
                return BadRequest("Hero not found.");

            db.USERID = request.USERID;
            db.GROUPID = request.GROUPID;
            db.SU_FULLNAME = request.SU_FULLNAME;
            db.SU_ACTIVE = request.SU_ACTIVE;

            await _context.SaveChangesAsync();

            return Ok(await _context.SCUSER.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SCUSER>>> Delete(int id)
        {
            var dbHero = await _context.SCUSER.FindAsync(id);
            if (dbHero == null)
                return BadRequest("Hero not found.");

            _context.SCUSER.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SCUSER.ToListAsync());
        }

    }
}
