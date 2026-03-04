using lab1._2;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = Logic.Result(10000, 200, 12000);
            Assert.That(result.Contains("На 2 месяце было превышение"));
            Assert.That(result.Contains("Через 10 месяцев мы накопим деньги"));
            Assert.That(result.Contains("Месяц 1: 10200,00 руб.  200,00"));
            Assert.That(result.Contains("Месяц 50:"));
        }

        [Test]
        public void Test2()
        {
            var result = Logic.Result(1000, 100, 3000);
            Assert.That(result.Contains("Месяц 1: 1020,00 руб.  20,00"));
            Assert.That(result.Contains("Месяц 50:"));
        }
    }
}