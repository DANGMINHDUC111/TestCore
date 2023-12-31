﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApiCore.Data;

#nullable disable

namespace WebApiCore.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230722114921_DbInit")]
    partial class DbInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApiCore.Data.HangHoa", b =>
                {
                    b.Property<Guid>("MaHangHoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("DonGia")
                        .HasColumnType("double precision");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("smallint");

                    b.Property<string>("MoTa")
                        .HasColumnType("text");

                    b.Property<string>("TenHangHoa")
                        .HasColumnType("text");

                    b.HasKey("MaHangHoa");

                    b.ToTable("HangHoa");
                });
#pragma warning restore 612, 618
        }
    }
}
