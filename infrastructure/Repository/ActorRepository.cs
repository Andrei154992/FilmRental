using Inventory;
using Inventory.Interfaces;

namespace Repository
{
    public class ActorRepository : IActorRepository
    {
        public Actor[] actors = new Actor[3]
        {
            new Actor(1, "Пенелопа", "Круз"),
            new Actor(2, "Джони", "Депп"),
            new Actor(3, "Бред", "Пит")
        };

        public Actor[] GetActorById(int actorId)
        {
            return actors.Where(actor => actor.actor_id == actorId)
                            .ToArray();
        }

        public Actor[] GetActorByName(string actorName)
        {
            return actors.Where(actor => actor.first_name == actorName 
                                        || actor.last_name == actorName)
                                    .ToArray();
        }
    }
}
