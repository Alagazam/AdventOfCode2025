using System.Diagnostics;

namespace AoC
{
    record Point (Int64 x, Int64 y);

    public static class Day09
    {
        public static Int64 Day09a(string[] input)
        {
            var redTiles = input.Select(i => i.Split(',')).Select(t => new Point(Int64.Parse(t[0]), Int64.Parse(t[1])));
            Int64 maxRect = 0;
            foreach (var tile1 in redTiles)
            {
                foreach (var tile2 in redTiles)
                {
                    maxRect = Math.Max(maxRect, Math.Abs(tile1.x - tile2.x + 1) * Math.Abs(tile1.y - tile2.y + 1));
                }
            }
            return maxRect;
        }

        public static Int64 Day09b(string[] input)
        {
            return 0;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day09.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day09a : {0}   Time: {1}", Day09a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day09b : {0}   Time: {1}", Day09b(lines), sw.ElapsedMilliseconds);
        }
    }
}
