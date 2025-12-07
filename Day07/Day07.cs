using System.Diagnostics;
using System.Reflection;

namespace AoC
{
    public static class Day07
    {
        public static Int64 Day07a(string[] input)
        {
            char[] beams = input[0].ToArray();
            Int64 result = 0;
            foreach (var i in input)
            { 
                foreach (var (c, n) in i.Select((c, n) => (c, n)))
                {
                    if (c == 'S') beams[n] = '|';
                    else if  (c == '^' && beams[n] == '|')
                    {
                        ++result;
                        beams[n - 1] = '|';
                        beams[n] = '.';
                        beams[n + 1] = '|';
                    }
                }
            }
            return result;
        }

        public static Int64 Day07b(string[] input)
        {
            return 0;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day07.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day07a : {0}   Time: {1}", Day07a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day07b : {0}   Time: {1}", Day07b(lines), sw.ElapsedMilliseconds);
        }
    }
}
