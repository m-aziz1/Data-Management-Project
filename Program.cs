// DATA MANAGEMENT PROJECT

using System;
using data;
using Algorithms;
using System.Text.Json;

Console.Clear();
#nullable disable

List<User> users = new List<User>();
List<Character> catalogue = new List<Character>();

string fileName = "character-list.json";
string jsonString = File.ReadAllText(fileName);
catalogue = JsonSerializer.Deserialize<List<Character>>(jsonString)!;

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("---|Muhammad's Library|--- ");
    Console.WriteLine(
        "1. Display All data\n2. Filter Data\n3. Sort Alphabetically\n4. Add To Favourites\n5. Remove from Favourites\n6. Display Favourites\n7. Exit"
    );
    string option = Console.ReadLine();

    if (option == "1")
    {
        // Display All Data
        Console.WriteLine("---");
        Console.ForegroundColor = ConsoleColor.Yellow;
        printList(catalogue);
    }
    else if (option == "2")
    {
        // Filter Data
        Console.WriteLine("---");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Filter by (1 - Affiliation, 2 - Classification): ");
        string filterType = Console.ReadLine();

        if (filterType == "1")
        {
            Console.Write("Affiliation: ");
            string filter = Console.ReadLine().ToLower();
            int resultCount = 0;

            for (int i = 0; i < catalogue.Count(); i++)
            {
                resultCount += catalogue[i].checkAffiliation(filter);
            }

            if (resultCount < 1)
            {
                Console.WriteLine("No results found");
            }
        }
        else if (filterType == "2")
        {
            Console.Write("Classification: ");
            string filter = Console.ReadLine().ToLower();
            int resultCount = 0;

            for (int i = 0; i < catalogue.Count(); i++)
            {
                resultCount += catalogue[i].checkClassification(filter);
            }

            if (resultCount < 1)
            {
                Console.WriteLine("No results found");
            }
        }
        else
        {
            Console.WriteLine("Invalid selection");
        }
    }
    else if (option == "3")
    {
        // Sort by Character Name
        Console.WriteLine("---");
        Console.ForegroundColor = ConsoleColor.Yellow;
        insertionSortName(catalogue);
        printList(catalogue);
    }
    else if (option == "4") { }
    else if (option == "5") { }
    else if (option == "6") { }
    else if (option == "7")
    {
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---\nInvalid entry\n---");
    }
}

// FUNCTIONS

void insertionSortName(List<Character> aList)
{
    int insertPos;
    string insertVal;
    for (int i = 1; i < aList.Count(); i++)
    {
        insertPos = i;
        insertVal = aList[i].Name;

        while (insertPos > 0 && (aList[insertPos - 1].Name.CompareTo(insertVal) > 0))
        {
            aList[insertPos].Name = aList[insertPos - 1].Name;
            insertPos--;
        }
        aList[insertPos].Name = insertVal;
    }
}

void printList(List<Character> aList)
{
    for (int i = 0; i < catalogue.Count(); i++)
    {
        catalogue[i].printProperties();
    }
}
