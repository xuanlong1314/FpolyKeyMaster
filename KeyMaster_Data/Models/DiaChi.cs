using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;

namespace KeyMaster_Data.Models
{
    public class DiaChi
    {
        [Key]
        public Guid IdDiaChi { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống.")]
        public string DiaChiCT { get; set; }
        [Required(ErrorMessage = "Tên người nhận không được để trống.")]
        public string TenNguoiNhan { get; set; }
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string SDT { get; set; }
        public string TrangThai { get; set; }
        [Required(ErrorMessage = "Tỉnh không được để trống.")]
        public string Tinh { get; set; }
        [Required(ErrorMessage = "Huyện không được để trống.")]
        public string Huyen { get; set; }
        [Required(ErrorMessage = "Xã không được để trống.")]
        public string Xa { get; set; }
        [ForeignKey("IdNguoiDung")]
        public Guid IdNguoiDung { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }

}
