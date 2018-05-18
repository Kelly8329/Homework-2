namespace HomeWork04.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketFare")]
    public partial class TicketFare
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string StartStation { get; set; }

        [Required]
        [StringLength(10)]
        public string EndStation { get; set; }

        public decimal Fare { get; set; }
    }
}
