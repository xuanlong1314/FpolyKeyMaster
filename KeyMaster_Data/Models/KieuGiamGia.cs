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
    public class KieuGiamGia
    {
        [Key]
        public Guid IdKieuGiamGia { get; set; } // Khóa chính cho kiểu giảm giá
        // Giới hạn độ dài tối đa cho TenKieuGiamGia
        [Required(ErrorMessage = "Tên kiểu giảm giá không được để trống.")]
        public string TenKieuGiamGia { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Số tiền giảm giá phải lớn hơn hoặc bằng 0.")]
        // Giá trị giảm giá (có thể là số dương)
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GiaTriGiamGia { get; set; } // Giá trị giảm giá

        // Danh sách các phiếu giảm giá liên quan đến kiểu giảm giá này
        public virtual ICollection<PhieuGiamGia> PhieuGiamGias { get; set; }
    }
}
