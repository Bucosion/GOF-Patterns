using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaFactory
{
     class Model_E_Factory : Tesla_Factory
     {
          public override Tesla_car Create()
          {
               Model_E phone = new Model_E();
               //very hard constructor
               return phone;
          }
     }
}
