using System;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance for converting USD to INR with a default exchange rate
            CurrencyConverter usdToInrConverter = new CurrencyConverter("USD", "INR", 74.85);
            double amountInInr = usdToInrConverter.ConvertAmount(100); 
            Console.WriteLine($"100 USD to INR using default rate: {amountInInr} INR");

            // Perform conversion using a custom exchange rate
            amountInInr = usdToInrConverter.ConvertAmount(100, 75.00); 
            Console.WriteLine($"100 USD to INR using custom rate: {amountInInr} INR");

            // Create an instance for converting EUR to USD with a default exchange rate
            CurrencyConverter eurToUsdConverter = new CurrencyConverter("EUR", "USD", 1.18);
            // Perform conversion using the default rate
            double amountInUsd = eurToUsdConverter.ConvertAmount(50); 
            Console.WriteLine($"50 EUR to USD using default rate: {amountInUsd} USD");

            // Perform conversion using a custom exchange rate
            amountInUsd = eurToUsdConverter.ConvertAmount(50, 1.20); 
            Console.WriteLine($"50 EUR to USD using custom rate: {amountInUsd} USD");

            // Total number of conversions performed
            CurrencyConverter.ShowConversionCount();
        }
    }
}
