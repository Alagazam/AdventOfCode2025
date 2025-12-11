using System.Diagnostics;

namespace AoC
{
    public static class Day10
    {
        public static Int64 Day10a(string[] input)
        {
            Int64 result = 0;
            foreach (var i in input)
            {
                var parts = i.Split(' ');
                var lights_bin = new string(parts[0].Substring(1, parts[0].Length - 2).Replace('.', '0').Replace('#', '1').Reverse().ToArray());
                var lights = Convert.ToUInt32(lights_bin, 2);

                List<UInt32> buttons = new List<UInt32>();

                foreach (var p in parts.Skip(1).Take(parts.Length - 2))
                {
                    var bs = p.Substring(1, p.Length - 2).Split(',');
                    UInt32 binpush = 0;
                    foreach (var b in bs)
                    {
                        Int32 x = Int32.Parse(b);
                        binpush |= (UInt32)0b_1 << x;
                    }
                    buttons.Add(binpush);
                }

                Int64 min = Int64.MaxValue;

                UInt32 combos = (UInt32)0b_1 << buttons.Count;
                for (UInt32 n = 1; n != combos; ++n)
                {
                    UInt32 state = 0;
                    Int64 pushes = 0;
                    for (var b = 0; b < buttons.Count; ++b)
                    {
                        if ((n & ((UInt32)0b_1 << b)) != 0)
                        {
                            state ^= buttons[b];
                            ++pushes;
                        }
                    }
                    if (state == lights)
                    {
                        min = Math.Min(min, pushes);
                    }
                }

                result += min;
            }
            return result;
        }

        public static Int64 Day10b(string[] input)
        {
            return 0;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day10.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day10a : {0}   Time: {1}", Day10a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day10b : {0}   Time: {1}", Day10b(lines), sw.ElapsedMilliseconds);
        }
    }
}
