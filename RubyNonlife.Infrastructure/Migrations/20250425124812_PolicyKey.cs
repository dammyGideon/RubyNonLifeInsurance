using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubyNonlife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PolicyKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PolicyKey",
                table: "PolicyBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7456), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7458), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7459), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6530), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "CalculationsParameters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6532), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7929), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7931), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7933), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7934), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7936), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7937), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7938), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7939), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7942), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8025), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8027), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8030), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8033), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8034), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8035), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8036), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8037), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8038), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8040), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8041), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8042), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8043), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8044), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8046), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8047), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8048), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8049), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8050), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8051), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8052), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8053), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8054), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8055), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8056), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8057), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8058), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8059), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8060), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8061), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8062), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8064), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8065), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8066), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8067), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8069), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8070), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8071), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8072), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8073), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8074), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8075), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8076), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(8077), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6611), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "CollectionSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6612), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7220), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7222), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7223), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "CostOfInsuranceFrequencies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6351), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "CoversRiderLimits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6353), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6779), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6780), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6782), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "DatatypeLengths",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6783), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6868), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6871), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Datatypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6872), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(9069), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(9070), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "FeeLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(9072), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8826), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8830), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8831), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8833), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8834), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8835), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8836), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8837), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8839), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8840), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8841), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8842), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8843), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8844), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8845), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8846), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8848), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8849), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8850), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8851), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8852), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8853), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8855), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8856), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8857), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8858), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8859), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8860), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8861), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8862), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8863), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8866), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8867), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8868), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8869), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8870), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8871), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8872), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8873), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8874), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8875), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8876), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8877), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8878), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8879), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8880), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8881), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8882), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8883), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8884), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8885), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8886), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8887), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8888), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8890), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8891), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8892), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8894), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8895), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8897), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8899), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8901), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8902), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8903), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8904), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8905), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8906), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8907), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8908), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8909), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8910), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8911), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8912), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8913), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8914), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8915), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8916), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8917), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8922), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8924), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8925), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8926), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8927), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8928), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8929), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8930), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8931), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8932), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8933), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8934), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8935), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8936), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8937), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8938), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8939), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8940), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8941), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentAreaLookups",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8942), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6433), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6434), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6434), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6435), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6436), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6437), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6437), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6438), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6438), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6439), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6440), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6440), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateTime", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6441), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6441), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8584), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "PolicyAdditionalInformation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8585), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8182), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingBeneficiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8183), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8499), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8500), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8501), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8502), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8503), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingInsurers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8504), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8741), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "PolicyBookingPaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8742), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8419), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8420), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8421), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8422), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "PolicyBrokers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8423), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8340), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8342), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8659), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8660), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "PolicyBusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7057), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7058), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "PolicyDocumentSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7303), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6692), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6693), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6694), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "PolicyDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6695), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7533), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7544), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7545), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "PolicyDurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7548), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7139), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "PriceRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6041), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6044), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6046), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6047), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6049), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6050), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "ProductClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6052), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6248), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6250), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6251), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6253), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6254), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7712), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "QuoteChannels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7714), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7385), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "QuotePreferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7387), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7633), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "QuoteTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 13, 48, 11, 394, DateTimeKind.Local).AddTicks(7640), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7791), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7794), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7795), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7796), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7799), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7801), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7802), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7804), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7806), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7808), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7813), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7814), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7815), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7816), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7818), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7819), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7820), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7822), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7824), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7825), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7828), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7829), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7830), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "UpdateDated" },
                values: new object[] { new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7831), new DateTime(2025, 4, 25, 12, 48, 11, 394, DateTimeKind.Utc).AddTicks(7831) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PolicyKey",
                table: "PolicyBookings");

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
    }
}
