namespace HomeWork08.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyData")]
    public partial class MyData
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string P_Name { get; set; }

        public decimal Price { get; set; }
    }
}
