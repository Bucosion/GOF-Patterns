using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaFactory
{
     class Model_S : Tesla_car
     {
          public Model_S() { }

          public override void asamblePhone(string line)
          {
               Console.WriteLine(line + " asamblarea Modelului S a inceput!");
          }
     }
}
