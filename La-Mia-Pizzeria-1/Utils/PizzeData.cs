using La_Mia_Pizzeria_1.Models;

namespace La_Mia_Pizzeria_1.Utils
{
    public static class PizzeData
    {
        private static List<Pizza> pizze;
        
        public static List<Pizza> GetPizze()
        {
            List<string> nomi = new List<string> { "Marinara", "Margherita", "Pugliese", "Napoli", "Funghi", "Prosciutto cotto", "Carciofi", "Romana", "Zola", "alla Scamorza", "Prosciutto e funghi" };
            List<string> descrizioni = new List<string> { "(pomodoro, origano, aglio ed olio)", "(pomodoroe mozzarella)", "(pomodoro, mozzarella e cipolla)", "(pomodoro, mozzarella e acciughe)", "(pomodoro, mozzarella e funghi)", "(pomodoro, mozzarella e prosciutto cotto)", "(pomodoro, mozzarella e carciofi)", "(pomodoro, mozzarella, acciughe, capperi, olive e origano)", "(pomodoro, mozzarella e zola)", "(pomodoro e scamorza)", "(pomodoro, mozzarella, prosciutto cotto e funghi)" };
            List<string> immagini = new List<string> { "pizza_0.jpg", "pizza_1.jpg", "pizza_2.jpg", "pizza_3.jpg", "pizza_4.jpg", "pizza_5.jpg", "pizza_6.jpg", "pizza_7.jpg", "pizza_8.jpg", "pizza_9.jpg", "pizza_10.jpg" };
            List<double> prezzi = new List<double> { 8.50, 4.50, 7.50, 6.50, 6.50, 5.50, 6.50, 6.50, 5.50, 5.50, 7.50 };
            if(pizze != null) return pizze;

            pizze = new List<Pizza>();

            for(int i = 0; i < nomi.Count; i++)
            {
                Pizza pizza = new Pizza(nomi[i], descrizioni[i], immagini[i], prezzi[i]);
                pizze.Add(pizza);
            }
            return pizze;
        }
    }
}
