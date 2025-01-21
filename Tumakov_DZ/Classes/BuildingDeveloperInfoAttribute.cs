using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_DZ.Classes
{
    [AttributeUsage (AttributeTargets.Class,AllowMultiple = true)]
    internal class BuildingDeveloperInfoAttribute : Attribute
    {
        public string name;
        public string organisationName;

        public BuildingDeveloperInfoAttribute(string name, string organisationName)
        {
            this.name = name;
            this.organisationName = organisationName;
        }
    }
}
