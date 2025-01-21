using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_DZ.Classes
{
    [AttributeUsage (AttributeTargets.Class,AllowMultiple = true)]
    internal class DeveloperInfoAttribute : Attribute
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DeveloperInfoAttribute(string name)
        {
            Name = name;
            Date = DateTime.Now;
        }

    }
}
