using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
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
                        if (IsValidId1(n)) result +=n;
                    }
                }
            }
            return result;
        }

        public static bool IsValidId1(long n)
        {
            var s = n.ToString();
            var l = s.Length;
            if (l % 2 == 0)
            {
                if (s.Substring(0, l / 2) == s.Substring(l / 2))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidId2(long n)
        {
            var s = n.ToString();
            var l = s.Length;
            for (var i = 2; i <= l; i++)
            {
                if (l % i == 0)
                {
                    var sub = l / i;
                    var s1 = s.Substring(0, sub);
                    bool same = true;
                    for (var j = 1; j < l / sub; j++)
                    {
                        if (s1 != s.Substring(sub * j, sub))
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same) return true;
                }
            }

            return false;
        }

        public static Int64 Day02b(string[] input)
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
                        if (IsValidId2(n)) result += n;
                    }
                }
            }
            return result;
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
