using System;

namespace VendingMachineApp
{
    // Abstract class representing a product in the vending machine
    public abstract class Product
    {
        // Property to store the name of the product
        public string Name { get; protected set; }

        // Abstract method  for dispensing the product
        public abstract void Dispense();
    }
}
