using System;
using Kata;
using Xunit;

namespace TestKata
{
    public class KataTest
    {
        private KataClass _order = new KataClass();
        
        [Fact]
        public void CanReturnStringWhenGivenAnEmptyString()
        {
            string expected = "";
            Assert.Equal(expected, _order.Execute(""));
        }

        [Fact]
        public void GivenAStringInCorrectOrderReturnsSameString()
        {
            string expected = "Hel1lo W2orld I3 A4m H5ere";
            Assert.Equal(expected, _order.Execute("Hel1lo W2orld I3 A4m H5ere"));
        }
    }
}