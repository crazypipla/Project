using NUnit.Framework;

namespace Вычислитель
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void B()
        {
            var actual = Program.A(1, "+", 2);
            var expected = "3";
            Assert.AreEqual(expected, actual);
        }
    
        [Test]
        public void C()
        {
            var actual = Program.A(2, "*", 2);
            var expected = "4";
            Assert.AreEqual(expected, actual);
        }
    
        [Test]
        public void E()
        {
            var actual = Program.A(5, "-", 2);
            var expected = "3";
            Assert.AreEqual(expected, actual);
        }
    
        [Test]
        public void D()
        {
            var actual = Program.A(2, "/", 2);
            var expected = "1";
            Assert.AreEqual(expected, actual);
        }
    
        [Test]
        public void Q()
        {
            var actual = Program.A(2, "/", 0);
            var expected = "На ноль делить нельзя!";
            Assert.AreEqual(expected, actual);
        }
    
        [Test]
        public void W()
        {
            var actual = Program.A(2, "%", 2);
            var expected = "Ошибка, выберите указанную операцию";
            Assert.AreEqual(expected, actual);
        }
    }
}
