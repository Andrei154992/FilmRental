using Inventory;

namespace Repository
{
    public class ActorRepository
    {
        public Actor[] actors = new Actor[3]
        {
            new Actor(1, "Пенелопа", "Круз"),
            new Actor(2, "Джони", "Депп"),
            new Actor(3, "Бред", "Пит")
        };
    }
}
