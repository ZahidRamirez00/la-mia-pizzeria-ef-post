using Microsoft.AspNetCore.Mvc;
using La_Mia_Pizzeria_1.Models;
using La_Mia_Pizzeria_1.Utils;
using System.Diagnostics;

namespace La_Mia_Pizzeria_1.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> listaDellePizze = PizzeData.GetPizze();

            return View("Index", listaDellePizze);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> listaDellePizze = PizzeData.GetPizze();

            foreach (Pizza pizza in listaDellePizze)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("Il post con l'id cercato non esiste!");
        }

        public IActionResult Esempio(string nome, string cognome, int eta)
        {
            return Ok("Hai inserito parametro nome: " + nome + " parametro cognome: " + cognome + " parametro eta: " + eta);
        }
    }
}
