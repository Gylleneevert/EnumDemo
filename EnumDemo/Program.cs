using System.Threading.Channels;

namespace EnumDemo
{
    enum Beverage 
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice,
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcone to the awwsome vending machine!");
            Console.WriteLine("Wich beverage do you perfer (coffee, tea, soda , water, juice)");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("Invalid Input, this drink does not exists");
                    break;
                    


            }
            Console.WriteLine();
        }   
        static void Respond(Beverage drink) 
        {
            switch (drink)
            {
               case Beverage.Coffee:
                    Console.WriteLine("you order Kaffe Latte");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("you chose EarlGrey");
                    break;
                case Beverage.Water:
                    Console.WriteLine("you chosed Water");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("you chosed pepsi, cola");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("you choosed orange juice");
                    break;
            }
        }
    }   
}