
using System;

namespace TeslaFactory
{
     class Model_Y : Tesla_car
     {
          public Model_Y() { }

          public override void asamblePhone(string line)
          {
               Console.WriteLine(line + " asamblarea Modelului Y a inceput!");
          }
     }
}
