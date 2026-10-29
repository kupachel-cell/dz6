using System;
namespace dz1tum.classes
{
     public class Building
    {
        private Guid id;
        private double Height;
        private int Floors;
        private int Apartments;
        private int Entrances;

        public Building(double height, int floors, int apartments, int entrances)
        {
            id = Guid.NewGuid(); 
            SetBuildingData(height, floors, apartments, entrances);
        }

        public void SetBuildingData(double height, int floors, int apartments, int entrances)
        {
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;
        }
        public Guid GetId()
        {
            return id;
        }

        public double GetHeight()
        {
            return Height;
        }

        public int GetFloors()
        {
            return Floors;
        }

        public int GetApartments()
        {
            return Apartments;
        }

        public int GetEntrances()
        {
            return Entrances;
        }
        public double CalculateFloorHeight()
        {
            return Height /Floors;
        }

        public int CalculateApartmentsPerEntrance()
        {
            return Apartments / Entrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            return Apartments / Floors;
        }

        public int CalculateApartmentsPerFloorInEntrance()
        {
            return Apartments / (Floors * Entrances);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ID здания: {GetId()}\nВысота(в метрах): {GetHeight()}\nКоличество этажей: {GetFloors()}\nКоличество подъездов: {GetEntrances()}\nВсего квартир: {GetApartments()}\nВысота одного этажа(в метрах): {CalculateFloorHeight():F2}\nКвартир в подъезде: {CalculateApartmentsPerEntrance()}\nКвартир на этаже в подъезде: {CalculateApartmentsPerFloorInEntrance()}");
        }
    }
}
