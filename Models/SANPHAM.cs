namespace ASP.NET_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETDONHANG = new HashSet<CHITIETDONHANG>();
        }

        [Key]
        [StringLength(5)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(30)]
        public string TenSP { get; set; }

        [Required]
        [StringLength(50)]
        public string GiaBan { get; set; }

        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

        [Required]
        [StringLength(100)]
        public string Anh { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNL { get; set; }

        [Required]
        [StringLength(5)]
        public string MaLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANG { get; set; }

        public virtual NGUYENLIEU NGUYENLIEU { get; set; }

        public virtual PHANLOAI PHANLOAI { get; set; }
    }
}
