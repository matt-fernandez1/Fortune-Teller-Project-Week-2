using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2FortuneTeller
{
    class Program
    {
        static string Greeting(string firstName, string lastName)
        //loop and array vacation siblings
        {

            string fullName = "Greetings, " + firstName + " " + lastName + ". I will tell you your fortune";
            return fullName;

        }

        static void theFortuneTeller()
        {
            Console.WriteLine("I am just a fortune teller, do not entrust your future to me!");
        }

        static void Main(string[] args)
        {
            string firstName, lastName, coloR;

            while (true)
            {




                Console.WriteLine("What is your first name?");
                firstName = Console.ReadLine();

                if (firstName == "quit" || firstName == "exit")
                {
                    break;
                }

                else if (firstName == "restart" || firstName == "exit")
                {
                    break;
                }

                Console.WriteLine("What is your last name?");
                lastName = Console.ReadLine();

                if (lastName == "quit" || lastName == "exit")
                {
                    break;
                }

                else if (lastName == "restart" || lastName == "exit")
                {
                    break;
                }
                Console.WriteLine(Greeting(firstName, lastName));

                Console.WriteLine("What is your age, please enter as a whole number?");
                int retire = RetireAge(int.Parse(Console.ReadLine()));

                string years = Console.ReadLine();

                if (years == "quit" || years == "exit")
                {
                    break;
                }

                else if (years == "restart" || years == "exit")
                {
                    break;
                }

                Console.WriteLine("What is your birth month?");
                int month = int.Parse(Console.ReadLine());

                string old = Console.ReadLine();

                if (old == "quit" || old == "exit")
                {
                    break;
                }

                else if (old == "restart" || old == "exit")
                {
                    break;
                }
                Console.WriteLine("What's your favorite ROYGBIV color? If you don't know ROYGBIV, please enter help");
                coloR = Console.ReadLine();

                if (coloR == "quit" || coloR == "exit")
                {
                    break;
                }

                else if (coloR == "restart" || coloR == "exit")
                {
                    break;
                }
                if (coloR == "help")

                {
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet" + "\n");
                    Console.WriteLine("What's your favorite ROYGBIV color?");
                    coloR = Console.ReadLine();

                    if (coloR == "quit" || coloR == "exit")

                    {
                        break;
                    }

                    else if (coloR == "restart" || coloR == "exit")
                    {
                        ;
                    }
                }

                Console.WriteLine("How many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());

                string hombres = Console.ReadLine();

                if (hombres == "quit" || hombres == "exit")
                {
                    break;
                }
                Console.WriteLine(firstName + " " + lastName);

                if (month <= 4)
                {
                    Console.WriteLine("You will have $50,000 in the bank");
                }
                else
                {
                    if (month <= 8)
                    {
                        Console.WriteLine("You will have $75,000 in the bank");
                    }
                    else
                        if (month <= 12)
                    {
                        Console.WriteLine("You will have $100,000 in the bank");
                    }


                    //ROYGBIV 
                    coloR = coloR.ToLower();

                    if (coloR == "red" || coloR == "orange" || coloR == "yellow" || coloR == "green" || coloR == "blue" || coloR == "indigo" || coloR == "violet")

                        switch (coloR)

                        {
                            case "red":
                                Console.WriteLine("You will drive a red Ferrari, winner winner!");
                                break;

                            case "orange":
                                Console.WriteLine("You will drive an orange oldsmobile station wagon");
                                break;

                            case "yellow":
                                Console.WriteLine("You will drive a yellow Porsche");
                                break;

                            case "green":
                                Console.WriteLine("You will fly a futuristic airplane");
                                break;

                            case "blue":
                                Console.WriteLine("You will captain a submarine");
                                break;

                            case "indigo":
                                Console.WriteLine("You will drive through the speed of light in a teleportation device");
                                break;

                            case "violet":
                                Console.WriteLine("You will drive a violet smart car");
                                break;


                        }

                    if (siblings == 0)
                    {
                        Console.WriteLine("You will have a vacation home in Florida");
                    }
                    else
                    {
                        if (siblings == 1)
                        {
                            Console.WriteLine("You will have a vacation home in Yemen");
                        }
                        else
                            if (siblings == 2)
                        {
                            Console.WriteLine("You will have a vacation home in Syria");
                        }
                        else
                            if (siblings >= 3)
                        {
                            Console.WriteLine("You will have a vacation home in Afghanistan");
                        }

                        Console.WriteLine(retire);
                        break;
                    }
                }
            }
        }


        static int RetireAge(int age)
        {
            int retire = age % 2;

            switch (retire)
            {
                case 0:
                    retire = 3;
                    break;
                case 1:
                    retire = 5;
                    break;
                default:
                    retire = 1000;
                    break;
            }
            Console.WriteLine("You will retire in " + retire + " years");

            return retire;

        }
        static string Vacationhomes(int siblings)
        {
            string location = "";


            if (siblings == 0)
            {
                Console.WriteLine("You will have a vacation home in Florida");
            }
            else if (siblings == 1)
            {
                Console.WriteLine("You will have a vacation home in Yemen");
            }
            else if (siblings == 2)
            {
                Console.WriteLine("You will have a vacation home in Syria");
            }
            else if (siblings >= 3)
            {
                Console.WriteLine("You will have a vacation home in Afghanistan");
            }

            return location;
        }

        

        static string coloRTransport(string coloR)
        {
            coloR = coloR.ToLower();

            if (coloR == "red" || coloR == "orange" || coloR == "yellow" || coloR == "green" || coloR == "blue" || coloR == "indigo" || coloR == "violet")

                switch (coloR)


                {
                    case "red":
                        Console.WriteLine("You will drive a red Ferrari, winner winner!");
                        break;

                    case "orange":
                        Console.WriteLine("You will drive an orange oldsmobile station wagon");
                        break;

                    case "yellow":
                        Console.WriteLine("You will drive a yellow Porsche");
                        break;

                    case "green":
                        Console.WriteLine("You will fly a futuristic airplane");
                        break;

                    case "blue":
                        Console.WriteLine("You will captain a submarine");
                        break;

                    case "indigo":
                        Console.WriteLine("You will drive through the speed of light in a teleportation device");
                        break;

                    case "violet":
                        Console.WriteLine("You will drive a violet smart car");
                        break;
                }
            return coloR;
        }

      
            }
    }
