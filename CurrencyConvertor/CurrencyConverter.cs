using System;

namespace CurrencyConverterApp
{
        public class CurrencyConverter
    {
        // Properties for storing currency details
        public string FromCurrency { get; private set; }
        public string ToCurrency { get; private set; }
        public double ExchangeRate { get; private set; }

        // Static property to track total number of conversions
        private static int ConversionCount { get; set; } = 0;

        // Constructor 
        public CurrencyConverter(string fromCurrency, string toCurrency, double exchangeRate)
        {
            FromCurrency = fromCurrency;
            ToCurrency = toCurrency;
            ExchangeRate = exchangeRate;
        }

        // Method to convert amount using the default exchange rate
        public double ConvertAmount(double amount)
        {
            IncrementConversionCount();
            return amount * ExchangeRate;
        }

        // Overloaded method to convert amount using a custom exchange rate
        public double ConvertAmount(double amount, double customRate)
        {
            IncrementConversionCount();
            return amount * customRate;
        }

        // Static method to show the total number of conversions
        public static void ShowConversionCount()
        {
            Console.WriteLine($"Total conversions performed: {ConversionCount}");
        }

        // Private static method to increment the conversion count
        private static void IncrementConversionCount()
        {
            ConversionCount++;
        }
    }
}
