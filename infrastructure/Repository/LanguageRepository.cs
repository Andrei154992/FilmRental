using Inventory;

namespace Repository
{
    public class LanguageRepository
    {
        public Language[] languages = new Language[3]
        {
            new Language(1, "Русский"),
            new Language(2, "Японский"),
            new Language(3, "Английский"),
        };
    }
}
