using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day08Test
    {
        readonly string input =
@"162,817,812
57,618,57
906,360,560
592,479,940
352,342,300
466,668,158
542,29,236
431,825,988
739,650,466
52,470,668
216,146,977
819,987,18
117,168,530
805,96,715
346,949,466
970,615,88
941,993,340
862,61,35
984,92,344
425,690,689
";

        readonly Int64 resultA = 40;
        readonly Int64 resultB = 0;

        [Fact]
        public void Day08a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day08.Day08a(lines, 10);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day08a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day08b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day08.Day08b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day08b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day08Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

    }

}
