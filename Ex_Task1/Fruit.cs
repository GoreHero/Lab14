using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    abstract class Fruit
    {
        public abstract string Name { get; set; }

        public Fruit(string name)
        {
            Name = name;
        }
        public abstract void GetTeste();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            GetTeste();
        }

    }
}
