namespace Lesson3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1------------------------------------------------------------------------

            Console.WriteLine("Выберите месяц:\n1 - Январь\n2 - Февраль\n3 - Март\n4 - Апрель\n5 - Май\n6 - Июнь\n7 - Июль\n8 - Август\n9- Сентябрь\n10 - Октябрь\n11-Ноябрь\n12-декабрь");
            string monthInput = Console.ReadLine();
            int monthResult = Int32.Parse(monthInput);

            switch (monthResult)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
            }

            // Task 2------------------------------------------------------------------------------

            Console.WriteLine("Выберите месяц:\n1 - Январь\n2 - Февраль\n3 - Март\n4 - Апрель\n5 - Май\n6 - Июнь\n7 - Июль\n8 - Август\n9- Сентябрь\n10 - Октябрь\n11-Ноябрь\n12-декабрь");
            string monthInput2 = Console.ReadLine();
            int monthResult2 = Int32.Parse(monthInput2);

            if (monthResult2 == 12 || monthResult2 < 3)
            {
                Console.WriteLine("Зима");
            }
            else if (monthResult2 < 6)
            {
                Console.WriteLine("Весна");
            }
            else if (monthResult2 < 9)
            {
                Console.WriteLine("Лето");
            }
            else
            {
                Console.WriteLine("Осень");
            }
            Console.ReadLine();

            // Task 3--------------------------------------------------------------------------------------------

            Console.WriteLine("Введите число:");
            int i = Int32.Parse(Console.ReadLine());
            int iRemainder = i % 2;
            if (iRemainder == 0)
            {
                Console.WriteLine($"Число {i} четное");
            }
            else
            {
                Console.WriteLine($"Число {i} НЕчетное");
            }

            // Task 4--------------------------------------------------------------------------------------------

            Console.WriteLine("Введите температуру на улице:");
            int temp = Int32.Parse(Console.ReadLine());

            if (temp > -5)
            {
                Console.WriteLine("Тепло");
            }
            else if (temp <= -5 && temp > -20)
            {
                Console.WriteLine("Нормально");
            }
            else { Console.WriteLine("Холодно"); }


            // Task 5---------------------------------------------------------------------------------------------

            Console.WriteLine("Введите число 1-7:");
            int colorNumber = Int32.Parse(Console.ReadLine());

            switch (colorNumber) 
            {
                case 1:
                    Console.WriteLine("Красный");
                    break;
                case 2:
                    Console.WriteLine("Оранжевый");
                    break;
                case 3:
                    Console.WriteLine("Желтый");
                    break;
                case 4:
                    Console.WriteLine("Зеленый");
                    break; 
                case 5:
                    Console.WriteLine("Голубой");
                    break;
                case 6:
                    Console.WriteLine("Синий");
                    break;
                case 7:
                    Console.WriteLine("Фиолетовый");
                    break;
            }

        }
    }
}