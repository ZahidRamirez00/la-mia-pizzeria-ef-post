using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using La_Mia_Pizzeria_1.Models;
using La_Mia_Pizzeria_1.Utils;
using System.Diagnostics;
using La_Mia_Pizzeria_1.DataBase;

namespace La_Mia_Pizzeria_1.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            using(PizzeContext db = new PizzeContext())
            {
                //List<Pizza> listaDellePizze = PizzeData.GetPizze();
                List<Pizza> listaDellePizze = db.Pizze.ToList<Pizza>();
                return View("Index", listaDellePizze);
            }
        }

        public IActionResult Details(int id)
        {
            using(PizzeContext db = new PizzeContext())
            {
                Pizza pizzaTrovato = db.Pizze
                    .Where(SingolaPizzaNelDb => SingolaPizzaNelDb.Id == id)
                    .FirstOrDefault();

                if (pizzaTrovato != null)
                {
                    return View(pizzaTrovato);
                }
                
                return NotFound("La pizza con l'id cercato non esiste!");
            }
            /*List<Pizza> listaDellePizze = PizzeData.GetPizze();

            foreach (Pizza pizza in listaDellePizze)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("Il post con l'id cercato non esiste!");*/
        }

        public IActionResult Esempio(string nome, string cognome, int eta)
        {
            return Ok("Hai inserito parametro nome: " + nome + " parametro cognome: " + cognome + " parametro eta: " + eta);
        }
    }
}
