using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace MINIPROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CUSTDEBITURController : ControllerBase
    {
        private readonly DataContextCUSTDEBITUR _context;

        public CUSTDEBITURController(DataContextCUSTDEBITUR context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<CUSTDEBITUR>>> Get()
        {
            return Ok(await _context.CUSTDEBITUR.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CUSTDEBITUR>> Get(int id)
        {
            var CUSTDEBITUR = await _context.CUSTDEBITUR.FindAsync(id);
            if (CUSTDEBITUR == null)
                return BadRequest("Hero not found.");
            return Ok(CUSTDEBITUR);
        }

        [HttpPost]
        public async Task<ActionResult<List<CUSTDEBITUR>>> AddHero(CUSTDEBITUR hero)
        {
            _context.CUSTDEBITUR.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.CUSTDEBITUR.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<CUSTDEBITUR>>> UpdateHero(CUSTDEBITUR request)
        {
            var dt = await _context.CUSTDEBITUR.FindAsync(request.Id);
            if (dt == null)
                return BadRequest("Hero not found.");

            dt.AP_REGNO = request.AP_REGNO;
            dt.CU_NAME = request.CU_NAME;
            dt.CU_CIF = request.CU_CIF;
            dt.CU_DOB = request.CU_DOB;
            dt.CU_POB = request.CU_POB;
            dt.CU_KTP_NO = request.CU_KTP_NO;
            dt.CU_HP = request.CU_HP;
            dt.CU_EMAIL = request.CU_EMAIL;
            dt.CU_NPWP = request.CU_NPWP;

            await _context.SaveChangesAsync();

            return Ok(await _context.CUSTDEBITUR.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<CUSTDEBITUR>>> Delete(int id)
        {
            var dr = await _context.CUSTDEBITUR.FindAsync(id);
            if (dr == null)
                return BadRequest("Hero not found.");

            _context.CUSTDEBITUR.Remove(dr);
            await _context.SaveChangesAsync();

            return Ok(await _context.CUSTDEBITUR.ToListAsync());
        }

    }
}
