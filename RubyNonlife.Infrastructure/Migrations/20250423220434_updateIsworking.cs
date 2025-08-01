using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubyNonlife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateIsworking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isCustomerAccountNumber",
                table: "BookingOperationalSettlementDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3555), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2397), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2405), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4163), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4165), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4166), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4167), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4168), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4169), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4171), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4173), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4174), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4175), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4177), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4178), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4179), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4180), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4298), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4300), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4302), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4305), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4306), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4307), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4309), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4310), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4311), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4312), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4314), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4315), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4316), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4318), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4319), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4320), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4322), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4323), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4324), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4329), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4346), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4353), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4355), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4356), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4357), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4359), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4360), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4361), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4363), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4364), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4365), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4367), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4368), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4369), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4371), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4372), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4373), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4375), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4376), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4377), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4379), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4380), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(4383), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2521), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2523), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3178), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3180), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3181), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3183), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2120), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2122), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2751), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2753), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2755), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2757), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2867), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2869), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2871), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2872), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(5689), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(5691), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(5692), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5320), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5330), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5332), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5333), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5334), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5337), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5338), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5339), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5341), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5343), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5344), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5346), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5347), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5348), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5354), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5357), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5358), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5361), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5362), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5363), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5365), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5366), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5367), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5368), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5370), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5371), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5372), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5374), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5375), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5376), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5377), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5379), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5380), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5382), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5384), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5385), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5386), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5387), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5389), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5390), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5391), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5393), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5394), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5395), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5396), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5398), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5399), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5400), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5402), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5403), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5404), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5406), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5407), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5408), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5409), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5411), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5412), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5413), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5414), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5416), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5417), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5418), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5420), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5421), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5422), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5425), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5426), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5427), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5428), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5431), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5432), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5434), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5435), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5436), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5437), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5439), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5440), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5441), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5442), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5444), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5445), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5446), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5449), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5450), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5451), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5453), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5454), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5455), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5457), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5458), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5459), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5460), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5462), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5463), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5464), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5466), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5467), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5468), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5469), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5471), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2232), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2233), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2234), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2235), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2235), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2236), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2237), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2238), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2238), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2239), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2240), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2241), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2241), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2242), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4994), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4552), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4554), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4875), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4876), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4877), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4880), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4881), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5207), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5209), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4763), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4764), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4765), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4766), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4650), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4651), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5107), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5109), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5110), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2972), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2974), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3333), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3335), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2641), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2643), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2645), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2649), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3668), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3680), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3682), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3684), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3685), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3078), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3079), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3081), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3082), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1743), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1745), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1747), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1749), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1751), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1753), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1755), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1756), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1990), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1999), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2001), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2003), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2004), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3883), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3885), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3455), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3457), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3789), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 4, 33, 331, DateTimeKind.Local).AddTicks(3791), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3985), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3991), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4004), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4005), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4008), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4009), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4011), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4015), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4017), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4018), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4019), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4020), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4022), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4024), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4025), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4026), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4027), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4029), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4030), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4031), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4032), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4034), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4036), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4038), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 4, 23, 22, 4, 33, 331, DateTimeKind.Utc).AddTicks(4039) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isCustomerAccountNumber",
                table: "BookingOperationalSettlementDetails");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4843), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4846), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4847), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3332), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3335), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5761), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5763), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5765), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5767), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5769), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5770), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5772), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5774), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5775), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5777), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5778), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5780), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5782), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5783), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5785), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5929), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5932), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5935), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5937), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5938), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5940), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5942), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5944), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5945), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5947), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5949), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5951), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5952), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5954), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5956), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5958), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5960), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5961), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5963), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5965), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5970), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5983), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5985), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5987), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5989), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5990), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5992), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5994), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5996), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5997), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6004), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6008), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6009), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6011), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6013), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6015), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6016), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6018), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6020), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6022), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6023), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6025), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6027), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6029), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(6031), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3471), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3473), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4428), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4431), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4433), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4435), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3036), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3038), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3836), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3839), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3841), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3843), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3998), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(7659), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(7662), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7185), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7190), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7192), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7193), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7195), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7198), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7200), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7202), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7204), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7207), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7208), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7210), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7212), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7214), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7215), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7217), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7219), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7227), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7231), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7233), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7235), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7237), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7239), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7240), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7242), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7244), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7247), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7249), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7251), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7255), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7262), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7263), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7265), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7267), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7269), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7271), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7272), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7274), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7276), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7278), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7279), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7281), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7283), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7285), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7286), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7288), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7292), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7294), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7295), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7297), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7299), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7303), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7304), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7311), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7313), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7318), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7327), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7329), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7332), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7334), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7336), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7338), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7340), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7341), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7343), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7347), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7348), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7350), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7352), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7354), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7355), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7357), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7359), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7361), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7363), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7366), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7368), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7370), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7371), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7373), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7375), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7377), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7378), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7380), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7382), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3176), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3178), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3179), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3180), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3181), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3182), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3183), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3185), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3185), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3187), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3187), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3191), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6773), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6775), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6233), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6235), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6637), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6639), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6640), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6642), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6643), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6645), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7044), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7046), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6487), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6489), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6490), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6492), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6493), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6361), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6363), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6901), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6903), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6904), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4166), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4169), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4562), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4564), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3611), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3613), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3615), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3620), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5051), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5066), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5068), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5071), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5073), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4297), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4299), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4301), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4302), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2566), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2569), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2572), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2577), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2580), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2585), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2872), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2882), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2884), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2886), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2888), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5364), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5367), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4719), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4721), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5219), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 53, 55, 397, DateTimeKind.Local).AddTicks(5222), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5507), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5512), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5514), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5516), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5518), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5522), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5524), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5526), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5527), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5531), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5533), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5540), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5544), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5546), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5547), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5549), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5551), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5554), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5556), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5558), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5560), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5561), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5563), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5565), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5567), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5568), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5570), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5572), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5574), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5575), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5577), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5579), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5580), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5584), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5585), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5587), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5589), new DateTime(2025, 4, 23, 14, 53, 55, 397, DateTimeKind.Utc).AddTicks(5589) });
        }
    }
}
