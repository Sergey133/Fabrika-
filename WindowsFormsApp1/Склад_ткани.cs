namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Склад ткани")]
    public partial class Склад_ткани
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_ткани { get; set; }

        [Required]
        [StringLength(50)]
        public string Рулон { get; set; }

        public double? Ширина { get; set; }

        public double? Длина { get; set; }

        public virtual Ткани Ткани { get; set; }
    }
}
