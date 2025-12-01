using System.Diagnostics;

namespace AoC
{
    public static class Day01
    {
        public static Int64 Day01a(string[] input)
        {
            int dial = 50;
            int zeroes = 0;
            foreach (string s in input)
            {
                int step;
                if (s[0] == 'R') step = int.Parse(s.Substring(1));
                else step = -int.Parse(s.Substring(1));
                dial += step;
                dial %= 100;
                if (dial == 0) zeroes++;
            }

            return zeroes;
        }

        public static int Turn(ref int dial, int step)
        {
            int zeroes = 0;
            if (step > 0)
            {
                dial += step;
                while (dial >99) { zeroes++; dial -= 100; }
            }
            if (step < 0)
            {
                if (dial ==0) zeroes--;
                dial += step;
                while (dial < 0) { zeroes++; dial += 100; }
                if (dial == 0) zeroes++;
            }

            return zeroes;
        }

        public static Int64 Day01b(string[] input)
        {
            int dial = 50;
            int zeroes = 0;
            foreach (string s in input)
            {
                int step;
                if (s[0] == 'R') step = int.Parse(s.Substring(1));
                else step = -int.Parse(s.Substring(1));
                zeroes += Turn(ref dial, step);
            }

            return zeroes;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day01.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day01a : {0}   Time: {1}", Day01a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day01b : {0}   Time: {1}", Day01b(lines), sw.ElapsedMilliseconds);
        }
    }
}
