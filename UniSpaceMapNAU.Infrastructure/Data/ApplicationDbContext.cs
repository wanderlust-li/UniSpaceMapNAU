using Microsoft.EntityFrameworkCore;
using UniSpaceMapNAU.Domain.Entities;
using UniSpaceMapNAU.Domain.Entities.Enums;

namespace UniSpaceMapNAU.Infrastructure.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Faculties
            modelBuilder.Entity<Faculty>().HasData(
                    new Faculty { Id = 1, Name = "ФКНТ" },
                    new Faculty { Id = 2, Name = "ФАЕТ" },
                    new Faculty { Id = 3, Name = "ФЕБА" },
                    new Faculty { Id = 4, Name = "ФЕБІТ" },
                    new Faculty { Id = 5, Name = "АКФ" },
                    new Faculty { Id = 6, Name = "ФЛСК" },
                    new Faculty { Id = 7, Name = "ФМВ" },
                    new Faculty { Id = 8, Name = "ФНСА" },
                    new Faculty { Id = 9, Name = "ФТМЛ" },
                    new Faculty { Id = 10, Name = "ЮФ" }
                );
        #endregion
        
        #region Department
            modelBuilder.Entity<Department>().HasOne(c => c.Faculty).WithMany(bc => bc.Departments)
                .HasForeignKey(c => c.FacultyId);
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1, FacultyId = (int)FacultyEnum.ФКНТ, Name = "Прикладна математика", SpecialtyNumber = 113
                },
                new Department
                {
                    Id = 2, FacultyId = (int)FacultyEnum.ФКНТ, Name = "Кібербезпека", SpecialtyNumber = 125
                },
                new Department
                {
                    Id = 3, FacultyId = (int)FacultyEnum.ФКНТ, Name = "Компʼютерні науки", SpecialtyNumber = 122
                },
                new Department
                {
                    Id = 4, FacultyId = (int)FacultyEnum.ФКНТ, Name = "Компʼютерна інженерія", SpecialtyNumber = 123
                },
                new Department
                {
                    Id = 5, FacultyId = (int)FacultyEnum.ФКНТ, Name = "Інформаційні системи та технології", SpecialtyNumber = 126
                }
            );

            #endregion
            
        #region SudentsGroups
            modelBuilder.Entity<StudentGroup>().HasOne(sg => sg.Department)
                .WithMany(d => d.StudentGroups)
                .HasForeignKey(sg => sg.DepartmentId);

            modelBuilder.Entity<StudentGroup>().HasData(
                new StudentGroup { Id = 1, Name = "Group A", DepartmentId = 1 },
                new StudentGroup { Id = 2, Name = "Group B", DepartmentId = 1 },
                new StudentGroup { Id = 3, Name = "Group C", DepartmentId = 1 },
                new StudentGroup { Id = 4, Name = "Group E", DepartmentId = 4 }
            );
        #endregion
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<StudentGroup> StudentsGroups { get; set; }
}