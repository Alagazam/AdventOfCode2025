using System.Diagnostics;

namespace AoC
{
    public static class Day03
    {
        public static Int64 Day03a(string[] input)
        {
            var sum = 0;
            foreach (var s in input)
            {
                sum += joltage(s);
            }
            return sum;
        }

        public static int joltage(string s)
        {
            var tenth = s.Substring(0, s.Length - 1).Max();
            var index = s.IndexOf(tenth);

            var ones = s.Substring(index + 1).Max();

            String res = "";
            res += tenth;
            res += ones;
            return int.Parse(res);
        }

        public static Int64 highJoltage(string s, int n)
        {
            String res = "";
            var index = 0;

            for (int i = 0; i != n; i++)
            {
                var digit = s.Substring(index, (s.Length - index) - (n - i - 1)) .Max();
                index += s.Substring(index).IndexOf(digit) + 1;

                res += digit;
            }

            return Int64.Parse(res);
        }

        public static Int64 Day03b(string[] input)
        {
            Int64 sum = 0;
            foreach (var s in input)
            {
                sum += highJoltage(s, 12);
            }
            return sum;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day03.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day03a : {0}   Time: {1}", Day03a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day03b : {0}   Time: {1}", Day03b(lines), sw.ElapsedMilliseconds);
        }
    }
}
