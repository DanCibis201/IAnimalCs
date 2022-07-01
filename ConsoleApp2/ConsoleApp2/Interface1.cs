using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     internal interface IAnimal
     {
          public string Name { get;  set; }
          public string Description { get; set; }


          public void Move()
          {
               Console.WriteLine("Animalul fuge");
          }

          public void Eat();

     }
}
