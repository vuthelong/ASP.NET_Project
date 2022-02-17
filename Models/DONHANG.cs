namespace ASP.NET_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            CHITIETDONHANG = new HashSet<CHITIETDONHANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDH { get; set; }

        public bool ThanhToan { get; set; }

        public bool TinhTrangGiaoHang { get; set; }

        public DateTime NgayDat { get; set; }

        public DateTime NgayGiao { get; set; }

        public int MaKH { get; set; }

        [Required]
        [StringLength(100)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
