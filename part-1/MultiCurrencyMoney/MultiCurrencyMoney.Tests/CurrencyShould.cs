using Xunit;

namespace MultiCurrencyMoney.Tests
{
    public class CurrencyShould
    {
        [Fact]
        public void ProvideTheCorrectAnswerToAMultiplication()
        {
            var five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
