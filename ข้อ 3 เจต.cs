using System;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input save in tank number1= ");
            int tank1 = int.Parse(Console.ReadLine());
            Console.Write("input save in tank number2= ");
            int tank2 = int.Parse(Console.ReadLine());
            Console.Write("input save in tank number3= ");
            int tank3 = int.Parse(Console.ReadLine());
            
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("The number of boxes in the tank");
                Console.WriteLine("|| tank1 = {0} || tank2 = {1} || tank3 = {2} ||", tank1, tank2, tank3);
                Console.WriteLine(" ");
                Console.WriteLine("Mr.A");
                Console.Write("choose your number of tank : ");
                int numbertank = int.Parse(Console.ReadLine());
                switch (numbertank)
                {
                    case 1:
                        Console.Write("How many to remove 1 or 2 box ? : ");
                        int reducttank = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        while (reducttank <= 0 || reducttank >= 3)
                        {
                            Console.Write("Re again : ");
                            reducttank = int.Parse(Console.ReadLine());
                        }
                        if ((reducttank >= 1 && reducttank < 3))
                        { tank1 = tank1 - reducttank; }
                        break;

                    case 2:
                        Console.Write("How many to remove 1 or 2 box? : ");
                        reducttank = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        while (reducttank <= 0 || reducttank >= 3)
                        {
                            Console.Write("Re again : ");
                            reducttank = int.Parse(Console.ReadLine());
                        }
                        if ((reducttank >= 1 && reducttank < 3))
                        { tank2 = tank2 - reducttank; }
                        break;

                    case 3:
                        Console.Write("How many to remove 1 or 2 box? : ");
                        reducttank = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        while (reducttank <= 0 || reducttank >= 3)
                        {
                            Console.Write("Re again : ");
                            reducttank = int.Parse(Console.ReadLine());
                        }
                        if ((reducttank >= 1 && reducttank < 3))
                        { tank3 = tank3 - reducttank; }
                        break;
                }
                if (tank1 == 0 && tank2 == 0 && tank3 == 0)
                {
                    Console.WriteLine("B Win");
                }
                else
                {
                    Console.WriteLine("The number of boxes in the tank");
                    Console.WriteLine("|| tank1 = {0} || tank2 = {1} || tank3 = {2} ||", tank1, tank2, tank3);
                    Console.WriteLine("");
                    Console.WriteLine("Mr.B");
                    Console.Write("choose your number of tank : ");
                    numbertank = int.Parse(Console.ReadLine());
                    switch (numbertank)
                    {
                        case 1:
                            Console.Write("How many to remove 1 or 2 box? : ");
                            int reducttank = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            while (reducttank <= 0 || reducttank >= 3)
                            {
                                Console.Write("Re again : ");
                                reducttank = int.Parse(Console.ReadLine());
                            }
                            if ((reducttank >= 1 && reducttank < 3))
                            { tank1 = tank1 - reducttank; }
                            break;

                        case 2:
                            Console.Write("How many to remove 1 or 2 box? : ");
                            reducttank = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            while (reducttank <= 0 || reducttank >= 3)
                            {
                                Console.Write("Re again : ");
                                reducttank = int.Parse(Console.ReadLine());
                            }
                            if ((reducttank >= 1 && reducttank < 3))
                            { tank2 = tank2 - reducttank; }
                            break;

                        case 3:
                            Console.Write("How many to remove 1 or 2 box? : ");
                            reducttank = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            while (reducttank <= 0 || reducttank >= 3)
                            {
                                Console.Write("Re again : ");
                                reducttank = int.Parse(Console.ReadLine());
                            }
                            if ((reducttank >= 1 && reducttank < 3))
                            { tank3 = tank3 - reducttank; }
                            break;

                    }
                    if (tank1 == 0 && tank2 == 0 && tank3 == 0)
                    {
                        Console.WriteLine("A Win");
                    }

                }
            } while (tank1 != 0 || tank2 != 0 || tank3 != 0);
            Console.ReadLine();
        }
    }
}
