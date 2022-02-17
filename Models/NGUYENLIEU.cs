namespace ASP.NET_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUYENLIEU")]
    public partial class NGUYENLIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUYENLIEU()
        {
            TRASUA = new HashSet<TRASUA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNL { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNL { get; set; }

        public int MaNCC { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRASUA> TRASUA { get; set; }
    }
}
