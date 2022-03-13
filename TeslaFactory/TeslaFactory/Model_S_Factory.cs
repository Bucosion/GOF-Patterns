using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaFactory
{
     class Model_S_Factory : Tesla_Factory
     {
          public override Tesla_car Create()
          {
               Model_S phone = new Model_S();
               //very hard constructor
               return phone;
          }
     }
}
