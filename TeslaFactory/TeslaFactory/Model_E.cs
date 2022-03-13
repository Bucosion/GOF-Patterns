using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaFactory
{
     class Model_E : Tesla_car
     {
          public Model_E() { }

          public override void asamblePhone(string line)
          {
               Console.WriteLine(line + " asamblarea Modelului E a inceput!");
          }
     }
}
