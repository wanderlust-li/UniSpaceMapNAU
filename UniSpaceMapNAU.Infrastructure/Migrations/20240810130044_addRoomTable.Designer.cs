﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniSpaceMapNAU.Infrastructure.Data;

#nullable disable

namespace UniSpaceMapNAU.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240810130044_addRoomTable")]
    partial class addRoomTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Корпус 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Корпус 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Корпус 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Корпус 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Корпус 5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Корпус 6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Корпус 7"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Корпус 8"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Корпус 9"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Корпус 10"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Корпус 11"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Корпус 12"
                        });
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialtyNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacultyId = 1,
                            Name = "Прикладна математика",
                            SpecialtyNumber = 113
                        },
                        new
                        {
                            Id = 2,
                            FacultyId = 1,
                            Name = "Кібербезпека",
                            SpecialtyNumber = 125
                        },
                        new
                        {
                            Id = 3,
                            FacultyId = 1,
                            Name = "Компʼютерні науки",
                            SpecialtyNumber = 122
                        },
                        new
                        {
                            Id = 4,
                            FacultyId = 1,
                            Name = "Компʼютерна інженерія",
                            SpecialtyNumber = 123
                        },
                        new
                        {
                            Id = 5,
                            FacultyId = 1,
                            Name = "Інформаційні системи та технології",
                            SpecialtyNumber = 126
                        });
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ФКНТ"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ФАЕТ"
                        },
                        new
                        {
                            Id = 3,
                            Name = "ФЕБА"
                        },
                        new
                        {
                            Id = 4,
                            Name = "ФЕБІТ"
                        },
                        new
                        {
                            Id = 5,
                            Name = "АКФ"
                        },
                        new
                        {
                            Id = 6,
                            Name = "ФЛСК"
                        },
                        new
                        {
                            Id = 7,
                            Name = "ФМВ"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ФНСА"
                        },
                        new
                        {
                            Id = 9,
                            Name = "ФТМЛ"
                        },
                        new
                        {
                            Id = 10,
                            Name = "ЮФ"
                        });
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Floors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingId = 1,
                            FloorNumber = 1
                        },
                        new
                        {
                            Id = 2,
                            BuildingId = 1,
                            FloorNumber = 2
                        },
                        new
                        {
                            Id = 3,
                            BuildingId = 1,
                            FloorNumber = 3
                        },
                        new
                        {
                            Id = 4,
                            BuildingId = 1,
                            FloorNumber = 4
                        },
                        new
                        {
                            Id = 5,
                            BuildingId = 1,
                            FloorNumber = 5
                        });
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("FloorId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacultyId = 1,
                            FloorId = 1,
                            RoomNumber = 101,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            FacultyId = 1,
                            FloorId = 1,
                            RoomNumber = 102,
                            RoomTypeId = 1
                        });
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Лекційна"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Практична"
                        });
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.StudentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("StudentsGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Name = "Group A"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 1,
                            Name = "Group B"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 1,
                            Name = "Group C"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Name = "Group E"
                        });
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Department", b =>
                {
                    b.HasOne("UniSpaceMapNAU.Domain.Entities.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Floor", b =>
                {
                    b.HasOne("UniSpaceMapNAU.Domain.Entities.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Room", b =>
                {
                    b.HasOne("UniSpaceMapNAU.Domain.Entities.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniSpaceMapNAU.Domain.Entities.Floor", "Floor")
                        .WithMany()
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniSpaceMapNAU.Domain.Entities.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Floor");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.StudentGroup", b =>
                {
                    b.HasOne("UniSpaceMapNAU.Domain.Entities.Department", "Department")
                        .WithMany("StudentGroups")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Department", b =>
                {
                    b.Navigation("StudentGroups");
                });

            modelBuilder.Entity("UniSpaceMapNAU.Domain.Entities.Faculty", b =>
                {
                    b.Navigation("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}
