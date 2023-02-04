namespace Lesson3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            Console.WriteLine("Выберите месяц:\n1 - Январь\n2 - Февраль\n3 - Март\n4 - Апрель\n5 - Май\n6 - Июнь\n7 - Июль\n8 - Август\n9- Сентябрь\n10 - Октябрь\n11-Ноябрь\n12-декабрь");
            string MonthInput = Console.ReadLine();
            int MonthResult = Int32.Parse(MonthInput);

            switch (MonthResult)
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

            // Task 2

            //Console.WriteLine("Выберите месяц:\n1 - Январь\n2 - Февраль\n3 - Март\n4 - Апрель\n5 - Май\n6 - Июнь\n7 - Июль\n8 - Август\n9- Сентябрь\n10 - Октябрь\n11-Ноябрь\n12-декабрь");
            //string MonthInput = Console.ReadLine();
            //int MonthResult = Int32.Parse(MonthInput);

            //if (MonthResult == 12 || MonthResult < 3)
            //{
            //    Console.WriteLine("Зима");
            //}
            //else if (MonthResult < 6)
            //{
            //    Console.WriteLine("Весна");
            //}
            //else if (MonthResult < 9)
            //{
            //    Console.WriteLine("Лето");
            //}
            //else
            //{
            //    Console.WriteLine("Осень");
            //}
            //Console.ReadLine();

            // Task 3

            // Task 4

            // Task 5
        }
    }
}