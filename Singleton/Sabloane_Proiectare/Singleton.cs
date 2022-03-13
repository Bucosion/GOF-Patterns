using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabloane_Proiectare
{
     class Singleton
     {
          private static Singleton _instance;  
          private static object locker = new object();
          public static void Print()
          {
               Console.WriteLine("Bună!");
          }

          public void Move(int x)
          {
               if (x % 2 == 0)
               {
                    Console.WriteLine("Jucatorul alb a mutat!");
               }
               else
               {
                    Console.WriteLine("Jucatorul negru a a mutat!");
               }
          }

          private Singleton()  
          {
               Console.WriteLine("Tabla a fost creata cu succes");
          }

          public static Singleton GetInstance() 
          {
               if (_instance == null) 
               {
                    lock (locker)
                    {
                         if (_instance == null)
                         {
                              _instance = new Singleton();
                         }
                    }
               }
               return _instance;
          }
     }
}