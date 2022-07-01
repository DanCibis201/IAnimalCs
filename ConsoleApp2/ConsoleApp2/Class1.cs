using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     internal class Animal : IAnimal
     {
          public int Age
          {
               get
               {
                    return this.Age == 0 ? 1 : 2;
               }
               set
               {
                    if (value < 5) throw new Exception("Animale cu varsta de 5 ani nu exista");
                    Age = value;
               }
          }

          public int Sum(int a , int b, int c=0)
          {

               //throw new Exception("Eroarghfghghe!");

               try
               {
                    var x = 5 / c;
               }
               catch (DivideByZeroException e)
               {
                    throw new Exception("hhhhhhhhhhhhhhhhhhhh!");
                    Console.WriteLine(e.Message);
               }
               catch (Exception e)
               {
                    throw new Exception("Eroarghfghghe!");
                    Console.WriteLine(e.Message);
               }

               finally 
               { 
                    Console.WriteLine("Gudbai");
               }







               return a + b + c;
          }

          public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
          public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

          public void Eat()
          {
               throw new NotImplementedException();
          }

          public List <T> Summ<T>(T a, T b)
          {
               return new List<T>() { a, b};
          }
     }
}
