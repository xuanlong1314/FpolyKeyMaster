using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class VaiTro
    {
        [Key]
        public Guid IDVaiTro { get; set; }
        [Required(ErrorMessage = "Tên vai trò không được để trống.")]
        public string TenVaiTro { get; set; }

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }

        // Bạn có thể thêm các thuộc tính khác nếu cần thiết
        // Ví dụ: thuộc tính mô tả chi tiết về vai trò, quyền hạn, v.v.
    }
}
