namespace Inventory.Interfaces
{
    public interface IActorRepository
    {
        Actor[] GetActorById(int actorId);
        Actor[] GetActorByName(string actorName);
    }
}
