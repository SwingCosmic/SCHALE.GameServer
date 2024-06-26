﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCHALE.Common.Database;

#nullable disable

namespace SCHALE.Common.Migrations
{
    [DbContext(typeof(SCHALEContext))]
    [Migration("20240501071717_CharacterAndRelations")]
    partial class CharacterAndRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SCHALE.Common.Database.AccountDB", b =>
                {
                    b.Property<long>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ServerId"));

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime");

                    b.Property<string>("CallName")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CallNameUpdateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Comment")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("DevId")
                        .HasColumnType("varchar(500)");

                    b.Property<long>("Exp")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastConnectTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LinkRewardDate")
                        .HasColumnType("datetime");

                    b.Property<int>("LobbyMode")
                        .HasColumnType("int");

                    b.Property<long>("MemoryLobbyUniqueId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nickname")
                        .HasColumnType("varchar(500)");

                    b.Property<long>("PublisherAccountId")
                        .HasColumnType("bigint");

                    b.Property<int>("RepresentCharacterServerId")
                        .HasColumnType("int");

                    b.Property<int?>("RetentionDays")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int?>("UnReadMailCount")
                        .HasColumnType("int");

                    b.Property<int?>("VIPLevel")
                        .HasColumnType("int");

                    b.HasKey("ServerId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SCHALE.Common.Database.CharacterDB", b =>
                {
                    b.Property<long>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ServerId"));

                    b.Property<long>("AccountServerId")
                        .HasColumnType("bigint");

                    b.Property<string>("EquipmentServerIds")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("EquipmentSlotAndDBIds")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<int>("ExSkillLevel")
                        .HasColumnType("int");

                    b.Property<long>("Exp")
                        .HasColumnType("bigint");

                    b.Property<int>("ExtraPassiveSkillLevel")
                        .HasColumnType("int");

                    b.Property<long>("FavorExp")
                        .HasColumnType("bigint");

                    b.Property<int>("FavorRank")
                        .HasColumnType("int");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<int>("LeaderSkillLevel")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("PassiveSkillLevel")
                        .HasColumnType("int");

                    b.Property<string>("PotentialStats")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<int>("PublicSkillLevel")
                        .HasColumnType("int");

                    b.Property<int>("StarGrade")
                        .HasColumnType("int");

                    b.Property<long>("UniqueId")
                        .HasColumnType("bigint");

                    b.HasKey("ServerId");

                    b.HasIndex("AccountServerId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("SCHALE.Common.Database.ItemDB", b =>
                {
                    b.Property<long>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ServerId"));

                    b.Property<long>("AccountServerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<long>("StackCount")
                        .HasColumnType("bigint");

                    b.Property<long>("UniqueId")
                        .HasColumnType("bigint");

                    b.HasKey("ServerId");

                    b.HasIndex("AccountServerId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SCHALE.Common.Database.MissionProgressDB", b =>
                {
                    b.Property<long>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ServerId"));

                    b.Property<long>("AccountServerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Complete")
                        .HasColumnType("bit");

                    b.Property<long>("MissionUniqueId")
                        .HasColumnType("bigint");

                    b.Property<string>("ProgressParameters")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.HasKey("ServerId");

                    b.HasIndex("AccountServerId");

                    b.ToTable("MissionProgresses");
                });

            modelBuilder.Entity("SCHALE.Common.Database.Models.AccountTutorial", b =>
                {
                    b.Property<long>("AccountServerId")
                        .HasColumnType("bigint");

                    b.Property<string>("TutorialIds")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("AccountServerId");

                    b.ToTable("AccountTutorials");
                });

            modelBuilder.Entity("SCHALE.Common.Database.Models.GuestAccount", b =>
                {
                    b.Property<long>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Uid"));

                    b.Property<string>("DeviceId")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("Uid");

                    b.ToTable("GuestAccounts");
                });

            modelBuilder.Entity("SCHALE.Common.Database.CharacterDB", b =>
                {
                    b.HasOne("SCHALE.Common.Database.AccountDB", "Account")
                        .WithMany("Characters")
                        .HasForeignKey("AccountServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SCHALE.Common.Database.ItemDB", b =>
                {
                    b.HasOne("SCHALE.Common.Database.AccountDB", "Account")
                        .WithMany("Items")
                        .HasForeignKey("AccountServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SCHALE.Common.Database.MissionProgressDB", b =>
                {
                    b.HasOne("SCHALE.Common.Database.AccountDB", "Account")
                        .WithMany("MissionProgresses")
                        .HasForeignKey("AccountServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SCHALE.Common.Database.AccountDB", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("Items");

                    b.Navigation("MissionProgresses");
                });
#pragma warning restore 612, 618
        }
    }
}
