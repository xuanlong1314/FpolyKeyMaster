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
    public class SanPhamCT
    {
        [Key]
        public Guid IdSPChiTiet { get; set; }
        [ForeignKey("IdSanPham")]
        public Guid IdSanPham { get; set; }
        [ForeignKey("IdMau")]
        public Guid IdMau { get; set; }
        [ForeignKey("IdLed")]
        public Guid IdLed { get; set; }
        [ForeignKey("IdLoaiKN")]
        public Guid IdLoaiKN { get; set; }
        [ForeignKey("IdKeycap")]
        public Guid IdKeycap { get; set; }
        [ForeignKey("IdHang")]
        public Guid IdHang { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int SoLuong { get; set; }
        public string ThongTinThem { get; set; }

        public virtual SanPham SanPham { get; set; }
        public virtual Mau Mau { get; set; }
        public virtual Led Led { get; set; }
        public virtual LoaiKN LoaiKN { get; set; }
        public virtual KeyCap KeyCap { get; set; }
        public virtual Hang Hang { get; set; }
    }


}
