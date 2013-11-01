namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public Dollar(int i)
        {
            Amount = i;
        }

        public int Amount { get; set; }

        public void Times(int i)
        {
            Amount = Amount * 2;
        }
    }
}