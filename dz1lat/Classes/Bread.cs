using System;

namespace dz1lat.Classes
{
    public class Bread : BakeryProduct
    {
        private string _flourType;
        private bool _isSliced;
        public string FlourType
        {
            get { return _flourType; }
            set { _flourType = value; }
        }

        public bool IsSliced
        {
            get { return _isSliced; }
            set { _isSliced = value; }
        }

        public Bread(string name, double price, int calories, string flourType)
            : base(name, price, calories)
        {
            FlourType = flourType;
            IsSliced = false;
        }
        public override void Bake()
        {
            Console.WriteLine($"Хлеб '{Name}' выпекается при 220°C до хрустящей корочки.");
        }
        public void Slice()
        {
            _isSliced = true;
            Console.WriteLine($"Хлеб '{Name}' успешно нарезан на ломтики.");
        }
    }
}
