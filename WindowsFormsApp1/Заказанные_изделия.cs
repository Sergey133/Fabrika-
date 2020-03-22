namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Заказанные изделия")]
    public partial class Заказанные_изделия
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("ID изделия")]
        public int ID_изделия { get; set; }

        public int Количество { get; set; }

        public virtual Изделия Изделия { get; set; }
    }
}
