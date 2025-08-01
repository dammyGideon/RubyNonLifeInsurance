using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubyNonlife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostingType",
                table: "BookingOperationalSettlementDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionVoucher",
                table: "BookingOperationalSettlementDetails",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostingType",
                table: "BookingOperationalSettlementDetails");

            migrationBuilder.DropColumn(
                name: "TransactionVoucher",
                table: "BookingOperationalSettlementDetails");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(654), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(656), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(658), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9556), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9558), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1431), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1433), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1434), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1436), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1437), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1438), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1439), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1441), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1442), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1443), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1445), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1446), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1447), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1448), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1450), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1578), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1581), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1582), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1584), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1587), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1588), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1589), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1591), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1592), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1595), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1596), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1598), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1599), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1601), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1602), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1603), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1605), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1606), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1611), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1624), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1626), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1627), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1628), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1630), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1631), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1633), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1634), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1635), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1637), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1638), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1640), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1641), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1642), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1644), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1645), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1646), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1648), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1649), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1651), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1652), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1658), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1660), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1661), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9668), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9670), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(336), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(337), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(339), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(341), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9314), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9315), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9903), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9905), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9906), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9908), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(16), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(18), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(19), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(21), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(2991), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(2993), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(2995), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2609), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2612), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2614), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2615), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2617), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2619), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2621), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2622), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2623), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2627), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2628), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2630), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2631), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2632), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2634), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2635), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2637), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2639), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2640), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2641), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2643), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2644), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2646), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2648), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2650), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2651), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2652), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2654), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2660), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2663), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2665), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2667), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2669), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2671), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2675), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2676), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2677), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2679), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2680), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2682), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2683), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2684), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2686), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2687), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2688), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2690), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2691), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2692), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2694), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2695), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2696), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2698), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2699), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2700), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2702), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2703), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2704), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2706), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2707), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2709), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2712), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2713), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2715), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2716), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2719), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2720), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2721), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2723), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2724), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2725), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2727), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2728), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2729), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2731), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2732), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2733), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2735), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2736), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2737), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2738), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2740), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2741), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2742), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2744), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2745), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2746), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2748), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2749), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2750), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2751), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2753), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2754), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2755), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2757), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9427), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9428), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9429), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9430), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9431), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9432), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9433), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9434), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9435), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9436), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9436), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9437), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9438), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9439), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2253), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2254), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1799), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1801), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2139), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2140), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2141), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2143), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2144), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2145), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2503), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2505), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2011), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2012), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2014), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2015), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2016), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1903), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2356), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2358), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2359), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(126), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(128), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(443), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(444), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9785), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9787), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9788), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9794), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(854), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(865), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(867), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(869), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(870), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(229), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(231), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(232), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(233), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8918), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8921), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8923), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8925), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8927), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8929), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8931), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8933), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9182), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9195), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9196), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9198), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9200), new DateTime(2025, 4, 22, 18, 51, 5, 578, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1082), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(1084), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(552), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(553), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(982), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 51, 5, 579, DateTimeKind.Local).AddTicks(984), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1194), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1196), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1198), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1200), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1201), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1203), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1205), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1206), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1207), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1210), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1211), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1212), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1213), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1216), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1217), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1218), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1221), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1222), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1223), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1229), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1231), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1232), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1233), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1234), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1235), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1237), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1238), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1239), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1240), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1241), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1243), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1244), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1246), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1247), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1248), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1250), new DateTime(2025, 4, 22, 18, 51, 5, 579, DateTimeKind.Utc).AddTicks(1250) });
        }
    }
}
