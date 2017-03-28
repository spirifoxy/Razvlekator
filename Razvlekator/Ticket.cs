namespace Razvlekator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbc47cf13500994315bba7a73e01306b72.Ticket")]
    public partial class Ticket
    {
        [Key]
        public int pk_ticket { get; set; }

        public int ticketnumber { get; set; }

        public int? pk_order { get; set; }

        public bool type { get; set; }

        public int pk_session { get; set; }

        public int? pk_discount { get; set; }

        public virtual discount discount { get; set; }

        public virtual order order { get; set; }

        public virtual session session { get; set; }
    }
}
