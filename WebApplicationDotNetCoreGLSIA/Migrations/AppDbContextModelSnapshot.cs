﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationDotNetCoreGLSIA.Models;

#nullable disable

namespace WebApplicationDotNetCoreGLSIA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.Categorie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)")
                        .HasDefaultValue("A");

                    b.HasKey("Id");

                    b.ToTable("Categs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ca72b856-c29b-4df4-89e3-14b6586d512a"),
                            Name = "test"
                        });
                });

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.Produit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("produits");
                });

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.ProduitssCategorie", b =>
                {
                    b.Property<Guid>("ProduitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ssCategorieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateAjout")
                        .HasColumnType("datetime2");

                    b.HasKey("ProduitId", "ssCategorieId");

                    b.HasIndex("ssCategorieId");

                    b.ToTable("ProduitssCategorie");
                });

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.ssCategorie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategorieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("SubCatName");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("SousCategories");
                });

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.ProduitssCategorie", b =>
                {
                    b.HasOne("WebApplicationDotNetCoreGLSIA.Models.Produit", "produit")
                        .WithMany("produitsscateg")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationDotNetCoreGLSIA.Models.ssCategorie", "sscateg")
                        .WithMany("prodsscateg")
                        .HasForeignKey("ssCategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("produit");

                    b.Navigation("sscateg");
                });

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.ssCategorie", b =>
                {
                    b.HasOne("WebApplicationDotNetCoreGLSIA.Models.Categorie", "categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorie");
                });

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.Produit", b =>
                {
                    b.Navigation("produitsscateg");
                });

            modelBuilder.Entity("WebApplicationDotNetCoreGLSIA.Models.ssCategorie", b =>
                {
                    b.Navigation("prodsscateg");
                });
#pragma warning restore 612, 618
        }
    }
}
