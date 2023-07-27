using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class addCategoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories(Name,Description)" +
                "Values('Normal','Lanche feito com ingredientes tradicionais')");
            migrationBuilder.Sql("Insert into Categories(Name,Description)" +
                "Values('Natural','Lanche feito com ingredientes Naturais e integrais')");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categories");
        }
    }
}
