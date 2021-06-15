using DemoAttributes.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DemoAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Monstre> monstres = new List<Monstre>();
            monstres.AddRange(new Monstre[]
            {
                new Loup(),
                new Orque(),
                new Dragon(),
                new OrqueDesMontagnes()
            });


            foreach(Monstre monstre in monstres)
            {
                Depouille(monstre);
            }
        }

        static void Depouille(Monstre monstre)
        {
            Type monstreType = monstre.GetType();
            Console.WriteLine($"Je dépouille un monstre de type : {monstreType.Name}");

            IEnumerable<LootAttribute> lootAttributes = monstreType.GetCustomAttributes<LootAttribute>();

            foreach(LootAttribute lootAttribute in lootAttributes)
            {
                Console.WriteLine($"{lootAttribute.Nom} : Je ramasse {lootAttribute.Quantite} pièce(s)");
            }

            Console.WriteLine();
        }
    }

    
}
