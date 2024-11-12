using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class NguoiDung
    {
        [Key]
        public Guid IDNguoiDung { get; set; }
        [Required(ErrorMessage = "Tên người dùng không được để trống.")]
        public string TenNguoiDung { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng.")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự.")]
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        [StringLength(10, ErrorMessage = "Số điện thoại phải có 10 ký tự.")]
        public string SoDienThoai { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(12, ErrorMessage = "CCCD phải có 12 ký tự.")]
        public string CCCD { get; set; }
        public string Avatar { get; set; }
        [ForeignKey("VaiTro")]
        public Guid IDVaiTro { get; set; }

        public virtual VaiTro VaiTro { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
