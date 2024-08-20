using System;

namespace VendingMachineApp
{
    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            
            VendingMachine vendingMachine = new VendingMachine();

                        Product snack = new Snack();
            Product beverage = new Beverage();

            // Select and dispense the Snack product
            vendingMachine.SelectProduct(snack);

            // Select and dispense the Beverage product
            vendingMachine.SelectProduct(beverage);

            
            Console.ReadLine();
        }
    }
}
