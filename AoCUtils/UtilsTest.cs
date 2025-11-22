using Xunit;

namespace AoC
{
    public class UtilsTest
    {
        [Fact]
        public void GDC_Test()
        {
            Assert.Equal(5, Utils.GCD(5, 3*5));
            Assert.Equal(3*5, Utils.GCD(3*5, 3*3*5));
            Assert.Equal(1, Utils.GCD(1, 1));
            Assert.Equal(1, Utils.GCD(13, 17));
        }


        [Fact]
        public void LCM_Test()
        {
            Assert.Equal(60, Utils.LCM(new List<long> { 1,2,3,4,5 }));
            Assert.Equal(30, Utils.LCM(new List<long> { 2,3,5 }));
            Assert.Equal(24, Utils.LCM(new List<long> { 4, 6, 8 }));
            Assert.Equal(7, Utils.LCM(new List<long> { 7 }));

            Assert.Equal(-12, Utils.LCM(new List<long> { -4, 6 }));
            Assert.Equal(500000, Utils.LCM(new List<long> { 500000, 2 }));
            Assert.Equal(12, Utils.LCM(new List<long> { 3, 4, 6, 3 }));
            Assert.Equal(35, Utils.LCM(new List<long> { 5, 7 }));
        }
    }

}
