namespace ASP.NET_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Required]
        [StringLength(30)]
        public string TenNV { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(30)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(20)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string STK { get; set; }

        public int Luong { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
