using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day06Test
    {
        readonly string input =
@"123 328  51 64 
 45 64  387 23 
  6 98  215 314
*   +   *   +  
";

        readonly Int64 resultA = 4277556;
        readonly Int64 resultB = 0;

        [Fact]
        public void Day06a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day06.Day06a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day06a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day06b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day06.Day06b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day06b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day06Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

    }

}
