using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Apple : Fruit
    {
        private string country;
        private string taste;
        private string name;
        public override string Name 
        { 
            get => name; 
            set => name=value; 
        }
        public Apple(string name,string taste,string country)
            :base(name)
        {
            this.taste=taste;
            this.country=country;
        }
        public override void GetTeste()
        {
            Console.WriteLine(taste);
        }
    }
}
