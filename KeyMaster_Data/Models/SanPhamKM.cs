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
    public class SanPhamKM
    {
        [Key] // Khóa chính cho bảng sản phẩm khuyến mãi
        public Guid IdSanPhamKM { get; set; }

        [ForeignKey("IdSanPham")] // Chỉ định khóa ngoại cho sản phẩm
        public Guid IdSanPham { get; set; }

        [ForeignKey("IdKhuyenMai")] // Chỉ định khóa ngoại cho khuyến mãi
        public Guid IdKhuyenMai { get; set; }

        // Tham chiếu tới SanPham
        public virtual SanPham SanPham { get; set; }

        // Tham chiếu tới KhuyenMai
        public virtual KhuyenMai KhuyenMai { get; set; }
    }
}
