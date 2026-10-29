using dz1lat.Classes;
using System;
namespace dz1lat
{
    internal class Program
    {
        static void BakeryApp()
        {
            Bakery myBakery = new Bakery("Свежий Хлеб & Торты");
            Bread borodinsky = new Bread("Бородинский", 45.0, 250, "Ржаная");
            Cake napoleon = new Cake("Наполеон", 850.0, 450, 1, "Заварной крем");
            borodinsky.Slice();
            napoleon.AddCandles(18);
            myBakery.AddToShowcase(borodinsky);
            myBakery.AddToShowcase(napoleon);
            myBakery.ProcessBaking();
            napoleon.ApplyDiscount(10);
            myBakery.PrintShowcase();

            Console.ReadLine();
        }


        static void Main(string[] args)
            {
            BakeryApp();
            }
        }
    
}
        
    



        
    

        

    
    

