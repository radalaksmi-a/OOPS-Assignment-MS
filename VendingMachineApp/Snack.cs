using System;

namespace VendingMachineApp
{
    // Derived class representing a Snack product
    public class Snack : Product
    {
        // Constructor 
        public Snack()
        {
            Name = "Snack";
        }

        // Implementation of the abstract method to dispense a snack
        public override void Dispense()
        {
            Console.WriteLine("Dispensing a snack...");
        }
    }
}
