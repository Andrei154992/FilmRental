using Inventory;

namespace Repository
{
    public class CategoryRepository
    {
        public Category[] categories = new Category[3]
        {
            new Category(1, "Боевик"),
            new Category(2, "Драма"),
            new Category(3, "Комедия")
        };
    }
}
