using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Begin:
            Console.WriteLine(" 1.To Add Player \n 2.To Remove player by ID \n 3.Get Player by ID \n 4.Get Player by Name\n 5.Get All Players");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                
                    OneDayTeam E = new OneDayTeam();
                    if (OneDayTeam.Oneday.Count != OneDayTeam.Oneday.Capacity)
                    {
                        Console.Write("Enter the Player Id:");
                        E.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Player Name:");
                        E.PlayerName = Console.ReadLine();
                        Console.Write("Enter the  Player Age:");
                        E.PlayerAge = Convert.ToInt32(Console.ReadLine());

                        E.Add(E);
                    }
                    else
                    {
                        Console.WriteLine(" You cannot add players capacity is full");
                        goto Begin;
                    }
                    
                    break;
                case "2":
                    OneDayTeam V = new OneDayTeam();
                    Console.Write("Enter the Player Id you want to  remove:");
                    int i = Convert.ToInt32(Console.ReadLine());
                    V.Remove(i);
                    break;
                case "3":
                    OneDayTeam E1 = new OneDayTeam();
                    Console.Write("Enter the  Player Id you want to search:");
                    int Y = Convert.ToInt32(Console.ReadLine());
                    Player p = E1.GetPlayerById(Y);
                    Console.WriteLine($"{p.PlayerId} {p.PlayerName} {p.PlayerAge}");
                    break;
                case "4":
                    OneDayTeam search1 = new OneDayTeam();
                    Console.Write("Enter Player Name to search:");
                    string i2 = Console.ReadLine();
                    Player p1 = search1.GetPlayerByName(i2);
                    Console.WriteLine($"{p1.PlayerId} {p1.PlayerName} {p1.PlayerAge}");
                    break;
                case "5":
                    Console.WriteLine("List all players");
                    List<Player> Players = new List<Player>();
                    OneDayTeam W = new OneDayTeam();
                    Players = W.GetAllPlayers();
                    if (Players.Count > 0)
                    {
                        foreach (var item in Players)
                        {
                            Console.WriteLine($"{item.PlayerId} {item.PlayerName} {item.PlayerAge}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no players in the list");
                    }

                    break;
                default: Console.WriteLine("Invalid choice");break;

            }
            Console.WriteLine("Do you want to continue(yes/no)?:type yes");
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                goto Begin;
            }
            Console.ReadKey();
        }
    }
}
