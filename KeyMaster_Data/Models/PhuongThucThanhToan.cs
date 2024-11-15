using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class PhuongThucThanhToan
    {
        [Key]
        public Guid IdPhuongThucThanhToan { get; set; } // Khóa chính cho phương thức thanh toán

        [MaxLength(100, ErrorMessage = "Tên phương thức thanh toán không được vượt quá 100 ký tự.")]
        [Required(ErrorMessage = "Tên phương thức thanh toán không được để trống.")]
        public string TenPhuongThucThanhToan { get; set; } // Tên phương thức thanh toán

        [MaxLength(50, ErrorMessage = "Trạng thái không được vượt quá 50 ký tự.")]
        public bool TrangThai { get; set; } // Trạng thái của phương thức thanh toán (nullable)

        // Danh sách các hóa đơn liên quan đến phương thức thanh toán này
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>(); // Khởi tạo danh sách cho hóa đơn
    }
}
