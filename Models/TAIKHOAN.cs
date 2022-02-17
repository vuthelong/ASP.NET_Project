namespace ASP.NET_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            KHACHHANG = new HashSet<KHACHHANG>();
            NHANVIEN = new HashSet<NHANVIEN>();
        }

        [Key]
        [StringLength(30)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(30)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(50)]
        public string HOTEN { get; set; }

        [Required]
        [StringLength(30)]
        public string PHANQUYEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIEN { get; set; }
    }
}
