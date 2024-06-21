public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;

    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("The Product is out of stock");
        }

    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.

        if (QuantityInStock > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.Write($"Item Name: {ItemName}\n");
        Console.Write($"ItemId: {ItemId}\n");
        Console.Write($"Price: {Price} \n");
        Console.Write($"QuantityInStock: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:

        // 1. Print details of all items.
        Console.WriteLine("***Inventory:***");
        item1.PrintDetails();
        Console.WriteLine();
        item2.PrintDetails();
        Console.WriteLine();

        // 2. Sell some items and then print the updated details.
        item1.SellItem(10);
        item2.SellItem(6);
        Console.WriteLine("\nInventory after selling items:");
        item1.PrintDetails();
        Console.WriteLine();
        item2.PrintDetails();
        Console.WriteLine();

        // 3. Restock an item and print the updated details.
        item1.RestockItem(10);
        item2.RestockItem(10);
        Console.WriteLine("\nInventory after restocking items:");
        item1.PrintDetails();
        Console.WriteLine();
        item2.PrintDetails();
        Console.WriteLine();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine("\nStock status:");
        Console.WriteLine($"{item1.ItemName} is {(item1.IsInStock() ? "in stock" : "out of stock")}.");
        Console.WriteLine($"{item2.ItemName} is {(item2.IsInStock() ? "in stock" : "out of stock")}.");


    }
}
