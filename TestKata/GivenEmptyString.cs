using System;
using Kata;
using Xunit;

namespace TestKata
{
    public class GivenEmptyString
    {
        private KataClass _order = new KataClass();
        
        [Fact]
        public void ReturnsEmptyString()
        {
            string expected = "";
            Assert.Equal(expected, _order.Execute(""));
        }
    }

    public class GivenStringInCorrectOrder
    {
        private KataClass _order = new KataClass();

        [Fact]
        public void ReturnsStringInCorrectOrder()
        {
            string expected = "Hel1lo W2orld I3 A4m H5ere";
            Assert.Equal(expected, _order.Execute("Hel1lo W2orld I3 A4m H5ere"));
        }
        
        [Fact]
        public void ReturnsDifferentStringInCorrectOrder()
        {
            string expected = "Goodby1e 2Saturn";
            Assert.Equal(expected, _order.Execute("Goodby1e 2Saturn"));
        }
    }
}