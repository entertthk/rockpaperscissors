using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {

        string name;
        string userChoice;
        
        int cpuNumber;
        int userScore = 0;
        int cpuScore = 0;

         
        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();

        while (cpuScore < 3 && userScore < 3)
            {

            Console.WriteLine($"{name}! Choose paper, rock or scissors: ");
            userChoice = Console.ReadLine();

        
            Random rnd = new Random();
            cpuNumber = rnd.Next(1, 4);
        
            // paper= 1; rock= 2; scissors= 3
            switch (cpuNumber)
                {
                case 1:
                    
                    Console.WriteLine("Cpu choose paper");
                    if (userChoice == "paper")
                    {
                        Console.WriteLine("Its a draw!\n");
                    }
                    else if (userChoice == "rock")
                    {
                        Console.WriteLine("Cpu wins!\n");
                        cpuScore++;
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("User wins!\n");
                        userScore++;
                    }
                    break;

                case 2:
                    
                    Console.WriteLine("Cpu choose rock");
                    if (userChoice == "paper")
                    {
                        Console.WriteLine("User wins!\n");
                        userScore++;
                    }
                    else if (userChoice == "rock")
                    {
                        Console.WriteLine("Its a draw!\n");
                        
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("Cpu wins!\n");
                        cpuScore++;
                    }

                    break;

               case 3:
                    
                    Console.WriteLine("Cpu choose scissors");
                    if (userChoice == "paper")
                    {
                        Console.WriteLine("Cpu wins!\n");
                        cpuScore++;
                    }
                    else if (userChoice == "rock")
                    {
                        Console.WriteLine("User wins!\n");
                        userScore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("Its a draw!\n");
                        
                    }


                    break;

                default:
                    Console.WriteLine("wrong");
                    break;

                }    
                

            

            if (userScore == 3)
                {
                    Console.WriteLine("USER HAS 3 WINS!");
                }
            else if (cpuScore == 3)
                {
                    Console.WriteLine("CPU HAS 3 WINS!");
                }

            }
            Console.ReadLine();
        }
    }
}
