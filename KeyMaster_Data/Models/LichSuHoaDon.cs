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
    public class LichSuHoaDon
    {
        [Key]
        public Guid IdLichSuHoaDon { get; set; } // Khóa chính cho lịch sử hóa đơn

        [ForeignKey("HoaDon")]
        public Guid IdHoaDon { get; set; } // Khóa ngoại liên kết với hóa đơn

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        [Required(ErrorMessage = "không được để trống.")]
        public string TrangThai { get; set; } // Trạng thái của hóa đơn

        public DateTime NgayDatHang { get; set; } // Ngày đặt hàng
        public DateTime NgayNhanHang { get; set; } // Ngày nhận hàng

        // Tham chiếu đến Hóa Đơn
        public virtual HoaDon HoaDon { get; set; }
    }
}
