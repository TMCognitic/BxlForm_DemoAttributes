using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAttributes.Attributes
{
    public class CuirAttribute : LootAttribute
    {
        public CuirAttribute(int maximum = 4) : base(maximum, "Cuir")
        {            
        }
    }
}
