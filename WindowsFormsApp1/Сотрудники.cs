namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        public int? id { get; set; }

        [StringLength(10)]
        public string Login { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [Key]
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
    }
}
