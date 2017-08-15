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

        }
    }
}
