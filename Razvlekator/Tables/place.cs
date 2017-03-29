namespace Razvlekator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbc47cf13500994315bba7a73e01306b72.place")]
    public partial class place
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public place()
        {
            session = new HashSet<session>();
        }

        [Key]
        public int pk_place { get; set; }

        public int Number { get; set; }

        public int pk_cart { get; set; }

        public virtual cart cart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<session> session { get; set; }
    }
}
