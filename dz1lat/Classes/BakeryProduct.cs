using System;
using System.Xml.Linq;


namespace dz1lat.Classes
{
    public abstract class BakeryProduct
    {
        private string _name;
        private double _price;
        private int _calories;
     
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Название выпечки не может быть пустым.");
                _name = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0) throw new ArgumentException("Цена должна быть больше 0.");
                _price = value;
            }


        }
        public int Calories
        {
            get { return _calories; }
        }
        public Guid ProductId { get; }

        protected BakeryProduct(string name, double price, int calories)
        {
            ProductId = Guid.NewGuid();
            Name = name;
            Price = price;
            _calories = calories;
        }
        public abstract void Bake();
        public void ApplyDiscount(double percentage)
        {
            if (percentage > 0 && percentage <= 100)
            {
                Price -= Price * (percentage / 100);
            }
        }
    }
}

