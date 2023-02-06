namespace LanchesMac.Models
{
    public class Snack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SmallDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public string ImgThumbnailPath { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsAvaible { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
