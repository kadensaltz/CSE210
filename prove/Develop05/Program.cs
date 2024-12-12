using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        do
        {
            Console.WriteLine();
            Console.WriteLine($"You have {Goal.GetEarnedPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Use Points");
            Console.WriteLine("\t7. Quit");
            
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                {   
                    string goalCreation = "";
                    Console.WriteLine("The types of goals are: ");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal");
                    Console.Write("What type of goal would you like to create? ");
                    goalCreation = Console.ReadLine();
                    switch(goalCreation)
                    {
                        case "1":
                        {
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.MakeGoal();
                            break;
                        }
                        case "2":
                        {
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.MakeGoal();
                            break;
                        }
                        case "3":
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.MakeGoal();
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Invalid option. Please select a valid option.");
                            break;
                        }
                    }
                    break;
                }
                case "2":
                {
                    Goal.ListGoals();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("What would you like to name the file? ");
                    string fileName = Console.ReadLine();
                    Goal.SaveGoals(fileName);
                    break;
                }
                case "4":
                {
                    //Goal._goals = new List<Goal>();
                    Console.WriteLine("What is the name the file? ");
                    string fileName = Console.ReadLine();
                    Goal.LoadGoals(fileName);
                    break;
                }
                case "5":
                {
                    Goal.recordGoals();
                    break;
                }
                case "6":
                {
                    Goal.redeemPoints();
                    break;
                }
                case "7":
                {
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
                }
            }
        } while(userInput != "7");
        Console.WriteLine("Thank you for using the Goal Setting Activity!");
    }
}

// For my stretch challenge, I added another part to redeem points for rewards.