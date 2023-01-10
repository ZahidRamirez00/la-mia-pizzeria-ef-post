namespace La_Mia_Pizzeria_1.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Prezzo { get; set; }

        public Pizza(int id, string name, string description, string image, string prezzo)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Prezzo = prezzo;    
        }
    }
}
