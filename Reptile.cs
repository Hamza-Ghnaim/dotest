using System;

namespace VScode
    {
        class Reptile:Animal
        {
            public bool isColdBlooded{set;get;}
            public string habitatType{set;get;}
            public void sunbathe(){
                Console.WriteLine(name+ " is sunbathing.");
                }
            public override void MoveForward(int distance){
                Console.WriteLine(name + " is Moving "+ distance+" units forward.");
            }
            public override void MoveBackward(int distance){
                Console.WriteLine(name + " is Moving "+ distance+" units backward.");
            }
            public override void TurnLeft(int degrees){
                Console.WriteLine(name + " is Moving "+ degrees+" degrees to the left.");
            }
            public override void TurnRight(int degrees){
                Console.WriteLine(name + " is Moving "+ degrees+" degrees to the right.");
            }
            public override void eat(string food){
                Console.WriteLine(name + " is eating "+ food);
            }
            public override void sleep(){
                Console.WriteLine(name + " is sleeping");
            }
            public override void makeSound(){
                Console.WriteLine(name +" makes a sound");
            }
        }
    }