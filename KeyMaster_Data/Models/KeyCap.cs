using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class KeyCap
    {
        [Key]
        public Guid IdKeyCap { get; set; } // Khóa chính cho KeyCap

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenKeyCap
        public string TenKeyCap { get; set; } // Tên KeyCap

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public bool? TrangThai { get; set; } // Nullable nếu trạng thái không bắt buộc

        // Danh sách sản phẩm chi tiết liên quan đến KeyCap này
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }

}
