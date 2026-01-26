namespace Inventory.Interfaces
{
    public interface IFilmRepository
    {
        Film[] GetById(int filmId);
        Film[] GetByTitle(string filmTitle);
    }
}
