namespace Inventory
{
    public class Actor
    {
        public int actor_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public Actor(int actor_id, string first_name, string last_name)
        {
            this.actor_id = actor_id;
            this.first_name = first_name;
            this.last_name = last_name;
        }
    }
}
