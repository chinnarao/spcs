using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SP.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "AD_Andorra",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_Andorra", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "AR_Argentina",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AR_Argentina", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "AS_AmericanSamoa",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AS_AmericanSamoa", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "AT_Austria",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AT_Austria", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "AU_Australia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AU_Australia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "AX_AlandIslands",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AX_AlandIslands", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "BD_Bangladesh",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BD_Bangladesh", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "BE_Belgium",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BE_Belgium", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "BG_Bulgaria",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BG_Bulgaria", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "BR_Brazil",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BR_Brazil", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "BY_Belarus",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BY_Belarus", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "CA_Canada",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CA_Canada", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "CH_Switzerland",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CH_Switzerland", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "CO_Colombia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_Colombia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "CR_CostaRica",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CR_CostaRica", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "CZ_Czechia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CZ_Czechia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "DE_Germany",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DE_Germany", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "DK_Denmark",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DK_Denmark", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "DO_DominicanRepublic",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DO_DominicanRepublic", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "DZ_Algeria",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DZ_Algeria", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "ES_Spain",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ES_Spain", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "FI_Finland",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FI_Finland", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "FO_FaroeIslands",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FO_FaroeIslands", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "FR_France",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FR_France", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "GB_UnitedKingdom",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GB_UnitedKingdom", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "GF_FrenchGuiana",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GF_FrenchGuiana", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "GG_Guernsey",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GG_Guernsey", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "GL_Greenland",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GL_Greenland", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "GP_Guadeloupe",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_Guadeloupe", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "GT_Guatemala",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GT_Guatemala", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "GU_Guam",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GU_Guam", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Croatia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Croatia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "HU_Hungary",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HU_Hungary", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "IE_Ireland",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IE_Ireland", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "IM_IsleofMan",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IM_IsleofMan", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "IN_India",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IN_India", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "IS_Iceland",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IS_Iceland", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "IT_Italy",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IT_Italy", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "JE_Jersey",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JE_Jersey", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "JP_Japan",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JP_Japan", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "LI_Liechtenstein",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LI_Liechtenstein", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "LK_SriLanka",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LK_SriLanka", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "LT_Lithuania",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_Lithuania", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "LU_Luxembourg",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LU_Luxembourg", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MC_Monaco",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MC_Monaco", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MD_Moldova",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MD_Moldova", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MH_MarshallIslands",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MH_MarshallIslands", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MK_Macedonia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MK_Macedonia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MP_NorthernMarianaIslands",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MP_NorthernMarianaIslands", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MQ_Martinique",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MQ_Martinique", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MT_Malta",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MT_Malta", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MX_Mexico",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MX_Mexico", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "MY_Malaysia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MY_Malaysia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "NC_NewCaledonia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NC_NewCaledonia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "NL_Netherlands",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NL_Netherlands", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "NO_Norway",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NO_Norway", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "NZ_NewZealand",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NZ_NewZealand", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "PH_Philippines",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PH_Philippines", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "PK_Pakistan",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PK_Pakistan", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "PL_Poland",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PL_Poland", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "PM_St_PierreAndMiquelon",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PM_St_PierreAndMiquelon", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "PR_PuertoRico",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR_PuertoRico", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "PT_Portugal",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PT_Portugal", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "RE_Reunion",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RE_Reunion", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "RO_Romania",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RO_Romania", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "RU_Russia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RU_Russia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "SE_Sweden",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SE_Sweden", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "SI_Slovenia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SI_Slovenia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "SJ_SvalbardAndJanMayen",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SJ_SvalbardAndJanMayen", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "SK_Slovakia",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SK_Slovakia", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SanMarino",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SanMarino", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TH_Thailand",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TH_Thailand", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "TR_Turkey",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_Turkey", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "US_UnitedStates",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_US_UnitedStates", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "VA_VaticanCity",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VA_VaticanCity", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "VI_US_VirginIslands",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VI_US_VirginIslands", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "WF_WallisAndFutuna",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WF_WallisAndFutuna", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "YT_Mayotte",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YT_Mayotte", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "ZA_SouthAfrica",
                columns: table => new
                {
                    GeoNameTxtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<int>(nullable: false),
                    communitycode = table.Column<string>(type: "varchar(20)", nullable: true),
                    communityname = table.Column<string>(type: "varchar(100)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(2)", nullable: false),
                    countyorprovincecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    countyorprovincename = table.Column<string>(type: "varchar(100)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    placename = table.Column<string>(type: "varchar(180)", nullable: false),
                    postalcode = table.Column<string>(type: "varchar(20)", nullable: false),
                    statecode = table.Column<string>(type: "varchar(20)", nullable: true),
                    statename = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZA_SouthAfrica", x => x.GeoNameTxtID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AD_Andorra");

            migrationBuilder.DropTable(
                name: "AR_Argentina");

            migrationBuilder.DropTable(
                name: "AS_AmericanSamoa");

            migrationBuilder.DropTable(
                name: "AT_Austria");

            migrationBuilder.DropTable(
                name: "AU_Australia");

            migrationBuilder.DropTable(
                name: "AX_AlandIslands");

            migrationBuilder.DropTable(
                name: "BD_Bangladesh");

            migrationBuilder.DropTable(
                name: "BE_Belgium");

            migrationBuilder.DropTable(
                name: "BG_Bulgaria");

            migrationBuilder.DropTable(
                name: "BR_Brazil");

            migrationBuilder.DropTable(
                name: "BY_Belarus");

            migrationBuilder.DropTable(
                name: "CA_Canada");

            migrationBuilder.DropTable(
                name: "CH_Switzerland");

            migrationBuilder.DropTable(
                name: "CO_Colombia");

            migrationBuilder.DropTable(
                name: "CR_CostaRica");

            migrationBuilder.DropTable(
                name: "CZ_Czechia");

            migrationBuilder.DropTable(
                name: "DE_Germany");

            migrationBuilder.DropTable(
                name: "DK_Denmark");

            migrationBuilder.DropTable(
                name: "DO_DominicanRepublic");

            migrationBuilder.DropTable(
                name: "DZ_Algeria");

            migrationBuilder.DropTable(
                name: "ES_Spain");

            migrationBuilder.DropTable(
                name: "FI_Finland");

            migrationBuilder.DropTable(
                name: "FO_FaroeIslands");

            migrationBuilder.DropTable(
                name: "FR_France");

            migrationBuilder.DropTable(
                name: "GB_UnitedKingdom");

            migrationBuilder.DropTable(
                name: "GF_FrenchGuiana");

            migrationBuilder.DropTable(
                name: "GG_Guernsey");

            migrationBuilder.DropTable(
                name: "GL_Greenland");

            migrationBuilder.DropTable(
                name: "GP_Guadeloupe");

            migrationBuilder.DropTable(
                name: "GT_Guatemala");

            migrationBuilder.DropTable(
                name: "GU_Guam");

            migrationBuilder.DropTable(
                name: "HR_Croatia");

            migrationBuilder.DropTable(
                name: "HU_Hungary");

            migrationBuilder.DropTable(
                name: "IE_Ireland");

            migrationBuilder.DropTable(
                name: "IM_IsleofMan");

            migrationBuilder.DropTable(
                name: "IN_India");

            migrationBuilder.DropTable(
                name: "IS_Iceland");

            migrationBuilder.DropTable(
                name: "IT_Italy");

            migrationBuilder.DropTable(
                name: "JE_Jersey");

            migrationBuilder.DropTable(
                name: "JP_Japan");

            migrationBuilder.DropTable(
                name: "LI_Liechtenstein");

            migrationBuilder.DropTable(
                name: "LK_SriLanka");

            migrationBuilder.DropTable(
                name: "LT_Lithuania");

            migrationBuilder.DropTable(
                name: "LU_Luxembourg");

            migrationBuilder.DropTable(
                name: "MC_Monaco");

            migrationBuilder.DropTable(
                name: "MD_Moldova");

            migrationBuilder.DropTable(
                name: "MH_MarshallIslands");

            migrationBuilder.DropTable(
                name: "MK_Macedonia");

            migrationBuilder.DropTable(
                name: "MP_NorthernMarianaIslands");

            migrationBuilder.DropTable(
                name: "MQ_Martinique");

            migrationBuilder.DropTable(
                name: "MT_Malta");

            migrationBuilder.DropTable(
                name: "MX_Mexico");

            migrationBuilder.DropTable(
                name: "MY_Malaysia");

            migrationBuilder.DropTable(
                name: "NC_NewCaledonia");

            migrationBuilder.DropTable(
                name: "NL_Netherlands");

            migrationBuilder.DropTable(
                name: "NO_Norway");

            migrationBuilder.DropTable(
                name: "NZ_NewZealand");

            migrationBuilder.DropTable(
                name: "PH_Philippines");

            migrationBuilder.DropTable(
                name: "PK_Pakistan");

            migrationBuilder.DropTable(
                name: "PL_Poland");

            migrationBuilder.DropTable(
                name: "PM_St_PierreAndMiquelon");

            migrationBuilder.DropTable(
                name: "PR_PuertoRico");

            migrationBuilder.DropTable(
                name: "PT_Portugal");

            migrationBuilder.DropTable(
                name: "RE_Reunion");

            migrationBuilder.DropTable(
                name: "RO_Romania");

            migrationBuilder.DropTable(
                name: "RU_Russia");

            migrationBuilder.DropTable(
                name: "SE_Sweden");

            migrationBuilder.DropTable(
                name: "SI_Slovenia");

            migrationBuilder.DropTable(
                name: "SJ_SvalbardAndJanMayen");

            migrationBuilder.DropTable(
                name: "SK_Slovakia");

            migrationBuilder.DropTable(
                name: "SM_SanMarino");

            migrationBuilder.DropTable(
                name: "TH_Thailand");

            migrationBuilder.DropTable(
                name: "TR_Turkey");

            migrationBuilder.DropTable(
                name: "US_UnitedStates");

            migrationBuilder.DropTable(
                name: "VA_VaticanCity");

            migrationBuilder.DropTable(
                name: "VI_US_VirginIslands");

            migrationBuilder.DropTable(
                name: "WF_WallisAndFutuna");

            migrationBuilder.DropTable(
                name: "YT_Mayotte");

            migrationBuilder.DropTable(
                name: "ZA_SouthAfrica");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
