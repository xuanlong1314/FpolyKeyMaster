using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class LoaiSP
    {
        [Key]
        public Guid IdLoaiSP { get; set; } // Khóa chính cho loại sản phẩm

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenLoaiSP
        [Required(ErrorMessage = "không được để trống.")]
        public string TenLoaiSP { get; set; } // Tên loại sản phẩm

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public bool TrangThai { get; set; } // Trạng thái của loại sản phẩm (nullable)
        public virtual ICollection<SanPham> SanPhams { get; set; } // Khởi tạo danh sách
        // Có thể thêm các thuộc tính khác nếu cần thiết
        // Ví dụ: thuộc tính mô tả cho loại sản phẩm
    }
}
