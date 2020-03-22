namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Заказанные_изделия> Заказанные_изделия { get; set; }
        public virtual DbSet<Изделия> Изделия { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Склад_ткани> Склад_ткани { get; set; }
        public virtual DbSet<Склад_фурнитуры> Склад_фурнитуры { get; set; }
        public virtual DbSet<Ткани> Ткани { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }
        public virtual DbSet<Фурнитура_изделия> Фурнитура_изделия { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.Стоимость)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Заказанные_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.ID_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.ID_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Ткани)
                .WithMany(e => e.Изделия)
                .Map(m => m.ToTable("Ткани изделия").MapLeftKey("ID_изделия").MapRightKey("ID_ткани"));

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Пользователь)
                .HasForeignKey(e => e.Менеджер)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ1)
                .WithRequired(e => e.Пользователь1)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ткани>()
                .HasMany(e => e.Склад_ткани)
                .WithRequired(e => e.Ткани)
                .HasForeignKey(e => e.ID_ткани)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Склад_фурнитуры)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.ID_фурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.ID_фурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
