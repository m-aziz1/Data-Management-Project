// DATA MANAGEMENT PROJECT

using System;
using data;
using Algorithms;
using System.Text.Json;
#nullable disable


Console.Clear();
List<User> users = deserializeJsonUsers("users.json");
List<Character> catalogue = deserializeJsonCharacters("character-list.json");

// LOGIN
Console.WriteLine("Welcome! \n1. Login to Existing user\n2. Create New User");
string optLogin = Console.ReadLine();
if (optLogin == "1")
{
    while (true)
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        // Break loop if user exists
        int userInd = checkExistingUser(username);
        if (userInd > -1)
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            if (users[userInd].Password == password)
            {
                Console.Clear();
                Console.WriteLine("Logged in!");
                mainLoop(users[userInd]);
                break;
            }
            Console.WriteLine("---\nPassword Incorrect\n---");
        }
        Console.WriteLine("---\nUser Does Not Exist\n---");
    }
}
else if (optLogin == "2")
{
    while (true)
    {
        Console.Write("Enter New Username: ");
        string username = Console.ReadLine();

        // Break loop if user does not exist
        if (checkExistingUser(username) < 0)
        {
            Console.Write("Enter New Password: ");
            string password = Console.ReadLine();
            users.Add(new User(username, password));
            Console.Clear();
            Console.WriteLine("Account Created!");
            mainLoop(users[users.Count() - 1]);
            break;
        }
        Console.WriteLine("---\nUsername is Taken\n---");
    }
}
else
{
    Console.WriteLine("---\nInvalid Entry\n---");
}

// MAIN LOOP
void mainLoop(User currentUser)
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"---|Welcome, {currentUser.Username}!|--- ");
        Console.WriteLine(
            "1. Display All data\n2. Filter Data\n3. Sort Alphabetically\n4. Add To Favourites\n5. Remove from Favourites\n6. Display Favourites\n7. Exit"
        );
        string optMenu = Console.ReadLine();

        if (optMenu == "1")
        {
            // Display All Data
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            printList(catalogue);
        }
        else if (optMenu == "2")
        {
            // Filter Data
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Filter by (1 - Affiliation, 2 - Classification): ");
            string filterType = Console.ReadLine();

            if (filterType == "1")
            {
                // Filter by Affiliation
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
                // Filter by Classification
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
        else if (optMenu == "3")
        {
            // Sort by Character Name
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            insertionSortName(catalogue);
            printList(catalogue);
        }
        else if (optMenu == "4")
        {
            // Add to Favourites
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter name of character: ");
            string charName = Console.ReadLine().ToLower();
            for (int i = 0; i < catalogue.Count(); i++)
            {
                if (catalogue[i].Name == charName)
                {
                    if (currentUser.Faves.Contains(catalogue[i]) == false)
                    {
                        currentUser.addFave(catalogue[i]);
                        Console.WriteLine("Added to favourites!");
                    }
                }
            }
        }
        else if (optMenu == "5")
        {
            // Remove from Favourites
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter name of character: ");
            string charName = Console.ReadLine().ToLower();
            for (int i = 0; i < currentUser.Faves.Count(); i++)
            {
                if (currentUser.Faves[i].Name == charName)
                {
                    currentUser.Faves.RemoveAt(i);
                    Console.WriteLine("Removed from favourites list");
                }
            }
        }
        else if (optMenu == "6")
        {
            // Print Favourites List
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            printList(currentUser.Faves);
        }
        else if (optMenu == "7")
        {
            // Exit
            Console.ForegroundColor = ConsoleColor.White;
            string fileName = "users.json";
            string jsonString = JsonSerializer.Serialize(users);
            File.WriteAllText(fileName, jsonString);
            break;
        }
        else
        {
            // Invalid Entries
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---\nInvalid entry\n---");
        }
    }
}


// FUNCTIONS
int checkExistingUser(string username)
{
    for (int i = 0; i < users.Count(); i++)
    {
        if (users[i].Username == username)
        {
            return i;
        }
    }

    return -1;
}

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
    for (int i = 0; i < aList.Count(); i++)
    {
        aList[i].printProperties();
    }
}

List<Character> deserializeJsonCharacters(string fileName)
{
    string jsonString = File.ReadAllText(fileName);
    return JsonSerializer.Deserialize<List<Character>>(jsonString)!;
}

List<User> deserializeJsonUsers(string fileName)
{
    string jsonString = File.ReadAllText(fileName);
    return JsonSerializer.Deserialize<List<User>>(jsonString)!;
}