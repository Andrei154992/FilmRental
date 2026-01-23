namespace Inventory
{
    public class Inventory
    {
        public int inventory_id { get; set; }
        public int film_id { get; set; }
        public int store_id { get; set; }

        public Inventory(int inventory_id, int film_id, int store_id)
        {
            this.inventory_id = inventory_id;
            this.film_id = film_id;
            this.store_id = store_id;
        }
    }
}
