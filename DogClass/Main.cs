using System;

namespace DogClass
{
    public enum Gender 
    {
        Male,
        Female
    }

    class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;
        

        public void Bark(int num)
        {
            while(num > 0)
            {
                Console.WriteLine("Woof!");
                num--;
            }
        }

        public Dog (string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void GetTag()
        {
            if (gender == Gender.Male && age == 1)
            {
                Console.WriteLine("If lost, call " + owner + ". His name is " + name + " and he is " + age + " year old.");
            }
            else if (gender == Gender.Female && age == 1)
            {
               Console.WriteLine("If lost, call " + owner + ". Her name is " + name + " and she is " + age + " year old."); 
            }
            else if (gender == Gender.Male && age > 1)
            {
               Console.WriteLine("If lost, call " + owner + ". His name is " + name + " and he is " + age + " years old."); 
            }
            else if (gender == Gender.Female && age > 1)
            {
                Console.WriteLine("If lost, call " + owner + ". Her name is " + name + " and she is " + age + " years old.");
            }              
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            puppy.GetTag();

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            myDog.GetTag();
        }
    }
}
