namespace Inventory
{
    public class Language
    {
        public int language_id { get; set; }
        public string name { get; set; }

        public Language(int language_id, string name)
        {
            this.language_id = language_id;
            this.name = name;
        }
    }
}
