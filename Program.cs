using System;

namespace VScode
    {
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("it is working lol");

                //Mammal :

                Mammal lion = new Mammal();
                lion.diet="red meat";
                lion.name= "Atlas";
                lion.MoveBackward(100);
                lion.TurnLeft(130);
                lion.nurse();
                lion.furColor = "Golden";
                Console.WriteLine(lion.furColor);

                //Bird :

                Bird eagle = new Bird();
                eagle.name = "Horus";
                eagle.weight = 7.25;
                eagle.age=5;
                eagle.MoveForward(1000);
                eagle.TurnRight(270);
                eagle.fly();
                eagle.canFly=true;
                Console.WriteLine(eagle.canFly);


                // Reptile :
                Reptile elegator = new Reptile();
                elegator.name = "Ozeris";
                elegator.habitat = "swamps";
                elegator.MoveForward(999);
                elegator.TurnRight(190);
                elegator.sunbathe();
                elegator.isColdBlooded=false;
                Console.WriteLine(elegator.isColdBlooded);

                
                
            }
    }
}
