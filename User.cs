namespace data
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Book> Faves { get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Faves = new List<Book>();
        }

        public void addFave(Book item)
        {
            this.Faves.Add(item);
        }
    }
}
