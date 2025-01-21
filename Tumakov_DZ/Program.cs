#define DEBUG_ACCOUNT
using System.Reflection;
using Tumakov_DZ.Classes;

namespace Tumakov_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Ivan",1000,"Savings");
            #if DEBUG_ACCOUNT
            account.DumpToScreen();
            #endif
            var type = typeof(Building);
            var attributes = (BuildingDeveloperInfoAttribute[])type.GetCustomAttributes(typeof(BuildingDeveloperInfoAttribute), false);
            var attribute = attributes[0];
            Console.WriteLine($"Имя разработчика: {attribute.name} Организация:{attribute.organisationName}");
        }

    }
}
