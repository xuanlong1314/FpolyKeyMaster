using KeyMaster_Data.Models;
using System.Drawing;

namespace KeyMaster_MVC.IService
{
    public interface IHangService
    {
        Task<IEnumerable<Hang>?> GetAllHangs();
        Task<Hang?> GetHangById(Guid id);
        Task Create(Hang hang);
        Task Update(Hang hang);
        Task Delete(Guid id);
    }
}
