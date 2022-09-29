// DATA MANAGEMENT PROJECT

using System;
using data;
using Algorithms;

List<Book> catalogue = new List<Book> { new Book("The Lightning Thief (Percy Jackson and the Olympians, Book 1)", "Riordan, Rick", "0786856297", "Fiction", "Greek Mythology", "Fantasy")};

while (true)
{
    Console.WriteLine("---|Muhammad's Library|--- ");
    Console.WriteLine(
        "1. Display All data\n2. Filter Data\n3. Sort Alphabetically\n4. Add To Favourites\n5. Remove from Favourites\n6. Display Favourites"
    );
    string option = Console.ReadLine();

    if (option == "1")
    {
        Console.WriteLine("Option 1");
    }
    else if (option == "2")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid entry");
    }
}
