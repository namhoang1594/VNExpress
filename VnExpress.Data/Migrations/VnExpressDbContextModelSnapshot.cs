﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VnExpress.Data.EF;

namespace VnExpress.Data.Migrations
{
    [DbContext(typeof(VnExpressDbContext))]
    partial class VnExpressDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VnExpress.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Văn hóa",
                            Description = "Mo ta"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Xã hội",
                            Description = "Mo ta"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Kinh tế",
                            Description = "Mo ta"
                        });
                });

            modelBuilder.Entity("VnExpress.Data.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Hoàng Nam",
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Images = "Ảnh",
                            MainContent = "Tình hình kinh tế EU",
                            ShortContent = "Tình hình kinh tế châu á",
                            Title = "Tình hình kinh tế thế giới"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Tuấn Anh",
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Images = "Ảnh",
                            MainContent = "Tình hình xã hội EU",
                            ShortContent = "Tình hình xã hội châu á",
                            Title = "Tình hình xã hội thế giới"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Văn Trung",
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Images = "Ảnh",
                            MainContent = "Tình hình văn hóa EU",
                            ShortContent = "Tình hình văn hóa châu á",
                            Title = "Tình hình văn hóa thế giới"
                        });
                });

            modelBuilder.Entity("VnExpress.Data.Entities.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            ConfirmPassword = "123456",
                            Email = "anh453138@gmail.com",
                            FirstName = "Tuấn",
                            LastName = "Anh",
                            Password = "123456",
                            UserName = "tuananh"
                        },
                        new
                        {
                            IdUser = 2,
                            ConfirmPassword = "123456",
                            Email = "admin453138@gmail.com",
                            FirstName = "Ad",
                            LastName = "min",
                            Password = "123456",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("VnExpress.Data.Entities.Post", b =>
                {
                    b.HasOne("VnExpress.Data.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VnExpress.Data.Entities.Category", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
