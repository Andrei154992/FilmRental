namespace Inventory
{
    public class Film
    {
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int release_year { get; set; }
        public int language_id { get; set; }
        public int original_language_id { get; set; }
        public int rental_duration { get; set; }
        public double rental_rate { get; set; }
        public decimal replacement_cost { get; set; }

        public Film(int film_id, string title, string description, 
                    int release_year, int language_id, 
                    int original_language_id, int rental_duration, 
                    double rental_rate, decimal replacement_cost)
        {
            this.film_id = film_id;
            this.title = title;
            this.description = description;
            this.release_year = release_year;
            this.language_id = language_id;
            this.original_language_id = original_language_id;
            this.rental_duration = rental_duration;
            this.rental_rate = rental_rate;
            this.replacement_cost = replacement_cost;
        }
    }
}
