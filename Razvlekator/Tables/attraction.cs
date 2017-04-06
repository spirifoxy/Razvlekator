namespace Razvlekator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbc47cf13500994315bba7a73e01306b72.attraction")]
    public partial class attraction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public attraction()
        {
            cart = new HashSet<cart>();
        }

        [Key]
        public int pk_attraction { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int duration { get; set; }

        public int starttime { get; set; }

        public int endtime { get; set; }

        public float ticketpriceadult { get; set; }

        public float ticketpricekid { get; set; }

        public int agerestrictions { get; set; }

        public int growthrestriction { get; set; }

        public int weightrestriction { get; set; }

        public int? cartcount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart> cart { get; set; }
    }
}
