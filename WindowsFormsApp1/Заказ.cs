namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата { get; set; }

        [Required]
        [StringLength(20)]
        public string Этап_выполнения { get; set; }

        public int Заказчик { get; set; }

        public int Менеджер { get; set; }

        public decimal? Стоимость { get; set; }

        public virtual Пользователь Пользователь { get; set; }

        public virtual Пользователь Пользователь1 { get; set; }
    }
}
