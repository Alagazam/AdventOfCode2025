using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day07Test
    {
        readonly string input =
@".......S.......
...............
.......^.......
...............
......^.^......
...............
.....^.^.^.....
...............
....^.^...^....
...............
...^.^...^.^...
...............
..^...^.....^..
...............
.^.^.^.^.^...^.
...............
";

        readonly Int64 resultA = 21;
        readonly Int64 resultB = 40;

        [Fact]
        public void Day07a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day07.Day07a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day07a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day07b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day07.Day07b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day07b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day07Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

    }

}
