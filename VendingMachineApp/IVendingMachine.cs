namespace VendingMachineApp
{
    // Interface representing a vending machine
    public interface IVendingMachine
    {
        // Method to select a product and trigger the dispensing process
        void SelectProduct(Product product);
    }
}
