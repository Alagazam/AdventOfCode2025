using System.Diagnostics;

namespace AoC
{
    public static class Day04
    {
        static readonly (int,int)[] directions = {
            ( -1, -1 ), ( 0, -1 ), ( 1, -1 ),
            ( -1, 0 ), ( 0, 0 ), ( 1, 0 ),
            ( -1, 1 ), ( 0, 1 ), ( 1, 1 ),
        };

        public static Int64 Day04a(string[] input)
        {
            return remove(input, false);
        }

        public static Int64 Day04b(string[] input)
        {
            Int64 result = 0;
            Int64 removed = 0;
            do
            {
                removed = remove(input, true);
                result += removed;
            } while (removed != 0);
            return result;
        }

        private static Int64 remove(string[] input, bool doRemove)
        {
            Int64 result = 0;
            for (var row = 0; row != input.Length; ++row)
            {
                for (var col = 0; col != input[row].Length; ++col)
                {
                    if (input[row][col] == '@')
                    {
                        int neighbours = 0;
                        foreach (var dir in directions)
                        {
                            var r = row + dir.Item2;
                            var c = col + dir.Item1;
                            if (r >= 0 && r < input.Length &&
                                c >= 0 && c < input[r].Length &&
                                input[r][c] == '@') neighbours++;
                        }
                        if (neighbours <= 4) // Include itself
                        {
                            result++;
                            if (doRemove)
                            {
                                System.Text.StringBuilder s = new System.Text.StringBuilder(input[row]);
                                s[col] = '.';
                                input[row] = s.ToString();
                            }
                        }
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day04.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day04a : {0}   Time: {1}", Day04a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day04b : {0}   Time: {1}", Day04b(lines), sw.ElapsedMilliseconds);
        }
    }
}
