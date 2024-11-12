using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class Hang
    {
        [Key]
        public Guid IdHang { get; set; }
        [Required(ErrorMessage = "Tên hãng không được để trống.")]
        public string TenHang { get; set; }
        public string TrangThai { get; set; }

        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }
}
