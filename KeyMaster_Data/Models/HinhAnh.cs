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
    public class HinhAnh
    {
        [Key]
        public Guid IdHinhAnh { get; set; }

        // Tên tệp hình ảnh bắt buộc, không quá 255 ký tự
        [Required(ErrorMessage = "Tên tệp hình ảnh không được để trống.")]
        [MaxLength(255, ErrorMessage = "Tên tệp không được vượt quá 255 ký tự.")]
        public string FileName { get; set; }

        // Loại tệp hình ảnh bắt buộc (jpg, png, ...)
        [Required(ErrorMessage = "Loại tệp hình ảnh không được để trống.")]
        [MaxLength(50, ErrorMessage = "Loại tệp không được vượt quá 50 ký tự.")]
        public string FileType { get; set; }

        // Đường dẫn đến file hình ảnh được lưu trên server
        [Required(ErrorMessage = "Đường dẫn file không được để trống.")]
        [MaxLength(500, ErrorMessage = "Đường dẫn file không được vượt quá 500 ký tự.")]
        public string FilePath { get; set; }

        // Trạng thái hoạt động của hình ảnh
        [Required]
        public string TrangThai { get; set; }
        // Thuộc tính để liên kết nhiều sản phẩm với một hình ảnh
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
