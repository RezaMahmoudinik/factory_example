using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_ex
{
   abstract class creator
    {
        public abstract product Items();
    }
  
    class Concretecreator_one : creator
    {
        public override product Items()
        {
            return new Concreteproduct_one();
        }
    }

    class Concretecreator_tow : creator
    {
        public override product Items()
        {
            return new Concreteproduct_tow();
        }
    }

}
