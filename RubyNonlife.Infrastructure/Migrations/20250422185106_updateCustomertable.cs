using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubyNonlife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCustomertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTitles",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MaritalStatuses",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Religion",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HasPendingModificationRequest",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RmId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "LeadId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceivableLedger",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTitleLookups_TitleId",
                table: "Customers",
                column: "TitleId",
                principalTable: "CustomerTitleLookups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MaritalStatusLookup_MaritalStatusId",
                table: "Customers",
                column: "MaritalStatusId",
                principalTable: "MaritalStatusLookup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_ReligionLookup_ReligionId",
                table: "Customers",
                column: "ReligionId",
                principalTable: "ReligionLookup",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTitleLookups_TitleId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MaritalStatusLookup_MaritalStatusId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_ReligionLookup_ReligionId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FullAddress",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ReceivableLedger",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "LeadId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasPendingModificationRequest",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RmId",
                table: "Customers",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTitles",
                table: "Customers",
                column: "TitleId",
                principalTable: "CustomerTitleLookups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MaritalStatuses",
                table: "Customers",
                column: "MaritalStatusId",
                principalTable: "MaritalStatusLookup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Religion",
                table: "Customers",
                column: "ReligionId",
                principalTable: "ReligionLookup",
                principalColumn: "Id");
        }
    }
}
