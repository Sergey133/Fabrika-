namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура_изделия
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_фурнитуры { get; set; }

        public int ID_изделия { get; set; }

        [Required]
        [StringLength(50)]
        public string Размещение { get; set; }

        public double? Ширина { get; set; }

        public double? Длина { get; set; }

        public double? Поворот { get; set; }

        public int Количество { get; set; }

        public virtual Изделия Изделия { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
