namespace Razvlekator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbc47cf13500994315bba7a73e01306b72.Refund")]
    public partial class refund
    {
        [Key]
        public int Pk_refund { get; set; }

        public int number { get; set; }

        public float money { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }
    }
}
