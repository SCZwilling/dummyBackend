namespace RealEstateApp.Api.Entity
{
    public class Currency : PropertyFieldBase
    {
        public Currency() { }
        public Currency(string currency)
        {
            Value = currency;
        }

        public static List<Currency> GenerateDefault()
        {
            return new List<Currency>
            {
                new Currency("Rupee")
            };
        }
    }
}
