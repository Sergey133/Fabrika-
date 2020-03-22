namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Изделия
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Изделия()
        {
            Заказанные_изделия = new HashSet<Заказанные_изделия>();
            Фурнитура_изделия = new HashSet<Фурнитура_изделия>();
            Ткани = new HashSet<Ткани>();
        }

        [Required]
        [StringLength(50)]
        public string Артикул { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Ширина { get; set; }

        [Required]
        [StringLength(50)]
        public string Длина { get; set; }

        [Required]
        [StringLength(50)]
        public string Стоимость { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказанные_изделия> Заказанные_изделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Фурнитура_изделия> Фурнитура_изделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ткани> Ткани { get; set; }
    }
}
