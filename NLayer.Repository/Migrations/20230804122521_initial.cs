using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NYO_SOSYALYARDİM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCKIMLIKNO = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    MUSTERIAD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MUSTERISOYAD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ODEME_KD = table.Column<int>(type: "int", nullable: false),
                    ODENECEK_TTR = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    ODEME_TR = table.Column<DateTime>(type: "date", nullable: false),
                    ODEME_ACK = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NYO_SOSYALYARDİM", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NYO_SOSYALYARDİM",
                columns: new[] { "Id", "CreatedDate", "MUSTERIAD", "MUSTERISOYAD", "ODEME_ACK", "ODEME_KD", "ODEME_TR", "ODENECEK_TTR", "TCKIMLIKNO", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 4, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8265), "Ayşe", "Yılmaz", "Ürün satışı", 0, new DateTime(2023, 7, 20, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8246), 500.00m, "12345678901", null },
                    { 2, new DateTime(2023, 8, 4, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8267), "Mehmet", "Kaya", "Hizmet ödemesi", 0, new DateTime(2023, 7, 5, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8267), 750.50m, "23456789012", null },
                    { 3, new DateTime(2023, 8, 4, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8269), "Elif", "Demir", "Fatura ödemesi", 0, new DateTime(2023, 7, 28, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8269), 300.00m, "34567890123", null },
                    { 4, new DateTime(2023, 8, 4, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8271), "Ahmet", "Yıldız", "Kira ödemesi", 0, new DateTime(2023, 6, 5, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8271), 1200.75m, "45678901234", null },
                    { 5, new DateTime(2023, 8, 4, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8273), "Zeynep", "Akgün", "Alışveriş ödemesi", 0, new DateTime(2023, 7, 13, 15, 25, 21, 665, DateTimeKind.Local).AddTicks(8273), 250.25m, "56789012345", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NYO_SOSYALYARDİM");
        }
    }
}
