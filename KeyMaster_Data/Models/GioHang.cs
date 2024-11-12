using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;

namespace KeyMaster_Data.Models
{
    public class GioHang
    {
        [Key]
        public Guid IdGioHang { get; set; }

        [MaxLength(50, ErrorMessage = "Trạng thái không được vượt quá 50 ký tự.")]
        public string? TrangThai { get; set; }

        public DateTime? NgayTao { get; set; }

        public Guid IdNguoiDung { get; set; }

        [ForeignKey("IdNguoiDung")]
        public virtual NguoiDung? NguoiDung { get; set; }

        public virtual ICollection<GioHangCT> GioHangCTs { get; set; } 
    }
}
