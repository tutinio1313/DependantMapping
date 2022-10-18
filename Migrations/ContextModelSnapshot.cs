﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patron_Database;

#nullable disable

namespace Patron.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Patron_Model.Album", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("albums");
                });

            modelBuilder.Entity("Patron_Model.Track", b =>
                {
                    b.Property<int>("TrackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Albumid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("length")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TrackID");

                    b.HasIndex("Albumid");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("Patron_Model.Track", b =>
                {
                    b.HasOne("Patron_Model.Album", null)
                        .WithMany("Tracks")
                        .HasForeignKey("Albumid");
                });

            modelBuilder.Entity("Patron_Model.Album", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
