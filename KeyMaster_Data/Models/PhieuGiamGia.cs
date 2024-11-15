using KeyMaster_Data.Validators;
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
    public class PhieuGiamGia
    {
        [Key]
        public Guid IdPhieuGiamGia { get; set; } // Khóa chính cho phiếu giảm giá

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenGiamGia
        [Required(ErrorMessage = "Tên phiếu giảm giá không được để trống.")]
        public string TenGiamGia { get; set; } // Tên giảm giá

        // Mức giảm giá dự kiến, sử dụng decimal cho các giá trị số
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Mức giảm giá phải lớn hơn hoặc bằng 0.")]
        public decimal MucGiamGia { get; set; } // Mức giảm giá

        [MaxLength(255)] // Giới hạn độ dài tối đa cho DieuKien
        public string? DieuKien { get; set; } // Điều kiện giảm giá (nullable)

        public DateTime NgayBatDau { get; set; } // Ngày bắt đầu giảm giá
        [Required]
        [CustomEndDateValidation("NgayBatDau", ErrorMessage = "Ngày kết thúc phải sau ngày bắt đầu.")]

        public DateTime NgayKetThuc { get; set; } // Ngày kết thúc giảm giá

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public bool TrangThai { get; set; } // Trạng thái phiếu giảm giá (nullable)

        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int SoLuong { get; set; } // Số lượng phiếu giảm giá

        [MaxLength(50)] // Giới hạn độ dài tối đa cho KieuGiamGia
        [ForeignKey("KieuGiamGia")] // Chỉ định khóa ngoại cho kiểu giảm giá
        public Guid IdKieuGiamGia { get; set; } // Khóa ngoại cho kiểu giảm giá

        // Tham chiếu tới KieuGiamGia
        public virtual KieuGiamGia KieuGiamGia { get; set; }
    }

}
