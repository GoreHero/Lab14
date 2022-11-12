using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Cat : Animal
    {
        private string name;

        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat(string name)
            : base(name)
        {
            //this.language = language;  
        }

        public override void Say()
        {
            Console.WriteLine("Мурр-Мяу!");
        }
    }
}