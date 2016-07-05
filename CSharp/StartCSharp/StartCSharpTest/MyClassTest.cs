
using NFluent;
using Xunit;

namespace StartCSharpTest
{
    public class MyClassTest
    {

        [Fact]
        public void MyMethodShould()
        {
            Check.That(true).IsFalse();
        }
    }
}
