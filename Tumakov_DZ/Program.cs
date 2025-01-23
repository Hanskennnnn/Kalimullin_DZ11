#define DEBUG_ACCOUNT
using System.Reflection;
using Tumakov_DZ.Classes;

namespace Tumakov_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task13_1();
            Task14_1();
            Task14_1DZ();
        }
        static public void Task13_1()
        {
            Building building = new Building();
            building.buildingNumber = 15;
            building.height = 50;
            building.floors = 20;
            building.apartments = 420;
            building.entrances = 50;
            building.PrintBuildingInformation();
        }
        static public void Task14_1()
        {
            BankAccount account = new BankAccount("Ivan", 1000, "Savings");
            #if DEBUG_ACCOUNT
            account.DumpToScreen();
            #endif
        }
        static public void Task14_1DZ()
        {
            var typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach (Attribute atr in attrs)
            {
                if (atr is BuildingDeveloperInfoAttribute)
                {

                    BuildingDeveloperInfoAttribute dia = (BuildingDeveloperInfoAttribute)atr;
                    Console.WriteLine($"{dia.name},{dia.organisationName}");
                }
            }
        }


    }
}
