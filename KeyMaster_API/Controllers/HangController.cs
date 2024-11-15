using KeyMaster_API.IRepositories;
using KeyMaster_Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace KeyMaster_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangController : ControllerBase
    {
        private readonly IHangRepos _hangRepos;
        public HangController(IHangRepos hangRepos)
        {
            _hangRepos = hangRepos; 
        }
        // GET: api/Hang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hang>>> GetHangs()
        {
            return await _hangRepos.GetAllHang();
        }

        // GET: api/Hang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hang>> GetHangs(Guid id)
        {
            return await _hangRepos.GetHangById(id);
        }

        // PUT: api/Hang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHang(Hang hang)
        {
            try
            {
                await _hangRepos.Update(hang);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

            await _hangRepos.SaveChanges();
            return Content("Success!");
        }


        // POST: api/Hang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Size>> PostHang(Hang hang)
        {
            try
            {
                await _hangRepos.Create(hang);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

            await _hangRepos.SaveChanges();

            return CreatedAtAction(nameof(GetHangs), new { id = hang.IdHang }, hang);
        }

        // DELETE: api/Hang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHang(Guid id)
        {
            try
            {
                await _hangRepos.Delete(id);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

            await _hangRepos.SaveChanges();

            return Content("Success!");
        }
    }
}
