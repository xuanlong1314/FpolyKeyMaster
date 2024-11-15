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
    public class KhuyenMai
    {
        [Key]
        public Guid IdKhuyenMai { get; set; } // Khóa chính cho khuyến mãi

        [MaxLength(100, ErrorMessage = "Tên khuyến mãi không được vượt quá 100 ký tự.")]
        [Required(ErrorMessage = "Tên khuyến mãi không được để trống.")]
        public string TenKhuyenMai { get; set; } // Tên khuyến mãi

        // Mức giảm giá dự kiến có thể là số thập phân
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Mức giảm giá phải lớn hơn hoặc bằng 0.")]
        public decimal? MucGiamGia { get; set; } // Mức giảm giá (nullable)

        [Required(ErrorMessage = "Ngày bắt đầu không được để trống.")]
        public DateTime? NgayBatDau { get; set; } // Ngày bắt đầu khuyến mãi (nullable)

        [Required(ErrorMessage = "Ngày kết thúc không được để trống.")]
        [CustomEndDateValidation("NgayBatDau", ErrorMessage = "Ngày kết thúc phải sau ngày bắt đầu.")]
        public DateTime? NgayKetThuc { get; set; } // Ngày kết thúc khuyến mãi (nullable)

        [MaxLength(50, ErrorMessage = "Trạng thái không được vượt quá 50 ký tự.")]
        public bool TrangThai { get; set; } // Trạng thái (nullable)

        // Danh sách sản phẩm khuyến mãi liên quan đến khuyến mãi này
        public virtual ICollection<SanPhamKM> SanPhamKMs { get; set; } = new List<SanPhamKM>(); // Khởi tạo danh sách
    }
}
