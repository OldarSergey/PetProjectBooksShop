namespace BooksShopAPI.Entities
{
    public class BuyerBook
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }
        public int BookId { get; set; }
        public int CountOrder { get; set; }
        public DateTime DateOrder { get; set; }
        public decimal Sum { get; set; }

        public Book Book { get; set; }
        public Buyer Buyer { get; set; }
    }
}
