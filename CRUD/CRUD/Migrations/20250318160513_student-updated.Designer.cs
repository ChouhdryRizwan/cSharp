﻿// <auto-generated />
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD.Migrations
{
    [DbContext(typeof(myContext))]
    [Migration("20250318160513_student-updated")]
    partial class studentupdated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD.Models.Student", b =>
                {
                    b.Property<int>("sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sid"));

                    b.Property<string>("sbatch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("semail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sid");

                    b.ToTable("tbl_Students");
                });
#pragma warning restore 612, 618
        }
    }
}
