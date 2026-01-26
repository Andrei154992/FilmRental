using Inventory;
using Inventory.Interfaces;

namespace Repository
{
    public class FilmRepository : IFilmRepository
    {
        public Film[] films = new Film[3]
        {
            new Film(
                1, "Академия динозавров", "Эпическая драма о феминистке и Безумном ученом, " +
                "которые должны сразиться с Учителем в Канадских Скалистых горах",
                2006, 1, 1, 2, 0.99, 20.99m),
            new Film(
                2, "Голдфингер", "Поразительное послание администратора базы данных и исследователя," +
                " который должен найти автомобиль в Древнем Китае.",
                2006, 1, 1, 3, 4.99, 12.99m),
            new Film(3, "Ямы", "Поразительное изображение Лесоруба и Машины, которые должны " +
                "потопить Лесоруба на фабрике по производству воздушных шаров.",
                2006, 1, 7, 4, 2.99, 18.99m)
        };

        public Film[] GetById(int filmId)
        {
            return films.Where(film => film.film_id == filmId)
                            .ToArray();
        }

        public Film[] GetByTitle(string filmTitle)
        {
            return films.Where(film => film.title == filmTitle)
                    .ToArray();  
        }
    }
}
