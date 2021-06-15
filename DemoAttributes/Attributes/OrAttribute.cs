using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class OrAttribute : LootAttribute
    {
        public OrAttribute(int maximum = 6) : base(maximum, "Or")
        {
        }
    }
}
