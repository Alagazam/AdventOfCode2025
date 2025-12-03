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

        public static Int64 Day03b(string[] input)
        {
            return 0;
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
