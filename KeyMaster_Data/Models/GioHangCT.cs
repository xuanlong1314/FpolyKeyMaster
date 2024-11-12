using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class GioHangCT
    {
        [Key]
        public Guid IdGioHangCT { get; set; }
        [ForeignKey("IdSanPhamCT")]
        public Guid IdSanPhamCT { get; set; }
        [ForeignKey("IdGioHang")]
        public Guid IdGioHang { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int SoLuong { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải lớn hơn hoặc bằng 0.")]
        public decimal Gia { get; set; }

        [NotMapped]
        public decimal TongTien => Gia * SoLuong;
        public virtual GioHang GioHang { get; set; }
        public virtual SanPhamCT SanPhamCT { get; set; }
    }

}
