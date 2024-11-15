using KeyMaster_Data.Models;

namespace KeyMaster_API.IRepositories
{
    public interface IHangRepos
    {
        Task<List<Hang>> GetAllHang();
        Task<Hang> GetHangById (Guid id);
        Task Create (Hang hang);    
        Task Update (Hang hang);
        Task Delete (Guid id);
        Task SaveChanges();
    }
}
