using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaFactory
{
     class Model_X : Tesla_car
     {
          public Model_X() { }

          public override void asamblePhone(string line)
          {
               Console.WriteLine(line + " asamblarea Modelului X a inceput!");
          }
     }
}
