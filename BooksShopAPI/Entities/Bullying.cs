namespace BooksShopAPI.Entities
{
    public class Bullying
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Title { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
