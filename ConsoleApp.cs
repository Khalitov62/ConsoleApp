using System;
using Task_1.Helper;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our cinema");
            int selection;
            do
            {


                Console.WriteLine("1. Create Hall");
                Console.WriteLine("2. Edit Hall");
                Console.WriteLine("3. Get All Halls");
                Console.WriteLine("4. Get Add Seats");
                Console.WriteLine("5. Reserve");
                Console.WriteLine("0. Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Please enter row value");
                            byte row;
                            bool rowResoult = byte.TryParse(Console.ReadLine(), out row);
                            Console.WriteLine("Please enter col calue: ");
                            byte col;
                            bool colResoult = byte.TryParse(Console.ReadLine(), out col);
                            Console.WriteLine("Please enter category");
                            object cg;
                            bool categoryResoult = Enum.TryParse(typeof(Category), (Console.ReadLine(), out cg);
                            if (categoryResoult)
                            {
                                if (cg is Category)
                                {
                                    Category category = (Category)cg;
                                    Console.WriteLine(category);

                                }
                            }

                        default:
                            break;
                    }
                }
            } while (selection != 0);
        }
    }
}
