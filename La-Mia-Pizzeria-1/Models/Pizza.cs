using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace La_Mia_Pizzeria_1.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Image { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Prezzo { get; set; }

        public Pizza() { }
        public Pizza(string name, string description, string image, string prezzo)
        {
            Name = name;
            Description = description;
            Image = image;
            Prezzo = prezzo;    
        }
    }
}
