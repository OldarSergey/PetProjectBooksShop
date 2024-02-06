namespace BooksShopAPI.Entities
{
    public class Suppliers
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
