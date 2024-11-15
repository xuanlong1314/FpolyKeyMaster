using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class Mau
    {
        [Key]
        public Guid IdMau { get; set; } // Khóa chính cho màu

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenMau
        [Required(ErrorMessage = "Tên màu không được để trống.")] // Đảm bảo rằng TenMau luôn được cung cấp
        public string TenMau { get; set; } // Tên màu

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public bool TrangThai { get; set; } // Trạng thái của màu (nullable)

        // Danh sách các sản phẩm chi tiết liên quan đến màu này
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; } // Khởi tạo danh sách

        // Bạn có thể thêm các thuộc tính khác nếu cần thiết
        // Ví dụ: thuộc tính mô tả chi tiết cho màu
    }
}
