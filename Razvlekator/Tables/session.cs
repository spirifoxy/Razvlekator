namespace Razvlekator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbc47cf13500994315bba7a73e01306b72.session")]
    public partial class session
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public session()
        {
            Ticket = new HashSet<ticket>();
        }

        [Key]
        public int pk_session { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public TimeSpan time { get; set; }

        public int pk_place { get; set; }

        public virtual place place { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ticket> Ticket { get; set; }
    }
}
