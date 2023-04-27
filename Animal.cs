using System;

namespace VScode
    {
    abstract class Animal:IMovable
        {

            public string name{get;set;}
            public int age{get;set;}
            public string gender{get;set;}
            public double weight{get;set;}
            public string diet{get;set;}
            public string habitat{get;set;}

            public virtual void MoveForward(int distance){
                Console.WriteLine("Moving "+ distance+" units forward.");
            }
            public virtual void MoveBackward(int distance){
                Console.WriteLine("Moving "+ distance+" units backward.");
            }
            public virtual void TurnLeft(int degrees){
                Console.WriteLine("Moving "+ degrees+" degrees to the left.");
            }
            public virtual void TurnRight(int degrees){
                Console.WriteLine("Moving "+ degrees+" degrees to the right.");
            }
            public virtual void eat(string food){
                Console.WriteLine(name + " is eating "+ food);
            }
            public virtual void sleep(){
                Console.WriteLine(name + " is sleeping");
            }
            public virtual void makeSound(){
                Console.WriteLine(name +" makes a sound");
            }
    }
}
