using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace AoC
{
    public class Day01Test
    {
        readonly string input =
@"L68
L30
R48
L5
R60
L55
L1
L99
R14
L82";

        readonly Int64 resultA = 3;
        readonly Int64 resultB = 6;

        [Fact]
        public void Day01a()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day01.Day01a(lines);
            Assert.Equal(resultA, result);

            Console.WriteLine("Day01a : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }


        [Fact]
        public void Day01b()
        {
            var sw = Stopwatch.StartNew();
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var result = Day01.Day01b(lines);
            Assert.Equal(resultB, result);

            Console.WriteLine("Day01b : {0}   Time: {1}", result, sw.ElapsedMilliseconds);
        }

        public Day01Test(ITestOutputHelper output)
        {
            var converter = new AoCUtils.Converter(output);
            Console.SetOut(converter);
        }

        [Fact]
        public void TurnTest()
        {
            var dial = 0;
            dial = 0; Assert.Equal(0, Day01.Turn(ref dial, 0)); Assert.Equal(0, dial);
            dial = 0; Assert.Equal(0, Day01.Turn(ref dial, 10)); Assert.Equal(10, dial);
            dial = 0; Assert.Equal(1, Day01.Turn(ref dial, 100)); Assert.Equal(0, dial);
            dial = 0; Assert.Equal(1, Day01.Turn(ref dial, 110)); Assert.Equal(10, dial);
            dial = 0; Assert.Equal(2, Day01.Turn(ref dial, 210)); Assert.Equal(10, dial);

            dial = 10; Assert.Equal(0, Day01.Turn(ref dial, 0)); Assert.Equal(10, dial);
            dial = 10; Assert.Equal(0, Day01.Turn(ref dial, 10)); Assert.Equal(20, dial);
            dial = 10; Assert.Equal(1, Day01.Turn(ref dial, 90)); Assert.Equal(0, dial);
            dial = 10; Assert.Equal(1, Day01.Turn(ref dial, 100)); Assert.Equal(10, dial);
            dial = 10; Assert.Equal(1, Day01.Turn(ref dial, 110)); Assert.Equal(20, dial);
            dial = 10; Assert.Equal(2, Day01.Turn(ref dial, 210)); Assert.Equal(20, dial);
        }
        [Fact]
        public void TurnBackTest()
        {
            var dial = 0;
            dial = 0; Assert.Equal(0, Day01.Turn(ref dial, 0)); Assert.Equal(0, dial);
            dial = 0; Assert.Equal(0, Day01.Turn(ref dial, -10)); Assert.Equal(90, dial);
            dial = 0; Assert.Equal(1, Day01.Turn(ref dial, -100)); Assert.Equal(0, dial);
            dial = 0; Assert.Equal(1, Day01.Turn(ref dial, -110)); Assert.Equal(90, dial);
            dial = 0; Assert.Equal(2, Day01.Turn(ref dial, -210)); Assert.Equal(90, dial);

            dial = 10; Assert.Equal(1, Day01.Turn(ref dial, -10)); Assert.Equal(0, dial);
            dial = 10; Assert.Equal(1, Day01.Turn(ref dial, -90)); Assert.Equal(20, dial);
            dial = 10; Assert.Equal(1, Day01.Turn(ref dial, -100)); Assert.Equal(10, dial);
            dial = 10; Assert.Equal(2, Day01.Turn(ref dial, -110)); Assert.Equal(0, dial);
            dial = 10; Assert.Equal(3, Day01.Turn(ref dial, -210)); Assert.Equal(0, dial);
        }

    }

}
