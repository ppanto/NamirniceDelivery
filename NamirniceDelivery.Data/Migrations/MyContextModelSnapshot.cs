﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NamirniceDelivery.Data.Context;

namespace NamirniceDelivery.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Kanton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oznaka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kanton");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KorpaStavka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("KupacId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NamirnicaPodruznicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("NamirnicaPodruznicaId");

                    b.ToTable("KorpaStavka");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KupacSpremljeneNamirnice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KupacId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NamirnicaPodruznicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("NamirnicaPodruznicaId");

                    b.ToTable("KupacSpremljeneNamirnice");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KupacSpremljenePodruznice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KupacId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PodruznicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("PodruznicaId");

                    b.ToTable("KupacSpremljenePodruznice");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KupljeneNamirnice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NamirnicaId")
                        .HasColumnType("int");

                    b.Property<int>("TransakcijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NamirnicaId");

                    b.HasIndex("TransakcijaId");

                    b.ToTable("KupljeneNamirnice");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Namirnica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Namirnica");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.NamirnicaPodruznica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna")
                        .HasColumnType("bit");

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KolicinaNaStanju")
                        .HasColumnType("int");

                    b.Property<int>("NamirnicaId")
                        .HasColumnType("int");

                    b.Property<int>("PodruznicaId")
                        .HasColumnType("int");

                    b.Property<int?>("PopustId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NamirnicaId");

                    b.HasIndex("PodruznicaId");

                    b.HasIndex("PopustId");

                    b.ToTable("NamirnicaPodruznica");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.NamirnicaVoznja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KolicinaPrevezena")
                        .HasColumnType("int");

                    b.Property<int>("NamirnicaId")
                        .HasColumnType("int");

                    b.Property<int>("VoznjaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NamirnicaId");

                    b.HasIndex("VoznjaId");

                    b.ToTable("NamirnicaVoznja");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Opcina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KantonId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KantonId");

                    b.ToTable("Opcina");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Podruznica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpcinaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OpcinaId");

                    b.ToTable("Podruznica");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Popust", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Iznos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Popust");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.TipTransakcije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivTipa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipTransakcije");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Transakcija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdministrativniRadnikId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DatumIniciranjaTransakcije")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPrihvacanjaNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumUspjesneDostave")
                        .HasColumnType("datetime2");

                    b.Property<string>("DojamKupac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DojamRadnik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DostavaUspjesna")
                        .HasColumnType("bit");

                    b.Property<string>("KupacId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("KupacOstavioDojam")
                        .HasColumnType("bit");

                    b.Property<bool>("NarudzbaPrihvacenaOdRadnika")
                        .HasColumnType("bit");

                    b.Property<bool>("RadnikOstavioDojam")
                        .HasColumnType("bit");

                    b.Property<int>("TipTransakcijeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministrativniRadnikId");

                    b.HasIndex("KupacId");

                    b.HasIndex("TipTransakcijeId");

                    b.ToTable("Transakcija");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Vozilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MarkaVozila")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistarskeOznake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipVozila")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VozacId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("VozacId");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Voznja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ObavljenaVoznja")
                        .HasColumnType("bit");

                    b.Property<int>("PodruznicaKrajId")
                        .HasColumnType("int");

                    b.Property<int>("PodruznicaPocetakId")
                        .HasColumnType("int");

                    b.Property<bool>("PreuzetaRoba")
                        .HasColumnType("bit");

                    b.Property<string>("VozacId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("VoznjaKraj")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VoznjaPocetak")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PodruznicaKrajId");

                    b.HasIndex("PodruznicaPocetakId");

                    b.HasIndex("VozacId");

                    b.ToTable("Voznja");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OpcinaBoravkaId")
                        .HasColumnType("int");

                    b.Property<int?>("OpcinaRodjenjaId")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("OpcinaBoravkaId");

                    b.HasIndex("OpcinaRodjenjaId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.AdministrativniRadnik", b =>
                {
                    b.HasBaseType("NamirniceDelivery.Data.Entities.ApplicationUser");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PodruznicaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("RejtingRadnik")
                        .HasColumnType("int");

                    b.HasIndex("PodruznicaId");

                    b.HasDiscriminator().HasValue("AdministrativniRadnik");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Kupac", b =>
                {
                    b.HasBaseType("NamirniceDelivery.Data.Entities.ApplicationUser");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RejtingKupac")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Kupac");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Vozac", b =>
                {
                    b.HasBaseType("NamirniceDelivery.Data.Entities.ApplicationUser");

                    b.Property<string>("KategorijaVozackeDozvole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VoziloId")
                        .HasColumnType("int");

                    b.HasIndex("VoziloId")
                        .IsUnique()
                        .HasFilter("[VoziloId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Vozac");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KorpaStavka", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId");

                    b.HasOne("NamirniceDelivery.Data.Entities.NamirnicaPodruznica", "NamirnicaPodruznica")
                        .WithMany()
                        .HasForeignKey("NamirnicaPodruznicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KupacSpremljeneNamirnice", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Kupac", "Kupac")
                        .WithMany("SpreljeneNamirnice")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.NamirnicaPodruznica", "NamirnicaPodruznica")
                        .WithMany()
                        .HasForeignKey("NamirnicaPodruznicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KupacSpremljenePodruznice", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Kupac", "Kupac")
                        .WithMany("SpremljenePodruznice")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Podruznica", "Podruznica")
                        .WithMany()
                        .HasForeignKey("PodruznicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.KupljeneNamirnice", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Namirnica", "Namirnica")
                        .WithMany()
                        .HasForeignKey("NamirnicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Transakcija", "Transakcija")
                        .WithMany("KupljeneNamirnice")
                        .HasForeignKey("TransakcijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Namirnica", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.NamirnicaPodruznica", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Namirnica", "Namirnica")
                        .WithMany()
                        .HasForeignKey("NamirnicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Podruznica", "Podruznica")
                        .WithMany("NamirnicaPodruznica")
                        .HasForeignKey("PodruznicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Popust", "Popust")
                        .WithMany()
                        .HasForeignKey("PopustId");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.NamirnicaVoznja", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Namirnica", "Namirnica")
                        .WithMany()
                        .HasForeignKey("NamirnicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Voznja", "Voznja")
                        .WithMany("NamirnicaVoznja")
                        .HasForeignKey("VoznjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Opcina", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Kanton", "Kanton")
                        .WithMany("Opcine")
                        .HasForeignKey("KantonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Podruznica", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Opcina", "Opcina")
                        .WithMany()
                        .HasForeignKey("OpcinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Transakcija", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.AdministrativniRadnik", "AdministrativniRadnik")
                        .WithMany("Transakcije")
                        .HasForeignKey("AdministrativniRadnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Kupac", "Kupac")
                        .WithMany("Transakcije")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.TipTransakcije", "TipTransakcije")
                        .WithMany()
                        .HasForeignKey("TipTransakcijeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Vozilo", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacId");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Voznja", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Podruznica", "PodruznicaKraj")
                        .WithMany()
                        .HasForeignKey("PodruznicaKrajId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Podruznica", "PodruznicaPocetak")
                        .WithMany()
                        .HasForeignKey("PodruznicaPocetakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamirniceDelivery.Data.Entities.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacId");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.ApplicationUser", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Opcina", "OpcinaBoravka")
                        .WithMany()
                        .HasForeignKey("OpcinaBoravkaId");

                    b.HasOne("NamirniceDelivery.Data.Entities.Opcina", "OpcinaRodjenja")
                        .WithMany()
                        .HasForeignKey("OpcinaRodjenjaId");
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.AdministrativniRadnik", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Podruznica", "Podruznica")
                        .WithMany()
                        .HasForeignKey("PodruznicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NamirniceDelivery.Data.Entities.Vozac", b =>
                {
                    b.HasOne("NamirniceDelivery.Data.Entities.Vozilo", "Vozilo")
                        .WithOne()
                        .HasForeignKey("NamirniceDelivery.Data.Entities.Vozac", "VoziloId");
                });
#pragma warning restore 612, 618
        }
    }
}
