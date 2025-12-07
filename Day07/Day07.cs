using System.Diagnostics;
using System.Reflection;
using System.Text;

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
            Int64[] beams = new Int64[input[0].Length];
            Int64 result = 0;
            foreach (var (i, row) in input.Select((i, row) => (i, row)))
            {
                foreach (var (c, n) in i.Select((c, n) => (c, n)))
                {
                    if (c == 'S') beams[n] = 1;
                    else if (c == '^' && beams[n] >0)
                    {
                        beams[n - 1] += beams[n];
                        beams[n + 1] += beams[n];
                        beams[n] = 0;
                    }
                }
            }
            result = beams.Sum();
            return result;
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
