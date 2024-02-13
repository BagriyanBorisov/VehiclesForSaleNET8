using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclesForSale.Data.Migrations
{
    /// <inheritdoc />
    public partial class addStatusToVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublicationStatus",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "c5d458c2-1bdd-404d-9849-3644f12b7cec", "AQAAAAIAAYagAAAAENSjD9ZCvDTfTXLf7Xa3x7Wb3TFtVH1IJH8g+2c9/vwV8tFcFa/BPx92xvOoqupZWg==", new DateTime(2024, 2, 12, 17, 8, 43, 280, DateTimeKind.Utc).AddTicks(5945), "d9c79989-3a42-4eca-a730-bc5da4f41c5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a123as23-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "1b00051d-59f5-4c13-ab3a-ba92ac7fe40c", "AQAAAAIAAYagAAAAECsfUfjpKQBmbsEgr5XQ8esLjj9lwjgHrEF1SxSzo+D9D15UOzChvfpncButtxYUYA==", new DateTime(2024, 2, 12, 17, 8, 43, 330, DateTimeKind.Utc).AddTicks(9234), "38681c75-d7a3-4ccf-926a-d48f24db6f2b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicationStatus",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "8e9308d9-ad60-4822-a9cf-8f0b5e13c552", "AQAAAAIAAYagAAAAEBR+oD7finzAIhMZsckMG8T9jpQbyoEBvqHDhFq84kirJvvuh1rdbaNWFt7PDr1c4Q==", new DateTime(2024, 2, 12, 16, 10, 30, 379, DateTimeKind.Utc).AddTicks(5958), "cfd7b343-2dd5-4c20-8e4e-e89f91cbdea7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a123as23-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "63bf68dc-6029-467d-a288-27d0c2adf405", "AQAAAAIAAYagAAAAEDBIMoS5NcD4huRrmOAZV6k1C91kSK05bmslAVeXAe5iixSA6YBGSVaUjABZYM2F2A==", new DateTime(2024, 2, 12, 16, 10, 30, 428, DateTimeKind.Utc).AddTicks(5534), "1cc0f87e-8c6f-4aca-911c-fb02926eeac9" });
        }
    }
}
