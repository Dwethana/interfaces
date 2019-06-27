using System;
using diffrentClasses;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Iwalking []animal = new Iwalking[3];
            animal[0]=new dog();
            animal[1]= new dog();
            animal[2]= new cat();

            foreach(Iwalking t in animal)
            {
                t.walk();
            }
        }
    }
}
