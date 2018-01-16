using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    //if no access- implicitly public 
    //POCO- plain old c# object--if there are no methods (behavior)
    class Child 
    {
        public string Name { get; set; } //can access in Program bc it is public
        public bool Sick { get; set; }

        public string ForgeASickNote()
        {
            return Sick 
                ? $"Please excuse {Name} from class today because he/she is very sick." //if sick
                : $"{Name}, you ain't sick, bruh!"; 
        }
    }
}
