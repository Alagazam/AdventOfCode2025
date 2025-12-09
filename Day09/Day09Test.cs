using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day09Test
    {
        readonly string input =
@"7,1
11,1
11,7
9,7
9,5
2,5
2,3
7,3
";

        readonly Int64 resultA = 50;
        readonly Int64 resultB = 0;

        [Fact]
        public void Day09a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day09.Day09a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day09a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day09b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day09.Day09b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day09b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day09Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

    }

}
