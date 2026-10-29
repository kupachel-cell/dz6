using System;
using System.Collections.Generic;


namespace dz1lat.Classes
{
    public class Bakery
    {
        private string _bakeryName;
        private List<BakeryProduct> _showcase;

        public string BakeryName
        {
            get { return _bakeryName; }
            set { _bakeryName = value; }
        }

        public int ProductCount
        {
            get { return _showcase.Count; }
        }

        public Bakery(string name)
        {
            BakeryName = name;
            _showcase = new List<BakeryProduct>();
        }

        public void AddToShowcase(BakeryProduct product)
        {
            _showcase.Add(product);
            Console.WriteLine($"Товар '{product.Name}' добавлен на витрину.");
        }

        public void ProcessBaking()
        {
            Console.WriteLine($"\nПекарня '{BakeryName}' начинает работу");
            foreach (var product in _showcase)
            {
                product.Bake();
            }
        }

        public void PrintShowcase()
        {
            Console.WriteLine($"\nВитрина пекарни '{BakeryName}'");
            foreach (var product in _showcase)
            {
                Console.WriteLine($"[Id товара:{product.ProductId}] {product.Name} | Цена: {product.Price} руб. | Калории: {product.Calories} ккал");
            }
        }
    }
}
