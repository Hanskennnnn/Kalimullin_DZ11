using Tumakov_DZ.Classes;

namespace Tumakov_DZ
{
    [BuildingDeveloperInfo("Almaz"," OOO 'RSF'")]
    public class Building
    {
        public int buildingNumber
        {
            get
            {
                return buildingNumber;
            }
            set
            {
                buildingNumber = value;
            }
        }
        public double height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int floors
        {
            get
            {
                return floors;
            }
            set
            {
                floors = value;
            }
        }
        public int apartments
        {
            get
            {
                return apartments;
            }
            set
            {
                apartments = value;
            }
        }
        public int entrances
        {
            get
            {
                return entrances;
            }
            set
            {
                entrances = value;
            }
        }
        public List<BankTransaction>? Transactions;

        public Building()
        {

        }
        public string PrintBuildingNumber()
        {
            return $"Уникальный номер здания: {buildingNumber}";
        }

        public string PrintHeight()
        {
            return $"Высота здания: {height} м";
        }

        public string PrintFloors()
        {
            return $"Этажность здания: {floors} этажей";
        }

        public string PrintApartments()
        {
            return $"Общее количество квартир: {apartments}";
        }

        public string PrintEntrances()
        {
            return $"Количество подъездов: {entrances}";
        }


        private bool IsValidConfiguration()
        {
            return apartments % entrances == 0 && (apartments / entrances) % floors == 0;
        }
        private double CalculateFloorHeight()
        {
            return height / floors;
        }

        private int CalculateApartmentsPerEntrance()
        {
            return apartments / entrances;
        }

        private int CalculateApartmentsPerFloor()
        {
            return apartments / floors;
        }
        public void PrintBuildingInformation()
        {
            Console.WriteLine($"\nЗдание №{buildingNumber}");
            Console.WriteLine($"Высота: {height} м");
            Console.WriteLine($"Этажей: {floors}");
            Console.WriteLine($"Квартир: {apartments}");
            Console.WriteLine($"Подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {CalculateFloorHeight():F2} м");
            Console.WriteLine($"Квартир в подъезде: {CalculateApartmentsPerEntrance()}");
            Console.WriteLine($"Квартир на этаже: {CalculateApartmentsPerFloor()}");
        }
    }
}
