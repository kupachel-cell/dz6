using System;

namespace dz1lat.Classes
{
    public class Cake : BakeryProduct
    {
        private int _tiers;
        private string _filling;

        public int Tiers
        {
            get { return _tiers; }
            set { if (value > 0) _tiers = value; }
        }

        public string Filling
        {
            get { return _filling; }
            set { _filling = value; }
        }

        public Cake(string name, double price, int calories, int tiers, string filling)
            : base(name, price, calories)
        {
            Tiers = tiers;
            Filling = filling;
        }
        public override void Bake()
        {
            Console.WriteLine($"Коржи для торта '{Name}' выпекаются при 180°C. Будет добавлен крем: {Filling}.");
        }

        public void AddCandles(int count)
        {
            Console.WriteLine($"В торт '{Name}' установлено {count} свечей.");
        }
    }
}
