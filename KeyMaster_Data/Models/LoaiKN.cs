using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Data.Models
{
    public class LoaiKN
    {
        [Key]
        public Guid IdLoaiKN { get; set; } // Khóa chính cho loại kết nối

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenLoaiKN
        [Required(ErrorMessage = "Tên màu không được để trống.")]
        public string TenLoaiKN { get; set; } // Tên loại kết nối

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public bool TrangThai { get; set; } // Trạng thái loại kết nối (nullable)

        // Danh sách sản phẩm chi tiết liên quan đến loại kết nối này
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; } = new List<SanPhamCT>(); // Khởi tạo danh sách
    }
}
