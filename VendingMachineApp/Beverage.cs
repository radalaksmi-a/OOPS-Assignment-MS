using System;

namespace VendingMachineApp
{
    // Derived class representing a Beverage product
    public class Beverage : Product
    {
        // Constructor
        public Beverage()
        {
            Name = "Beverage";
        }

        // Implementation of the abstract method to dispense a beverage
        public override void Dispense()
        {
            Console.WriteLine("Dispensing a beverage...");
        }
    }
}
