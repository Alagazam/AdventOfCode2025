using System.Diagnostics;

namespace AoC
{
    public static class Day06
    {
        public static Int64 Day06a(string[] input)
        {
            var row1 = input[0].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var row2 = input[1].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var row3 = input[2].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var row4 = input[3].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var op = input[input.Length - 1].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            Int64 result = 0;
            for (int i = 0; i!=row1.Length; ++i)
            {
                var a = Int64.Parse(row1[i]);
                var b = Int64.Parse(row2[i]);
                var c = Int64.Parse(row3[i]);
                Int64 d_add = 0;
                Int64 d_mul = 1;
                if (input.Length == 5)
                {
                    d_add = Int64.Parse(row4[i]);
                    d_mul = d_add;
                }

                Int64 s = 0;
                if (op[i] == "+") s = a + b + c + d_add;
                if (op[i] == "*") s = a * b * c * d_mul;
                result += s;
            }
            return result;
        }

        public static Int64 Day06b(string[] input)
        {
            Int64 result = 0;
            string[] flipped = new  string[input[0].Length +1];
            for (var col = 0; col != input[0].Length; ++col)
            {
                var s = "" + input[0][col] + input[1][col] + input[2][col] + input[3][col];
                if (input.Length == 5)
                {
                    s += input[4][col];
                }
                flipped[col] = s;
            }
            flipped[input[0].Length] = "     ";

            bool mul = false;
            Int64 tot = 0;
            foreach (var s in flipped)
            {
                if (s[0] == ' ' && s[1] == ' ' && s[2] == ' ' && s[3] == ' ')
                {
                    result += tot;
                    mul = false;
                    tot = 0;
                }
                else
                {
                    Int64 x = 0;
                    if (s[s.Length - 1] == '*') { mul = true; tot = 1; }
                    var ss = s.Substring(0, s.Length - 1).Trim();
                    x = Int64.Parse(ss);
                    if (mul) tot *= x;
                    else tot += x;
                }
            }


            return result;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day06.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day06a : {0}   Time: {1}", Day06a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day06b : {0}   Time: {1}", Day06b(lines), sw.ElapsedMilliseconds);
        }
    }
}
