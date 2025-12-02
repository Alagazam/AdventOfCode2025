using System.Diagnostics;

namespace AoC
{
    public static class Day02
    {
        public static Int64 Day02a(string[] input)
        {
            Int64 result = 0;
            var intervals = input[0].Split(',');
            foreach (var i in intervals)
            {
                {
                    var ends = i.Split('-');
                    var start = Int64.Parse(ends[0]);
                    var end = Int64.Parse(ends[1]);
                    for (var n = start; n <= end; n++)
                    {
                        var s = n.ToString();
                        var l = s.Length;
                        if (l % 2 == 0)
                        {
                            if (s.Substring(0,l/2) == s.Substring(l/2))
                            {
                                result += n;
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static Int64 Day02b(string[] input)
        {
            return 0;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day02.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day02a : {0}   Time: {1}", Day02a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day02b : {0}   Time: {1}", Day02b(lines), sw.ElapsedMilliseconds);
        }
    }
}
