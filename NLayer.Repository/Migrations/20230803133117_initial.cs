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
                    ODEMENO = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "CreatedDate", "MUSTERIAD", "MUSTERISOYAD", "ODEME_ACK", "ODEME_KD", "ODEMENO", "ODEME_TR", "ODENECEK_TTR", "TCKIMLIKNO", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 3, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(675), "Ayşe", "Yılmaz", "Ürün satışı", 0, 0, new DateTime(2023, 7, 19, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(665), 500.00m, "12345678901", null },
                    { 2, new DateTime(2023, 8, 3, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(678), "Mehmet", "Kaya", "Hizmet ödemesi", 1, 0, new DateTime(2023, 7, 4, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(677), 750.50m, "23456789012", null },
                    { 3, new DateTime(2023, 8, 3, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(680), "Elif", "Demir", "Fatura ödemesi", 0, 0, new DateTime(2023, 7, 27, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(679), 300.00m, "34567890123", null },
                    { 4, new DateTime(2023, 8, 3, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(682), "Ahmet", "Yıldız", "Kira ödemesi", 2, 0, new DateTime(2023, 6, 4, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(681), 1200.75m, "45678901234", null },
                    { 5, new DateTime(2023, 8, 3, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(684), "Zeynep", "Akgün", "Alışveriş ödemesi", 1, 0, new DateTime(2023, 7, 12, 16, 31, 16, 865, DateTimeKind.Local).AddTicks(683), 250.25m, "56789012345", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NYO_SOSYALYARDİM");
        }
    }
}
