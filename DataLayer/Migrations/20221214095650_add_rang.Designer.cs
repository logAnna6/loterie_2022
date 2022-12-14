// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221214095650_add_rang")]
    partial class addrang
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("DataLayer.Models.Game", b =>
                {
                    b.Property<int>("gameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("game_enddate")
                        .HasColumnType("TEXT");

                    b.Property<int>("game_num1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("game_num2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("game_num3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("game_num4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("game_num5")
                        .HasColumnType("INTEGER");

                    b.Property<int>("game_num6")
                        .HasColumnType("INTEGER");

                    b.Property<int>("game_prize")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("game_startdate")
                        .HasColumnType("TEXT");

                    b.HasKey("gameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("DataLayer.Models.Player", b =>
                {
                    b.Property<int>("playerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("gameId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("player_code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("player_num1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("player_num2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("player_num3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("player_num4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("player_num5")
                        .HasColumnType("INTEGER");

                    b.Property<int>("player_num6")
                        .HasColumnType("INTEGER");

                    b.Property<int>("player_prize")
                        .HasColumnType("INTEGER");

                    b.Property<int>("player_rang")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("player_reg_date")
                        .HasColumnType("TEXT");

                    b.HasKey("playerId");

                    b.HasIndex("gameId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("DataLayer.Models.Player", b =>
                {
                    b.HasOne("DataLayer.Models.Game", "Game")
                        .WithMany("Players")
                        .HasForeignKey("gameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("DataLayer.Models.Game", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
