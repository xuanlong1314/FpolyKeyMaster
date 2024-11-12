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
    public class SanPham
    {
        [Key]
        public Guid IdSanPham { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm không được để trống.")]
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        [ForeignKey("IdLoaiSP")]
        public Guid IdLoaiSP { get; set; }
        [ForeignKey("IdHinhAnh")]
        public Guid IdHinhAnh { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }
        public virtual HinhAnh HinhAnh { get; set; }
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }

}
