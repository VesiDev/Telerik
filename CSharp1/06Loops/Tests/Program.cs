using System;

class DeckOfCards
{
    static void Main()
    {
        string[] names = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        foreach (var name in names)
        {
            foreach (var suit in suits)
            {
                switch (suit)
                {
                    case "Clubs":
                    case "Spades":
                        Console.WriteLine(name + " of " + suit);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case "Diamonds":
                    case "Hearts":
                        Console.WriteLine(name + " of " + suit);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
            }
        }
    }
}