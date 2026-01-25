using Inventory;

namespace Repository
{
    public class InventoryRepository
    {
        public Inventory.Inventory[] inventories = new Inventory.Inventory[3]
        {
            new Inventory.Inventory(1, 1, 3),
            new Inventory.Inventory(2, 2, 3),
            new Inventory.Inventory(3, 3, 3)
        };
    }
}
