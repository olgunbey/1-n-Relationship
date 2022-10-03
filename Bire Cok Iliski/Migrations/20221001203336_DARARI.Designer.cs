﻿// <auto-generated />
using Bire_Cok_Iliski;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bire_Cok_Iliski.Migrations
{
    [DbContext(typeof(DBXContext))]
    [Migration("20221001203336_DARARI")]
    partial class DARARI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bire_Cok_Iliski.Kisiler", b =>
                {
                    b.Property<int>("KisilerID")
                        .HasColumnType("int");

                    b.Property<string>("KISIAD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PCMarkaID")
                        .HasColumnType("int");

                    b.HasKey("KisilerID", "KISIAD");

                    b.HasIndex("PCMarkaID");

                    b.ToTable("Kisiler");
                });

            modelBuilder.Entity("Bire_Cok_Iliski.PcMarkalar", b =>
                {
                    b.Property<int>("MarkaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MarkaAD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarkaID");

                    b.ToTable("PcMarkalar");
                });

            modelBuilder.Entity("Bire_Cok_Iliski.Kisiler", b =>
                {
                    b.HasOne("Bire_Cok_Iliski.PcMarkalar", "PcMarkalar")
                        .WithMany("Kisiler")
                        .HasForeignKey("PCMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PcMarkalar");
                });

            modelBuilder.Entity("Bire_Cok_Iliski.PcMarkalar", b =>
                {
                    b.Navigation("Kisiler");
                });
#pragma warning restore 612, 618
        }
    }
}
