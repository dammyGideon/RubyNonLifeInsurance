using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubyNonlife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateledger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayableLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayableLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayableLedgers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7580), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7585), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7588), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(287), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(291), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(299), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(303), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(310), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(313), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(316), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(319), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(345), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(349), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(352), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(355), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(358), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(361), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(364), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(367), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(997), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1008), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1012), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1016), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1019), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1022), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1026), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1029), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1032), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1036), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1039), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1042), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1046), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1087), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1090), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1093), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1097), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1100), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1104), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1107), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1121), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1145), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1149), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1152), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1155), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1158), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1162), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1165), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1169), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1172), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1175), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1178), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1182), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1185), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1189), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1192), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1195), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1199), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1202), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1205), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1209), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1212), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1215), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1218), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(1222), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(748), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(752), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6176), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6180), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9312), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9316), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2838), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2845), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2850), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2854), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4228), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4235), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4240), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4243), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(7172), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(7189), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 123, DateTimeKind.Local).AddTicks(7194), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5899), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5919), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5922), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5933), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5940), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5951), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5954), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5957), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5960), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5963), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5967), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5970), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5973), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5979), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5982), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5985), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5988), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5991), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6000), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6003), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6006), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6009), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6012), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6016), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6019), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6022), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6028), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6031), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6038), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6041), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6044), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6048), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6051), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6057), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6061), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6064), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6067), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6070), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6073), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6076), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6079), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6082), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6086), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6089), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6092), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6095), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6099), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6102), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6105), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6110), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6117), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6123), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6126), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6129), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6132), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6135), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6138), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6177), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6180), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6187), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6190), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6193), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6196), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6200), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6203), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6206), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6209), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6213), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6216), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6219), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6222), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6225), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6232), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6235), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6238), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6241), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6245), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6248), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6251), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6254), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6257), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6261), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6264), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6267), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6270), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6273), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6276), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6279), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6283), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6286), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6289), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9793), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9798), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9800), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9802), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9803), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9805), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9807), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9809), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9811), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9817), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9819), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9821), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4060), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4066), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1922), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1929), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3411), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3416), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3419), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3421), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3424), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3427), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5356), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5363), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2880), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2887), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2890), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2893), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2896), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2387), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2393), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4584), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4590), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4593), new DateTime(2025, 4, 21, 22, 7, 29, 123, DateTimeKind.Utc).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5145), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5149), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6635), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6639), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1811), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1817), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1820), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1837), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(8075), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(8102), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(8107), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(8111), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(8116), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5718), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5723), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5726), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5728), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7897), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7903), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7908), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7950), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7954), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7958), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7963), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8817), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8822), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8825), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 4, 21, 22, 7, 29, 121, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(9056), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(9064), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7080), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7084), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(8605), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 7, 29, 122, DateTimeKind.Local).AddTicks(8614), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9484), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9499), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9503), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9506), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9509), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9518), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9521), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9524), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9527), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9533), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9536), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9539), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9542), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9545), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9548), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9551), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9559), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9562), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9565), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9568), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9571), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9574), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9577), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9580), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9583), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9586), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9589), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9592), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9595), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9598), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9601), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9604), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9609), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9613), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9616), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9618), new DateTime(2025, 4, 21, 22, 7, 29, 122, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.CreateIndex(
                name: "IX_PayableLedgers_ProductId",
                table: "PayableLedgers",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayableLedgers");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9891), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9892), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9893), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8960), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8961), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(374), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(375), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(376), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(377), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(378), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(379), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(380), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(381), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(382), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(383), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(384), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(385), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(386), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(388), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(475), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(477), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(478), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(479), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(480), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(482), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(484), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(485), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(487), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(488), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(489), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(490), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(491), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(492), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(493), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(494), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(495), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(496), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(498), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(499), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(507), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(508), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(509), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(511), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(513), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(514), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(515), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(516), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(517), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(518), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(519), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(520), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(521), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(522), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(523), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(524), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(525), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(526), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(527), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(528), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9034), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9035), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9633), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9634), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9635), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9636), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8783), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8785), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9205), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9207), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9208), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9209), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9289), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9290), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9291), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9293), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(1542), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(1543), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(1544), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1276), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1279), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1280), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1281), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1283), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1284), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1285), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1286), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1288), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1289), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1290), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1292), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1293), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1294), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1295), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1312), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1314), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1316), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1317), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1318), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1319), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1321), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1322), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1323), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1324), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1325), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1326), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1327), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1328), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1329), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1330), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1332), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1333), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1335), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1336), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1337), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1338), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1339), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1340), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1341), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1343), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1344), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1345), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1346), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1347), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1348), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1349), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1350), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1351), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1352), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1353), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1354), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1355), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1356), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1357), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1358), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1359), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1360), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1361), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1362), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1363), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1364), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1365), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1366), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1368), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1370), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1371), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1372), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1373), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1374), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1375), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1376), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1377), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1378), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1379), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1380), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1381), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1382), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1383), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1384), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1385), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1386), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1387), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1388), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1389), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1390), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1391), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1392), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1393), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1394), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1395), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1396), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1397), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1398), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1399), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1400), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1401), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1402), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1403), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1405), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1406), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8861), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8862), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8862), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8863), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8865), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8865), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8866), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8866), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8867), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8868), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8868), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8869), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8870), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1021), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1023), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(631), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(632), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(942), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(943), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(944), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(945), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(946), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(947), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1188), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1189), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(861), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(862), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(863), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(864), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(865), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(773), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(774), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1110), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1111), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1112), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9476), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9478), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9713), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9714), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9115), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9116), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9117), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9119), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 703, DateTimeKind.Local).AddTicks(9985), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 703, DateTimeKind.Local).AddTicks(9994), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 703, DateTimeKind.Local).AddTicks(9995), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 703, DateTimeKind.Local).AddTicks(9996), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 703, DateTimeKind.Local).AddTicks(9998), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9553), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9555), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9556), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8506), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8508), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8510), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8511), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8513), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8514), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8516), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8517), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8691), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8693), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8695), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(151), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9819), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9821), new DateTime(2025, 4, 18, 13, 37, 55, 703, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(78), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 14, 37, 55, 704, DateTimeKind.Local).AddTicks(80), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(232), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(235), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(236), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(237), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(238), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(240), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(241), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(246), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(248), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(250), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(252), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(253), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(254), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(255), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(256), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(257), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(258), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(259), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(260), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(261), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(262), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(263), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(265), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(266), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(267), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(268), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(269), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(270), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(271), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(272), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(273), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(274), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(275), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(276), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(277), new DateTime(2025, 4, 18, 13, 37, 55, 704, DateTimeKind.Utc).AddTicks(278) });
        }
    }
}
