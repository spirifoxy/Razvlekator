namespace Razvlekator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbc47cf13500994315bba7a73e01306b72.discount")]
    public partial class discount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public discount()
        {
            Ticket = new HashSet<Ticket>();
        }

        [Key]
        public int pk_discount { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string name { get; set; }

        public int value { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
