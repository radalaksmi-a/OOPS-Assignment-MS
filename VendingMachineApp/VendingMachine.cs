using System;

namespace VendingMachineApp
{
    // Class representing a vending machine that implements the IVendingMachine interface
    public class VendingMachine : IVendingMachine
    {
        // Implementation of the SelectProduct method
        public void SelectProduct(Product product)
        {
            Console.WriteLine($"Selected Product: {product.Name}");
            product.Dispense();
        }
    }
}
