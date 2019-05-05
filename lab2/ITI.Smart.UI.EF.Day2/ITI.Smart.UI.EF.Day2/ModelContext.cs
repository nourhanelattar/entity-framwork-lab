namespace ITI.Smart.UI.EF.Day2
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Cover> cover { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .ToTable("Department")
                .HasKey(d => d.Dept_Id)
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .ToTable("Employee")
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithRequired(e => e.Department)
                .HasForeignKey(e => e.FK_DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Books)
                .WithMany(b => b.Employees)
                .Map(m => m.ToTable("EmpBooks")
                .MapLeftKey("Fk_EmployeeId")
                .MapRightKey("Fk_BookId"));

            modelBuilder.Entity<city>()
                .HasOptional(c => c.Book)
                .WithRequired(b => b.city);


            modelBuilder.Entity<Cover>()
                  .ToTable("cover")
                  .Property(c => c.code)
                  .HasMaxLength(100)
                  .IsRequired();

            //modelBuilder.Entity<Book>()
            //    .HasRequired(b => b.cover)
            //    .WithRequiredPrincipal(c => c.Book);

            modelBuilder.Entity<Cover>()
                .HasRequired(c => c.Book)
                .WithRequiredDependent(b => b.cover)
                .WillCascadeOnDelete(false);

        }




    }


}