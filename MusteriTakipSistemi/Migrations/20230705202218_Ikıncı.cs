using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusteriTakipSistemi.Migrations
{
    public partial class Ikıncı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Urunler",
                newName: "Ürün Adı");

            migrationBuilder.RenameColumn(
                name: "SatinAlmaTarihi",
                table: "Musteriler",
                newName: "Satın Alma Tarihi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ürün Adı",
                table: "Urunler",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Satın Alma Tarihi",
                table: "Musteriler",
                newName: "SatinAlmaTarihi");
        }
    }
}
