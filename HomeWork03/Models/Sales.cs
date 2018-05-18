namespace HomeWork08.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Salesman { get; set; }

        [Required]
        [StringLength(50)]
        public string P_Name { get; set; }

        public int Amount { get; set; }
    }
}
