using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    class Lemon:Fruit
    {
        int level;
        private string taste;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Lemon (string name, int level)
            : base(name)
        {
            this.level = level;
        }
        public override void GetTeste()
        {
            Console.WriteLine("Кислый");
        }
    }
}