using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day10Test
    {
        readonly string input =
@"[.##.] (3) (1,3) (2) (2,3) (0,2) (0,1) {3,5,4,7}
[...#.] (0,2,3,4) (2,3) (0,4) (0,1,2) (1,2,3,4) {7,5,12,7,2}
[.###.#] (0,1,2,3,4) (0,3,4) (0,1,2,4,5) (1,2) {10,11,11,5,10,5}
";

        readonly Int64 resultA = 7;
        readonly Int64 resultB = 0;

        [Fact]
        public void Day10a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day10.Day10a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day10a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day10b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day10.Day10b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day10b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day10Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

    }

}
