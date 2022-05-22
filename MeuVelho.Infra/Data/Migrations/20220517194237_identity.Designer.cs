﻿// <auto-generated />
using System;
using MeuVelho.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MeuVelho.Infra.Data.Migrations
{
    [DbContext(typeof(MeuVelhoContext))]
    [Migration("20220517194237_identity")]
    partial class identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MeuVelho.Domains.CaregiverCityDomain", b =>
                {
                    b.Property<Guid>("IdCaregiver")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_CAREGIVER");

                    b.Property<Guid>("IdCity")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_CITY");

                    b.HasKey("IdCaregiver", "IdCity");

                    b.HasIndex("IdCity");

                    b.ToTable("CAREGIVER_CITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.CaregiverDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("ACTIVE");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("BIOGRAPHY");

                    b.Property<DateTime?>("DisabledIn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DISABLED_IN");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("FULL_NAME");

                    b.Property<int>("Gender")
                        .HasColumnType("integer")
                        .HasColumnName("GENDER");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("PHOTO");

                    b.Property<DateTime>("RegisterIn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("REGISTER_IN");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("WHATSAPP");

                    b.HasKey("Id");

                    b.ToTable("CAREGIVER");
                });

            modelBuilder.Entity("MeuVelho.Domains.CityDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<Guid>("IdState")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_STATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.HasIndex("IdState");

                    b.ToTable("CITY");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            IdState = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Belo Horizonte"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            IdState = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Nova Lima"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            IdState = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Divinópolis"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            IdState = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Rio Acima"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            IdState = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Ouro Preto"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            IdState = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Itabirito"
                        });
                });

            modelBuilder.Entity("MeuVelho.Domains.ConnectionDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE");

                    b.Property<Guid>("IdCaregiver")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_CAREGIVER");

                    b.HasKey("Id");

                    b.HasIndex("IdCaregiver");

                    b.ToTable("CONNECTION");
                });

            modelBuilder.Entity("MeuVelho.Domains.CountryDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("COUNTRY");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Brasil"
                        });
                });

            modelBuilder.Entity("MeuVelho.Domains.LoginDomain", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("LOGIN_PROVIDER");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("PROVIDER_DISPLAY_NAME");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("PROVIDER_KEY");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_USER");

                    b.HasIndex("UserId");

                    b.ToTable("LOGIN", "IDENTITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.RoleClaimDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("CLAIM_TYPE");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("CLAIM_VALUE");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_ROLE");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ROLE_CLAIM", "IDENTITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.RoleDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasColumnName("CONCURRENCY_STAMP");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text")
                        .HasColumnName("NORMALIZED_NAME");

                    b.HasKey("Id");

                    b.ToTable("ROLE", "IDENTITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.StateDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<Guid>("IdCountry")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_COUNTRY");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.HasIndex("IdCountry");

                    b.ToTable("STATE");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            IdCountry = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            IdCountry = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            IdCountry = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "São Paulo"
                        });
                });

            modelBuilder.Entity("MeuVelho.Domains.UserClaimDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("CLAIM_TYPE");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("CLAIM_VALUE");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_USER");

                    b.HasKey("Id");

                    b.ToTable("USER_CLAIM", "IDENTITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.UserDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("ACCESS_FAILED_COUNT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("CONCURRENCY_STAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("EMAIL");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("EMAIL_CONFIRMED");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("LOCKOUT_ENABLED");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LOCKOUT_END");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("NORMALIZED_EMAIL");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("NORMALIZED_USER_NAME");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("PHONE_NUMBER");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("PHONE_NUMBER_CONFIRMED");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("SECURITY_STAMP");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("TWO_FACTOR_ENABLED");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("USER_NAME");

                    b.HasKey("Id");

                    b.ToTable("USER", "IDENTITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.UserRoleDomain", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_ROLE");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_USER");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("USER_ROLE", "IDENTITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.UserTokenDomain", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("LOGIN_PROVIDER");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("NAME");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_USER");

                    b.Property<string>("Value")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("VALUE");

                    b.HasIndex("UserId");

                    b.ToTable("USER_TOKEN", "IDENTITY");
                });

            modelBuilder.Entity("MeuVelho.Domains.CaregiverCityDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.CaregiverDomain", "Caregiver")
                        .WithMany("CaregiversCities")
                        .HasForeignKey("IdCaregiver")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeuVelho.Domains.CityDomain", "City")
                        .WithMany("CaregiversCities")
                        .HasForeignKey("IdCity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caregiver");

                    b.Navigation("City");
                });

            modelBuilder.Entity("MeuVelho.Domains.CityDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.StateDomain", "State")
                        .WithMany("Cities")
                        .HasForeignKey("IdState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("MeuVelho.Domains.ConnectionDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.CaregiverDomain", "Caregiver")
                        .WithMany("Connections")
                        .HasForeignKey("IdCaregiver")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caregiver");
                });

            modelBuilder.Entity("MeuVelho.Domains.LoginDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.UserDomain", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MeuVelho.Domains.RoleClaimDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.RoleDomain", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MeuVelho.Domains.StateDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.CountryDomain", "Country")
                        .WithMany("States")
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MeuVelho.Domains.UserRoleDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.RoleDomain", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeuVelho.Domains.UserDomain", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MeuVelho.Domains.UserTokenDomain", b =>
                {
                    b.HasOne("MeuVelho.Domains.UserDomain", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MeuVelho.Domains.CaregiverDomain", b =>
                {
                    b.Navigation("CaregiversCities");

                    b.Navigation("Connections");
                });

            modelBuilder.Entity("MeuVelho.Domains.CityDomain", b =>
                {
                    b.Navigation("CaregiversCities");
                });

            modelBuilder.Entity("MeuVelho.Domains.CountryDomain", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("MeuVelho.Domains.StateDomain", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
