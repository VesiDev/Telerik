using System;

class DeckOf52Cards
{
    static void Main()
    {
        Console.WriteLine("This program prints all possible cards from a standard deck of 52 cards (without jokers).");    

        int cardNum=0;
        int colorNum=0;
        string card ="";
        string color = "";
        int counter = 0;

        for (int i = 1; i <=13; i++)
        {
            cardNum = i;
            switch (cardNum)
            {
                case 1: card = "Ace"; break;
                case 2: card = "2"; break;
                case 3: card = "3"; break;
                case 4: card = "4"; break;
                case 5: card = "5"; break;
                case 6: card = "6"; break;
                case 7: card = "7"; break;
                case 8: card = "8"; break;
                case 9: card = "9"; break;
                case 10: card = "10"; break;
                case 11: card = "Jack"; break;
                case 12: card = "Queen"; break;
                case 13: card = "King"; break;
                default: break;
            }
            for (int j = 1; j <=4; j++)
            {
                colorNum = j;
                switch (colorNum)
                { 
                    case 1: color = "club(♣)";  break;
                    case 2: color = "diamond(♦)"; break;
                    case 3: color = "heart(♥)"; break;
                    case 4: color = "spade(♠)"; break;
                    default: break;
                }
                counter++;
                Console.WriteLine("{0}: {1} {2}", counter,card, color);
            }

        }
       
        
      
    }
}