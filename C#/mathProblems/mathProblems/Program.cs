using System;
namespace NestedSwitch
{

    class Program
    {
        static void Main(string[] args)
        {
            string title = "student";
            int grade = 1;
            switch (title)
            {
                case "teacher":
                    Console.WriteLine("You are a teacher.");
                    break;
                case "student":
                    Console.WriteLine("You are a student.");
                    switch (grade)
                    {
                        case 1:
                            Console.WriteLine(" You are in pre-school ");
                            break;
                        case 2:
                            Console.WriteLine(" You are in high-school ");
                            break;
                        case 3:
                            Console.WriteLine(" You are in college ");
                            break;
                        case 4:
                            Console.WriteLine(" You are in university ");
                            break;
                        default:
                            Console.WriteLine("Result Unknown");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine(" Office Staff ");
                    break;
            }
            Console.Read();
        }
    }

}