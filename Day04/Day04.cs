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
            Int64 result = 0;
            for (var row = 0; row != input.Length; ++row)
            {
                string s = "";
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
                            s+='x';
                        }
                        else
                            s+=input[row][col];
                    }
                    else
                        s += input[row][col];
                }
                Console.WriteLine(s);
            }
            return result;
        }

        public static Int64 Day04b(string[] input)
        {
            return 0;
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
