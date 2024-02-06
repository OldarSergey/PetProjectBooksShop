namespace BooksShopAPI.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public bool  IsDeleted { get; set; }

        public string Title { get; set; }
        public string DatePublication { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public int AuthorId { get; set; }
        public int BullyingId { get; set; }
        public int SuppliersId { get; set; }

        public Author Author { get; set; }
        public Bullying Bullying { get; set; }
        public Suppliers Suppliers { get; set; }

        public ICollection<BuyerBook> BuyerBooks { get; set; }


    }
}
