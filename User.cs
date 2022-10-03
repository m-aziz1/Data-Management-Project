namespace data
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Character> Faves { get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Faves = new List<Character>();
        }

        public void addFave(Character item)
        {
            this.Faves.Add(item);
        }
    }
}
