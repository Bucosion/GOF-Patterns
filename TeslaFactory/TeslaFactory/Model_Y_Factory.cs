using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaFactory
{
     class Model_Y_Factory : Tesla_Factory
     {
          public override Tesla_car Create()
          {
               Model_Y phone = new Model_Y();
               //very hard constructor
               return phone;
          }
     }
}
