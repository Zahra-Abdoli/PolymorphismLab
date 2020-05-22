using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
   public class Cat :Animal
    {
        public Cat(string name,string favoritFood):base (name,favoritFood)
        {

        }
        public override string Explainself() =>  base.Explainself()  + Environment.NewLine + "MEEOW";
        
         
        }
        
} 


