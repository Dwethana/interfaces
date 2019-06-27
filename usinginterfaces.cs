using System;

namespace diffrentClasses{
    //making interfaces
    public interface Iwalking
    {
        //in Interfaces I can't use initializations
        void walk(); //is an abstract Method
    }
    //the class dog inherits the Interface Iwalking
    public class dog : Iwalking
    {
        //The method walk gets a body
        public void walk(){
            Console.WriteLine("The dog is walking.");
        }
    }
    //the class dog inherits the Interface Iwalking
    public class cat : Iwalking
    {
        //The method walk gets a body
        public void walk(){
            Console.WriteLine("The cat is walking and is making cat noises.");
        }
    }
}