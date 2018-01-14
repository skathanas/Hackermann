using System;

namespace Must_Jaak
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Tehtud juutuubi õpetuse põhjal https://www.youtube.com/watch?v=udszc7xPF6s
            // Puuduvad mastid ;(
            Console.WriteLine("Welcome to the game of Blackjack!");

            int playerCardValue = 0;
            int dealerCardValue = 0;

            Random random = new Random();

            playerCardValue += random.Next(1, 12);
            playerCardValue += random.Next(1, 12);

            if (playerCardValue > 21)
            {
                playerCardValue -= 10;
            }

            dealerCardValue += random.Next(1, 12);
            dealerCardValue += random.Next(1, 12);

            Console.WriteLine("Dealer card value is " + dealerCardValue + ".");

            if (dealerCardValue > 21)
            {
                dealerCardValue -= 10;
            }

            while (true)
            {
                if (playerCardValue == 21)
                {
                    Console.WriteLine("21! You have won!");
                    break;
                }

                Console.WriteLine("My card value is " + playerCardValue.ToString() + ". Press 1 for new card. Press 2 to hold");

                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    playerCardValue += random.Next(1, 12);

                    if (playerCardValue > 21)
                    {
                        Console.WriteLine("You busted!");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (answer == "2")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Error, try again");
                    continue;
                }
            }

            Console.WriteLine("Player card value is " + playerCardValue.ToString());

            if (playerCardValue <= 21)
            {
                while (dealerCardValue < 21 && dealerCardValue < playerCardValue)
                {
                    dealerCardValue += random.Next(1, 12);    
                }

                if (playerCardValue == dealerCardValue)
                {
                    Console.WriteLine("Player and dealer have tied");
                }

                else if (playerCardValue < dealerCardValue && dealerCardValue <= 21)
                {
                    Console.WriteLine("Dealer has won");
                }
                else if (dealerCardValue > 21)
                {
                    Console.WriteLine("You won!");
                }
                else if (dealerCardValue == 21)
                {
                    Console.WriteLine("Dealer has won!");
                }
            }

            else
            {
                Console.WriteLine("Dealer has won, player has busted");
            }

            Console.WriteLine("You have " + playerCardValue + " Dealer has " + dealerCardValue);



        }
    }
}
