using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                
                Console.Write("Собака или кошка?: ");
                string nameAnimal = Console.ReadLine().ToLower();
                Animal animal;
                
                if (nameAnimal == "собака")
                {
                    Dog dog = new Dog(nameAnimal);
                    animal = dog;
                    animal.ShowInfo();
                    
                    flag = true;
                }
                else if (nameAnimal == "кошка")
                {
                    Cat cat = new Cat(nameAnimal);
                    animal = cat;
                    animal.ShowInfo();

                    flag = true;
                }
                else
                {
                    Console.WriteLine("попробуйте еще раз");
                }
            }
            while (flag == false);
            Console.ReadKey();
        }
        
    }
}
