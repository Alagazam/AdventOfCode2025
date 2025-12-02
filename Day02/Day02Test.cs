using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day02Test
    {
        readonly string input = "11-22,95-115,998-1012,1188511880-1188511890,222220-222224," +
                                "1698522-1698528,446443-446449,38593856-38593862,565653-565659," +
                                "824824821-824824827,2121212118-2121212124";

        readonly Int64 resultA = 1227775554;
        readonly Int64 resultB = 0;

        [Fact]
        public void Day02a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day02.Day02a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day02a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day02b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day02.Day02b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day02b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day02Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

    }

}
