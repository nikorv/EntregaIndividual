﻿// <auto-generated />
using Agencia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agencia.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Agencia.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("DataNasc")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("client_datanasc");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("client_email");

                    b.Property<string>("IconeClient")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("client_iconeclient");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("client_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("client_phone");

                    b.HasKey("Id");

                    b.ToTable("clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNasc = "11-11-2001",
                            Email = "ferrecode@recode.com",
                            IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png",
                            Name = "Fernanda",
                            Phone = "1111111111111"
                        },
                        new
                        {
                            Id = 2,
                            DataNasc = "11-11-2001",
                            Email = "feliperecode@recode.com",
                            IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191934_960_720.png",
                            Name = "Felipe",
                            Phone = "2222222222"
                        },
                        new
                        {
                            Id = 3,
                            DataNasc = "11-11-2001",
                            Email = "Nancyrecode@recode.com",
                            IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png",
                            Name = "Nancy",
                            Phone = "3333333333"
                        },
                        new
                        {
                            Id = 4,
                            DataNasc = "11-11-2001",
                            Email = "Pollirecode@recode.com",
                            IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png",
                            Name = "Polliana",
                            Phone = "444444444"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
