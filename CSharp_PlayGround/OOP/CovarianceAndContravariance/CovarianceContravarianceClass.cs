using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp_PlayGround.OOP.CovarianceAndContravariance
{
     class Animal 
    {
        public virtual void Speak() 
        {
            Console.WriteLine("");
        }
    }
    class Dog : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("Dog say Hawhaw!");
        }
    }
    class Cat : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("Cat say MeAoooww!");
        }
    }
    internal class CovarianceContravarianceClass
    {
        public void CovarianceImplement() 
        {
            List<Dog> dogs = new List<Dog> {new Dog(),new Dog() };
            List<Animal> animals = new List<Animal>();
            animals.AddRange(dogs);
            animals.Add(new Cat());

            //OK, dogs speaks then cat speak
            foreach (var a in animals) a.Speak(); 
        }

        public void ContravarianceImplement() 
        {
          // Action is contravariant in T
          /*
          Action <in T >
          Action < Animal > animalHandler = (animal) => { ... };
          Action<Dog> dogHandler = animalHandler; // ✓ Safe - can pass Dogs to Animal handler 
          */
        }
    }

    public static class CovarianceAndContravarienceImplementation 
    {
        public static void Implement() 
        {
            CovarianceContravarianceClass covContObj = new CovarianceContravarianceClass();
            covContObj.CovarianceImplement();
        }
    }
}
