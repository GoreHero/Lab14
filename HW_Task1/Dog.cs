using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Dog : Animal
    {
        private string name;
        //private string language = "ГАВ-ГАВ";
        public override string Name 
        { 
            get => name; 
            set => name= value; 
        }
        public Dog(string name)
            : base(name)
        {
            //this.language = language;  
        }

        public override void Say()
        {
            Console.WriteLine("ГАВ-ГАВ");
        }
    }
}
