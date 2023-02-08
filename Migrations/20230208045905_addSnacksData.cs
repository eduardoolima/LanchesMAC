using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class addSnacksData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Snacks(Name,SmallDescription,Description,Price,ImgPath,ImgThumbnailPath,IsFavorite,IsAvaible,CategoryId)" +
                "values('x-Salada','descrição inicial','x-Salada com Pão, hamburguer 200g, alface, tomate, picles e queijo chedar', 20,'https://i0.wp.com/anamariabraga.globo.com/wp-content/uploads/2016/11/x-salada-classico.jpg?fit=1200%2C675&ssl=1','https://assets.unileversolutions.com/recipes-v2/106684.jpg', 0,1,1)");
            migrationBuilder.Sql("Insert into Snacks(Name,SmallDescription,Description,Price,ImgPath,ImgThumbnailPath,IsFavorite,IsAvaible,CategoryId)" +
                "values('x-Salada monstro','descrição inicial x-salada mosntro','Pão, burguer 400g, alface, tomate, picles, cebola roxa, maionese, queijo chedar', 30,'https://moinhoglobo.com.br/wp-content/uploads/2019/05/16-hamburguer.jpeg','https://moinhoglobo.com.br/wp-content/uploads/2019/05/16-hamburguer.jpeg', 0,1,1)");
            migrationBuilder.Sql("Insert into Snacks(Name,SmallDescription,Description,Price,ImgPath,ImgThumbnailPath,IsFavorite,IsAvaible,CategoryId)" +
                "values('double x-Salada','descrição inicial double','2x - x-Salada ', 39.50,'https://www.sabornamesa.com.br/media/k2/items/cache/b9ad772005653afce4d4bd46c2efe842_XL.jpg','https://www.sabornamesa.com.br/media/k2/items/cache/b9ad772005653afce4d4bd46c2efe842_XL.jpg', 1,1,1)");
            migrationBuilder.Sql("Insert into Snacks(Name,SmallDescription,Description,Price,ImgPath,ImgThumbnailPath,IsFavorite,IsAvaible,CategoryId)" +
                "values('Frango Natural','descrição inicial natural','pão de forma cortado em 2, alface, tomate, cenoura e frango desfiado.', 20,'https://receitatodahora.com.br/wp-content/uploads/2015/10/sanduiche-natural-para-vender.jpg','https://receitatodahora.com.br/wp-content/uploads/2015/10/sanduiche-natural-para-vender.jpg', 0,1,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Snacks");
        }
    }
}
