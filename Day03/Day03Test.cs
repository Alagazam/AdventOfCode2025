using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day03Test
    {
        readonly string input =
@"987654321111111
811111111111119
234234234234278
818181911112111
";

        readonly Int64 resultA = 357;
        readonly Int64 resultB = 3121910778619;

        [Fact]
        public void Day03a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day03.Day03a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day03a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day03b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day03.Day03b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day03b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day03Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

        [Fact]
        public void JoltageTest()
        {
            Assert.Equal(98, Day03.highJoltage("987654321111111", 2));
            Assert.Equal(89, Day03.highJoltage("811111111111119", 2));
            Assert.Equal(78, Day03.highJoltage("234234234234278", 2));
            Assert.Equal(92, Day03.highJoltage("818181911112111", 2));
        }

        [Fact]
        public void HighJoltageTest()
        {
            Assert.Equal(98, Day03.highJoltage("987654321",2));
            Assert.Equal(9876, Day03.highJoltage("987654", 4));
            Assert.Equal(89, Day03.highJoltage("8119", 2));
            Assert.Equal(99, Day03.highJoltage("8989", 2));
            Assert.Equal(4342, Day03.highJoltage("42342", 4));
            Assert.Equal(987654321111, Day03.highJoltage("987654321111111", 12));
            Assert.Equal(811111111119, Day03.highJoltage("811111111111119", 12));
            Assert.Equal(434234234278, Day03.highJoltage("234234234234278", 12));
            Assert.Equal(888911112111, Day03.highJoltage("818181911112111", 12));
        }
    }

}
