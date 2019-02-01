using System;
using Kata;
using Xunit;

namespace TestKata
{
    public class KataTest
    {
        private KataClass _order = new KataClass();
        
        [Fact]
        public void CanReturnString()
        {
            string expected = "";
            Assert.Equal(expected, _order.Execute());
        }
    }
}