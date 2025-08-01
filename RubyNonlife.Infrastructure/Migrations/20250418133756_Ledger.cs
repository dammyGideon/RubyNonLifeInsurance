using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubyNonlife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Ledger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LedgerGroupKey",
                table: "BookingOperationalSettlementDetails",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LedgerGroupKey",
                table: "BookingOperationalSettlementDetails");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6933), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6935), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6936), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5855), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5856), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7719), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7721), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7722), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7726), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7730), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7732), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7733), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7839), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7842), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7843), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7845), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7846), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7847), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7849), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7850), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7851), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7853), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7854), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7855), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7857), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7858), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7860), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7861), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7862), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7864), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7865), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7866), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7871), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7884), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7885), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7887), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7888), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7889), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7891), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7892), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7894), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7895), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7901), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7904), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7905), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7907), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7908), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7909), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7912), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7914), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7915), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7916), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7918), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7919), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7921), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7922), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5957), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5959), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6600), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6602), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6604), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6605), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5630), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5632), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6175), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6177), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6179), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6181), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6280), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6282), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6284), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6286), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(9413), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(9415), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(9416), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9062), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9065), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9067), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9068), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9070), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9072), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9073), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9075), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9076), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9078), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9080), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9081), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9082), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9084), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9085), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9086), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9088), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9090), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9095), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9098), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9099), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9100), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9102), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9103), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9104), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9106), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9107), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9108), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9109), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9111), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9112), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9115), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9117), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9118), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9120), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9121), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9122), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9124), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9125), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9126), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9128), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9129), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9130), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9132), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9134), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9136), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9137), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9138), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9140), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9141), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9142), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9143), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9145), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9146), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9147), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9149), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9150), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9152), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9153), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9154), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9156), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9157), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9158), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9161), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9162), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9164), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9165), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9166), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9168), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9169), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9170), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9171), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9173), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9174), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9175), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9177), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9178), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9179), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9181), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9182), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9183), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9185), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9186), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9187), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9189), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9190), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9191), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9192), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9194), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9195), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9196), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9197), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9199), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9200), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9201), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9203), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9204), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9205), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9206), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9208), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5736), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5737), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5738), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5739), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5740), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5742), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5743), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5745), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5746), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5747), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8112), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8113), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8562), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8564), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8565), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8567), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8568), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8569), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8959), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8961), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8427), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8429), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8431), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8432), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8433), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8295), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8827), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8830), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6394), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6396), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6708), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6066), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6068), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6069), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6075), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7049), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7052), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7054), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6493), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6495), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6496), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6497), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5256), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5259), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5263), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5265), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5266), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5268), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5270), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5506), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5515), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5516), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5518), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5519), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7413), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7415), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6843), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6844), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7313), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7315), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7535), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7539), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7540), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7542), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7543), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7545), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7547), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7548), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7549), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7551), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7553), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7554), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7559), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7562), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7563), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7565), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7568), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7571), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7572), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7573), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7574), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7576), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7577), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7578), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7579), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7581), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7582), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7583), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7584), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7586), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7587), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7589), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7591), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7592), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7593), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7594) });
        }
    }
}
