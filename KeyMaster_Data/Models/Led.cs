using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class Led
    {
        [Key]
        public Guid IdLed { get; set; } // Khóa chính cho Led

        [Required(ErrorMessage = "Tên Led không được để trống.")]
        public string TenLed { get; set; } // Tên LED

        [MaxLength(100, ErrorMessage = "Trạng thái không được vượt quá 100 ký tự.")]
        public bool TrangThai { get; set; } // Trạng thái của LED (nullable)

        // Tham chiếu đến các sản phẩm chi tiết
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; } // Khởi tạo danh sách để tránh NullReferenceException

        // Bạn có thể thêm các thuộc tính khác ở đây nếu cần thiết
        // Ví dụ: thuộc tính mô tả chi tiết, màu sắc, công suất, v.v.
    }
}
