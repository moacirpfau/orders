﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using orders;

namespace orders.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200721002547_Modelo")]
    partial class Modelo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("orders.Models.Orders", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("ITEM");

                    b.Property<string>("CANAL")
                        .IsRequired();

                    b.Property<string>("CLIENTE")
                        .IsRequired();

                    b.Property<int>("QTD");

                    b.Property<decimal>("TOTAL");

                    b.Property<decimal>("VALORUNITARIO");

                    b.HasKey("ID", "ITEM");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
