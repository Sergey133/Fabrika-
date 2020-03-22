namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Склад фурнитуры")]
    public partial class Склад_фурнитуры
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Партия { get; set; }

        public int ID_фурнитуры { get; set; }

        public int Количество { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
