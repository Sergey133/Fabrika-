namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ткани
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ткани()
        {
            Склад_ткани = new HashSet<Склад_ткани>();
            Изделия = new HashSet<Изделия>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Required]
        [StringLength(50)]
        public string Цвет { get; set; }

        [Required]
        [StringLength(50)]
        public string Рисунок { get; set; }

        [Required]
        [StringLength(50)]
        public string Состав { get; set; }

        [Required]
        [StringLength(50)]
        public string Ширина { get; set; }

        [Required]
        [StringLength(50)]
        public string Длина { get; set; }

        [Required]
        [StringLength(50)]
        public string Цена { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад_ткани> Склад_ткани { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Изделия> Изделия { get; set; }
    }
}
