using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day05Test
    {
        readonly string input =
@"3-5
10-14
16-20
12-18

1
5
8
11
17
32
";

        readonly Int64 resultA = 3;
        readonly Int64 resultB = 0;

        [Fact]
        public void Day05a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day05.Day05a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day05a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day05b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day05.Day05b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day05b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day05Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

    }

}
