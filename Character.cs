namespace data
{
    public class Character
    {
        public string Name { get; set; }
        public string Affiliation { get; set; }
        public string Classification { get; set; }
        public List<string> Abilities { get; set; }

        public Character(
            string name,
            string affiliation,
            string Classification,
            params string[] abilities
        )
        {
            this.Name = name;
            this.Affiliation = affiliation;
            this.Classification = Classification;
            this.Abilities = abilities.ToList();
        }

        public void printProperties()
        {
            Console.WriteLine(
                $"Name: {this.Name}\nAffiliation: {this.Affiliation}\nClassification: {this.Classification}"
            );
            Console.Write("Abilities: ");
            for (int j = 0; j < this.Abilities.Count(); j++)
            {
                Console.Write($"{this.Abilities[j]}, ");
            }
            Console.Write("\n|\n");
        }

        public int checkAffiliation(string item)
        {
            if (this.Affiliation == item)
            {
                this.printProperties();
                return 1;
            }
            return 0;
        }

          public int checkClassification(string item)
        {
            if (this.Classification == item)
            {
                this.printProperties();
                return 1;
            }
            return 0;
        }
    }
}
