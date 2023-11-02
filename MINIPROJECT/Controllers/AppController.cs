using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace MINIPROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private readonly DataContextApp _context;

        public AppController(DataContextApp context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<App>>> Get()
        {
            return Ok(await _context.APP.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<App>> Get(int id)
        {
            var app = await _context.APP.FindAsync(id);
            if (app == null)
                return BadRequest("not found.");
            return Ok(app);
        }

        [HttpPost]
        public async Task<ActionResult<List<App>>> AddHero(App hero)
        {
            _context.APP.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.APP.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<App>>> UpdateHero(App request)
        {
            var db = await _context.APP.FindAsync(request.Id);
            if (db == null)
                return BadRequest("not found.");

            db.AP_REGNO = request.AP_REGNO;
            db.APPTYPEID = request.APPTYPEID;
            db.REGION = request.REGION;
            db.BRANCHID = request.BRANCHID;
            db.NIK_REFERENSI = request.NIK_REFERENSI;
            db.NPWP_REFERENSI = request.NPWP_REFERENSI;
            db.USERID = request.USERID;
            db.ACTIVE = request.ACTIVE;

            await _context.SaveChangesAsync();

            return Ok(await _context.APP.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<App>>> Delete(int id)
        {
            var dbHero = await _context.APP.FindAsync(id);
            if (dbHero == null)
                return BadRequest(" not found.");

            _context.APP.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.APP.ToListAsync());
        }

    }
}
