using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaFactory
{
     class Model_X_Factory : Tesla_Factory
     {
          public override Tesla_car Create()
          {
               Model_X phone = new Model_X();
               //very hard constructor
               return phone;
          }
     }
}
