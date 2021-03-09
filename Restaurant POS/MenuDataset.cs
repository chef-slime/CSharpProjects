using System.Collections.Generic;

namespace Restaurant_POS
{
    public class MenuDataset
    {
        public const string Barley_Tea = "Barley Tea";
        public const string Matcha_Latte = "Matcha Latte";
        public const string Qoo = "Qoo";
        public const string Ramune = "Ramune";
        public const string Calpis = "Calpis";
        public const string Dango = "Dango";
        public const string Daifuku = "Daifuku";
        public const string Kakigori = "Kakigori";
        public const string Taiyaki = "Taiyaki";
        public const string Dorayaki = "Dorayaki";
        public const string Omurice = "Omurice";
        public const string Katsu_Curry = "Katsu Curry";
        public const string Tonjiru = "Tonjiru";
        public const string Shoyu_Ramen = "Shoyu Ramen";
        public const string Tonkotsu_Ramen = "Tonkotsu Ramen";
        public const string Yakitori = "Yakitori";
        public const string Okonomiyaki = "Okonomiyaki";
        public const string Teriyaki_Bao = "Teriyaki Bao";
        public const string Gyoza = "Gyoza";
        public const string Korokke = "Korokke";


        public static Dictionary<string, double> ItemCost = new Dictionary<string, double> {
            { Barley_Tea, 1},
            { Matcha_Latte, 5.6 },
            { Qoo, 1 },
            { Ramune, 1.5 },
            { Calpis, 6.18 },
            { Dango, 6.52 },
            { Daifuku, 3.5 },
            { Kakigori, 8.03 },
            { Taiyaki, 1.42 },
            { Dorayaki, 1.94 },
            { Omurice, 5.28 },
            { Katsu_Curry, 11.45 },
            { Tonjiru, 3.5 },
            { Shoyu_Ramen, 7.5 },
            { Tonkotsu_Ramen, 6 },
            { Yakitori, 4 },
            { Okonomiyaki, 3.5 },
            { Teriyaki_Bao, 3.75 },
            { Gyoza, 3 },
            { Korokke, 1 }
        };
    }
}
