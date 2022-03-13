using System;
using System.Threading.Tasks;

namespace Sabloane_Proiectare
{
     class Program
     {
          static void Main(string[] args)
          {
               int x = 0, y = 0;

               //while (y <= 5)
               //{
               //     Singleton.GetInstance().Move(x);
               //     x++;
               //     y++;
               //}

               Console.WriteLine("Testează Task-ul!");

               Task.Run(() => Singleton.GetInstance().Move(1));
               Task.Run(() => Singleton.GetInstance().Move(2));
               Console.ReadLine();
          }
     }
}
