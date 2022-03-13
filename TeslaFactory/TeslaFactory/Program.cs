using System;

namespace TeslaFactory
{
     class Program
     {
          static void Main(string[] args)
          {
               Tesla_Factory factory = new Model_S_Factory();

               Tesla_car line1 = factory.Create();
               Tesla_car line2 = factory.Create();
               Tesla_car line3 = factory.Create();
               Tesla_car line4 = factory.Create();

               line1.asamblePhone("Linia S -");
               line2.asamblePhone("Linia E -");
               line3.asamblePhone("Linia X -");
               line3.asamblePhone("Linia Y -");


          }
     }
}
