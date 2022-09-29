namespace data
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }

        public Book(string name, string author, string ISBN, string genre)
        {
            this.Name = name;
            this.Author = author;
            this.ISBN = ISBN;
            this.Genre = genre;
        }
    }
}
