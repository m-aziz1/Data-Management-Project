namespace data
{
    public class Character
    {
        public string Name { get; set; }
        public string Affiliation { get; set; }
        public string Classification { get; set; }
        public string[] Abilities { get; set; }

        public Character(
            string name,
            string affiliation,
            string Classification,
            string[] abilities
        )
        {
            this.Name = name;
            this.Affiliation = affiliation;
            this.Classification = Classification;
            this.Abilities = abilities;
        }

        public void printProperties()
        {
            Console.WriteLine(
                $"Name: {this.Name}\nAffiliation: {this.Affiliation}\nClassification: {this.Classification}"
            );
            Console.Write("Abilities: ");
            for (int i = 0; i < this.Abilities.Count(); i++)
            {
                Console.Write($"{this.Abilities[i]}, ");
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
