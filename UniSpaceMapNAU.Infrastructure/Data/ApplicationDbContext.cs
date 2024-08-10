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
                Id = 5, FacultyId = (int)FacultyEnum.ФКНТ, Name = "Інформаційні системи та технології",
                SpecialtyNumber = 126
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

        #region Buildings

        modelBuilder.Entity<Building>().HasData(
            new Building { Id = 1, Name = "Корпус 1" },
            new Building { Id = 2, Name = "Корпус 2" },
            new Building { Id = 3, Name = "Корпус 3" },
            new Building { Id = 4, Name = "Корпус 4" },
            new Building { Id = 5, Name = "Корпус 5" },
            new Building { Id = 6, Name = "Корпус 6" },
            new Building { Id = 7, Name = "Корпус 7" },
            new Building { Id = 8, Name = "Корпус 8" },
            new Building { Id = 9, Name = "Корпус 9" },
            new Building { Id = 10, Name = "Корпус 10" },
            new Building { Id = 11, Name = "Корпус 11" },
            new Building { Id = 12, Name = "Корпус 12" }
        );

        #endregion
        
        #region RoomTypes
        
        modelBuilder.Entity<RoomType>().HasData(
            new RoomType { Id = 1, Name = "Лекційна" },
            new RoomType { Id = 2, Name = "Практична" } 
        );
        
        #endregion
        
        #region Rooms
            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(r => r.Id); 
                entity.Property(r => r.RoomNumber).IsRequired();
                entity.Property(r => r.FloorNumber).IsRequired();
                entity.HasOne(r => r.RoomType) 
                    .WithMany() 
                    .HasForeignKey(r => r.RoomTypeId);
                entity.HasOne(r => r.Faculty) 
                    .WithMany()
                    .HasForeignKey(r => r.FacultyId);
            });
            
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = 101, FloorNumber = 1, RoomTypeId = 1, FacultyId = 1 },
                new Room { Id = 2, RoomNumber = 102, FloorNumber = 1, RoomTypeId = 1, FacultyId = 1 }
            );
        #endregion
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<StudentGroup> StudentsGroups { get; set; }
    public DbSet<Building> Buildings { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Room> Rooms { get; set; }
}