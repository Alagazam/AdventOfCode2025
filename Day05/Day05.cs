using System.Diagnostics;
using Xunit.Sdk;

namespace AoC
{
    public static class Day05
    {
        public static Int64 Day05a(string[] input)
        {
            List<(Int64, Int64)> ranges = new List<(Int64, Int64)> ();
            List<Int64> ids = new List<Int64>();

            foreach (var s in input)
            {
                if (s.Length == 0) continue;
                var items = s.Split('-');
                if (items.Length == 2) ranges.Add((Int64.Parse(items[0]), Int64.Parse(items[1])));
                if (items.Length == 1) ids.Add(Int64.Parse(items[0]));
            }

            Int64 result = 0;
            foreach(var id in ids)
            {
                foreach(var range in ranges)
                {
                    if (range.Item1 <= id && id <= range.Item2)
                    {
                        ++result; 
                        break;
                    }
                }
            }
            return result;
        }

        public static Int64 Day05b(string[] input)
        {
            List<(Int64, Int64)> ranges = new List<(Int64, Int64)>();

            foreach (var s in input)
            {
                if (s.Length == 0) break;
                var items = s.Split('-');
                if (items.Length == 2) ranges.Add((Int64.Parse(items[0]), Int64.Parse(items[1])));
            }

            bool merged = false;
            int index = 0;
            do
            {
                merged = false;

                var a = ranges[index];
                for (int i = index+1; i < ranges.Count ; ++i)
                {
                    var b = ranges[i];
                    if (a.Item2 >= b.Item1 && a.Item1 <= b.Item2)
                    {
                        merged = true;
                        ranges[index] = (Math.Min(a.Item1, b.Item1), Math.Max(a.Item2, b.Item2));
                        ranges.RemoveAt(i);
                        break;
                    }
                }
                if (!merged) index++;
            } while (merged || index < ranges.Count);

            Int64 result = 0;
            foreach (var r in ranges)
            {
                result += r.Item2 - r.Item1 + 1;
            }

            return result;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day05.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day05a : {0}   Time: {1}", Day05a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day05b : {0}   Time: {1}", Day05b(lines), sw.ElapsedMilliseconds);
        }
    }
}
