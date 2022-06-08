using Assignment;
using System;
public class Solution
{
    public static void Main()

    {

        string UserDecision = string.Empty;
        try
        {
            do
            {
                Console.Clear();
                int UserChoice;
                Console.WriteLine("Please select the choice which program do you want to run:");
                Console.WriteLine("1.Number Triangle\n2.Largest of three number\n3.cube finding\n4.find table");
                do
                {
                    Console.WriteLine("\nPlease enter your choice:");
                    UserChoice = Convert.ToInt32(Console.ReadLine());
                    switch (UserChoice)
                    {
                        case 1:
                            NumberTriangle T1 = new NumberTriangle();
                            T1.myTriangle();
                            break;
                        case 2:
                            Largest L1 = new Largest();
                            L1.LargestNo();
                            break;
                        case 3:
                            FindCube C1 = new FindCube();
                            C1.cube();
                            break;
                        case 4:
                            FindTable T2 = new FindTable();
                            T2.Table();
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid", UserChoice);
                            break;
                    }
                } while (UserChoice >= 1 && UserChoice <= 4);
                do
                {
                    Console.WriteLine("Do you want to continue:");
                    UserDecision = Console.ReadLine().ToUpper();
                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("Your choice {0} is invalid", UserDecision);
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            } while (UserDecision.ToUpper() != "NO");
        }
   
        catch (Exception)
        {
            Console.WriteLine("System down, please try after some time");
        }
    }
}