using KeyMaster_Data.Models;
using System.Drawing;

namespace KeyMaster_MVC.ViewModel
{
    public class HangViewModel
    {
        public Hang? NewHang { get; set; }
        public IEnumerable<Hang>? Hangs { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int RowsPerPage { get; set; }
    }
}
