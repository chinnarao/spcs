using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SP.DAL.Contexts;

namespace SP.DAL.Migrations
{
    [DbContext(typeof(SPDbContext))]
    [Migration("20170511072710_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SP.DAL.Models.AD_Andorra", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("AD_Andorra");
                });

            modelBuilder.Entity("SP.DAL.Models.AR_Argentina", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("AR_Argentina");
                });

            modelBuilder.Entity("SP.DAL.Models.AS_AmericanSamoa", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("AS_AmericanSamoa");
                });

            modelBuilder.Entity("SP.DAL.Models.AT_Austria", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("AT_Austria");
                });

            modelBuilder.Entity("SP.DAL.Models.AU_Australia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("AU_Australia");
                });

            modelBuilder.Entity("SP.DAL.Models.AX_AlandIslands", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("AX_AlandIslands");
                });

            modelBuilder.Entity("SP.DAL.Models.BD_Bangladesh", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("BD_Bangladesh");
                });

            modelBuilder.Entity("SP.DAL.Models.BE_Belgium", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("BE_Belgium");
                });

            modelBuilder.Entity("SP.DAL.Models.BG_Bulgaria", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("BG_Bulgaria");
                });

            modelBuilder.Entity("SP.DAL.Models.BR_Brazil", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("BR_Brazil");
                });

            modelBuilder.Entity("SP.DAL.Models.BY_Belarus", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("BY_Belarus");
                });

            modelBuilder.Entity("SP.DAL.Models.CA_Canada", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("CA_Canada");
                });

            modelBuilder.Entity("SP.DAL.Models.CH_Switzerland", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("CH_Switzerland");
                });

            modelBuilder.Entity("SP.DAL.Models.CO_Colombia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("CO_Colombia");
                });

            modelBuilder.Entity("SP.DAL.Models.CR_CostaRica", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("CR_CostaRica");
                });

            modelBuilder.Entity("SP.DAL.Models.CZ_Czechia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("CZ_Czechia");
                });

            modelBuilder.Entity("SP.DAL.Models.DE_Germany", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("DE_Germany");
                });

            modelBuilder.Entity("SP.DAL.Models.DK_Denmark", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("DK_Denmark");
                });

            modelBuilder.Entity("SP.DAL.Models.DO_DominicanRepublic", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("DO_DominicanRepublic");
                });

            modelBuilder.Entity("SP.DAL.Models.DZ_Algeria", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("DZ_Algeria");
                });

            modelBuilder.Entity("SP.DAL.Models.ES_Spain", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("ES_Spain");
                });

            modelBuilder.Entity("SP.DAL.Models.FI_Finland", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("FI_Finland");
                });

            modelBuilder.Entity("SP.DAL.Models.FO_FaroeIslands", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("FO_FaroeIslands");
                });

            modelBuilder.Entity("SP.DAL.Models.FR_France", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("FR_France");
                });

            modelBuilder.Entity("SP.DAL.Models.GB_UnitedKingdom", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("GB_UnitedKingdom");
                });

            modelBuilder.Entity("SP.DAL.Models.GF_FrenchGuiana", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("GF_FrenchGuiana");
                });

            modelBuilder.Entity("SP.DAL.Models.GG_Guernsey", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("GG_Guernsey");
                });

            modelBuilder.Entity("SP.DAL.Models.GL_Greenland", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("GL_Greenland");
                });

            modelBuilder.Entity("SP.DAL.Models.GP_Guadeloupe", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("GP_Guadeloupe");
                });

            modelBuilder.Entity("SP.DAL.Models.GT_Guatemala", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("GT_Guatemala");
                });

            modelBuilder.Entity("SP.DAL.Models.GU_Guam", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("GU_Guam");
                });

            modelBuilder.Entity("SP.DAL.Models.HR_Croatia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("HR_Croatia");
                });

            modelBuilder.Entity("SP.DAL.Models.HU_Hungary", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("HU_Hungary");
                });

            modelBuilder.Entity("SP.DAL.Models.IE_Ireland", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("IE_Ireland");
                });

            modelBuilder.Entity("SP.DAL.Models.IM_IsleofMan", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("IM_IsleofMan");
                });

            modelBuilder.Entity("SP.DAL.Models.IN_India", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("IN_India");
                });

            modelBuilder.Entity("SP.DAL.Models.IS_Iceland", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("IS_Iceland");
                });

            modelBuilder.Entity("SP.DAL.Models.IT_Italy", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("IT_Italy");
                });

            modelBuilder.Entity("SP.DAL.Models.JE_Jersey", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("JE_Jersey");
                });

            modelBuilder.Entity("SP.DAL.Models.JP_Japan", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("JP_Japan");
                });

            modelBuilder.Entity("SP.DAL.Models.LI_Liechtenstein", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("LI_Liechtenstein");
                });

            modelBuilder.Entity("SP.DAL.Models.LK_SriLanka", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("LK_SriLanka");
                });

            modelBuilder.Entity("SP.DAL.Models.LT_Lithuania", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("LT_Lithuania");
                });

            modelBuilder.Entity("SP.DAL.Models.LU_Luxembourg", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("LU_Luxembourg");
                });

            modelBuilder.Entity("SP.DAL.Models.MC_Monaco", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MC_Monaco");
                });

            modelBuilder.Entity("SP.DAL.Models.MD_Moldova", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MD_Moldova");
                });

            modelBuilder.Entity("SP.DAL.Models.MH_MarshallIslands", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MH_MarshallIslands");
                });

            modelBuilder.Entity("SP.DAL.Models.MK_Macedonia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MK_Macedonia");
                });

            modelBuilder.Entity("SP.DAL.Models.MP_NorthernMarianaIslands", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MP_NorthernMarianaIslands");
                });

            modelBuilder.Entity("SP.DAL.Models.MQ_Martinique", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MQ_Martinique");
                });

            modelBuilder.Entity("SP.DAL.Models.MT_Malta", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MT_Malta");
                });

            modelBuilder.Entity("SP.DAL.Models.MX_Mexico", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MX_Mexico");
                });

            modelBuilder.Entity("SP.DAL.Models.MY_Malaysia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("MY_Malaysia");
                });

            modelBuilder.Entity("SP.DAL.Models.NC_NewCaledonia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("NC_NewCaledonia");
                });

            modelBuilder.Entity("SP.DAL.Models.NL_Netherlands", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("NL_Netherlands");
                });

            modelBuilder.Entity("SP.DAL.Models.NO_Norway", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("NO_Norway");
                });

            modelBuilder.Entity("SP.DAL.Models.NZ_NewZealand", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("NZ_NewZealand");
                });

            modelBuilder.Entity("SP.DAL.Models.PH_Philippines", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("PH_Philippines");
                });

            modelBuilder.Entity("SP.DAL.Models.PK_Pakistan", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("PK_Pakistan");
                });

            modelBuilder.Entity("SP.DAL.Models.PL_Poland", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("PL_Poland");
                });

            modelBuilder.Entity("SP.DAL.Models.PM_St_PierreAndMiquelon", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("PM_St_PierreAndMiquelon");
                });

            modelBuilder.Entity("SP.DAL.Models.PR_PuertoRico", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("PR_PuertoRico");
                });

            modelBuilder.Entity("SP.DAL.Models.PT_Portugal", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("PT_Portugal");
                });

            modelBuilder.Entity("SP.DAL.Models.RE_Reunion", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("RE_Reunion");
                });

            modelBuilder.Entity("SP.DAL.Models.RO_Romania", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("RO_Romania");
                });

            modelBuilder.Entity("SP.DAL.Models.RU_Russia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("RU_Russia");
                });

            modelBuilder.Entity("SP.DAL.Models.SE_Sweden", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("SE_Sweden");
                });

            modelBuilder.Entity("SP.DAL.Models.SI_Slovenia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("SI_Slovenia");
                });

            modelBuilder.Entity("SP.DAL.Models.SJ_SvalbardAndJanMayen", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("SJ_SvalbardAndJanMayen");
                });

            modelBuilder.Entity("SP.DAL.Models.SK_Slovakia", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("SK_Slovakia");
                });

            modelBuilder.Entity("SP.DAL.Models.SM_SanMarino", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("SM_SanMarino");
                });

            modelBuilder.Entity("SP.DAL.Models.SPUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SP.DAL.Models.TH_Thailand", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("TH_Thailand");
                });

            modelBuilder.Entity("SP.DAL.Models.TR_Turkey", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("TR_Turkey");
                });

            modelBuilder.Entity("SP.DAL.Models.US_UnitedStates", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("US_UnitedStates");
                });

            modelBuilder.Entity("SP.DAL.Models.VA_VaticanCity", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("VA_VaticanCity");
                });

            modelBuilder.Entity("SP.DAL.Models.VI_US_VirginIslands", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("VI_US_VirginIslands");
                });

            modelBuilder.Entity("SP.DAL.Models.WF_WallisAndFutuna", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("WF_WallisAndFutuna");
                });

            modelBuilder.Entity("SP.DAL.Models.YT_Mayotte", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("YT_Mayotte");
                });

            modelBuilder.Entity("SP.DAL.Models.ZA_SouthAfrica", b =>
                {
                    b.Property<int>("GeoNameTxtID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracy");

                    b.Property<string>("communitycode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("communityname")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("countrycode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("countyorprovincecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("countyorprovincename")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("placename")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statecode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("statename")
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeoNameTxtID");

                    b.ToTable("ZA_SouthAfrica");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SP.DAL.Models.SPUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SP.DAL.Models.SPUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SP.DAL.Models.SPUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
