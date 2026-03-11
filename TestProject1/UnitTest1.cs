using lab1._2;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestСontribution1()
        {
            var result = Logic.CalculatingTheContribution(10000, 200, 12000);
            Assert.That(result.Contains("На 2 месяце было превышение"));
            Assert.That(result.Contains("Через 10 месяц(ев) мы накопим деньги"));
            Assert.That(result.Contains("Месяц 1: 10200,00 руб.  200,00"));
            Assert.That(result.Contains("Месяц 20:"));
        }

        [Test]
        public void TestСontribution2()
        {
            var result = Logic.CalculatingTheContribution(1000, 100, 3000);
            Assert.That(result.Contains("Месяц 1: 1020,00 руб.  20,00"));
            Assert.That(result.Contains("Месяц 20:"));
        }

        [Test]
        public void TestСontribution3()
        {
            var result = Logic.CalculatingTheContribution(2000, 200, 2000);
            Assert.That(result.Contains("Через 1 месяц(ев) мы накопим деньги"));
            Assert.That(result.Contains("Месяц 1: 2040,00 руб.  40,00"));
            Assert.That(result.Contains("Месяц 20:"));
        }

        [Test]
        public void TestСontribution4()
        {
            var result = Logic.CalculatingTheContribution(1000, 0, 1000);
            Assert.That(result.Contains("На 1 месяце было превышение"));
            Assert.That(result.Contains("Через 1 месяц(ев) мы накопим деньги"));
            Assert.That(result.Contains("Месяц 1: 1020,00 руб.  20,00"));
            Assert.That(result.Contains("Месяц 20:"));
        }
    }
}