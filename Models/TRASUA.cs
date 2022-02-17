namespace ASP.NET_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRASUA")]
    public partial class TRASUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRASUA()
        {
            CHITIETDONHANG = new HashSet<CHITIETDONHANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTS { get; set; }

        [Required]
        [StringLength(30)]
        public string TenTS { get; set; }

        [Required]
        [StringLength(50)]
        public string GiaBan { get; set; }

        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

        [Required]
        [StringLength(100)]
        public string Anh { get; set; }

        public int MaNL { get; set; }

        public int MaLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANG { get; set; }

        public virtual NGUYENLIEU NGUYENLIEU { get; set; }

        public virtual PHANLOAI PHANLOAI { get; set; }
    }
}
