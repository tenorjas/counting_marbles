using System;

namespace counting_marbles
{
    class Program
    {
        public class MarbleBag
        {
            public int Reds {get; set;}
            public int Greens {get; set;}
            public int Blues {get; set;}

            public int GetTotalNumberOfMarbles()
            {
                return Reds + Greens + Blues;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Your marble bag contains {Reds} red marbles.");
                Console.WriteLine($"Your marble bag contains {Greens} green marbles.");
                Console.WriteLine($"Your marble bag contains {Blues} blue marbles.");
                Console.WriteLine($"Your marble bag contains a total of {GetTotalNumberOfMarbles()} marbles.");
            }

            public int RemoveAllGreenMarbles()
            {
                return Greens = 0;
            }

        }
        static void Main(string[] args)
        {
            var marbleBag = new MarbleBag();
            marbleBag.Reds = 3;
            marbleBag.Greens = 1;
            marbleBag.Blues = 2;

            marbleBag.PrintInfo();

            marbleBag.Blues = 5;

            if (marbleBag.GetTotalNumberOfMarbles() == 9)
            {
                Console.WriteLine("Total is 9, as expected.");
            }
            else
            {
                Console.WriteLine("PANIC!!!");
            }

            marbleBag.RemoveAllGreenMarbles();

            if (marbleBag.GetTotalNumberOfMarbles() == 8)
            {
                Console.WriteLine("Total is 8, as expected.");
            }
            else
            {
                Console.WriteLine("Panic even more!");
            }
        }
    }
}
