namespace data
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Character> Faves { get; set; }

        public User(string username, string password, List<Character> faves)
        {
            this.Username = username;
            this.Password = password;
            this.Faves = faves;
        }

        public void addFave(Character item)
        {
            this.Faves.Add(item);
        }

        public void removeFave(Character item)
        {
            this.Faves.Remove(item);
        }
    }
}
