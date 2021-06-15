using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class LootAttribute : Attribute
    {
        private readonly Random _de;
        private readonly int _maximum;
        private readonly string _nom;

        protected LootAttribute(int maximum, string nom)
        {
            _de = new Random();
            _maximum = maximum;
            _nom = nom;
        }

        public int Quantite
        {
            get { return _de.Next(_maximum) + 1; }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }
        }
    }
}
