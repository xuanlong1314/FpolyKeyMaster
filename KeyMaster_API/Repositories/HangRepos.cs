using KeyMaster_API.Data;
using KeyMaster_API.IRepositories;
using KeyMaster_Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KeyMaster_API.Repositories
{
    public class HangRepos : IHangRepos
    {
        private readonly AppDBcontexts _context;
        public HangRepos(AppDBcontexts hangRepos)
        {
            _context = hangRepos;
        }
        public async Task Create(Hang hang)
        {
            if (await GetHangById(hang.IdHang) != null) throw new DuplicateWaitObjectException($"Hãng : {hang.IdHang} đã tồn tại!");
            await _context.Hangs.AddAsync(hang);
        }

        public async Task Delete(Guid id)
        {
            var hang = await GetHangById(id);
            if (hang == null) throw new KeyNotFoundException("Hãng không tồn tại!");
            if (_context.SanPhamCTs.Where(p => p.IdHang == id).Any()) throw new Exception("Hãng đang được sử dụng!");
            _context.Hangs.Remove(hang);
        }

        public async Task<List<Hang>> GetAllHang()
        {
            return await _context.Hangs.ToListAsync();
        }

        public async Task<Hang> GetHangById(Guid id)
        {
            return await _context.Hangs.FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Hang hang)
        {
            if (await GetHangById(hang.IdHang) == null) throw new KeyNotFoundException("Hãng không tồn tại!");
            _context.Entry(hang).State = EntityState.Modified;
        }
    }
}
