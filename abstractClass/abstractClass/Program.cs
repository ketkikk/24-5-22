using System;

namespace abstractClass
{
    class Program
    {
        public abstract class Animal
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }

            public abstract void Eat();
        }
        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Dog is Eating");
            }
            static void Main(string[] args)
            {
                Dog dog = new Dog();
                dog.SetName(Console.ReadLine());
                Console.WriteLine(dog.GetName());
                dog.Eat();
            }
        }
    }
}
