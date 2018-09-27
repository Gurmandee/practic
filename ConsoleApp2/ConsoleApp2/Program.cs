/*
 *  Gurmandeep singh
 *  student id = 30008833
 */

using System;

namespace ConsoleApp2
{
    Dog oDog = new Dog();
    Console.WriteLine(oDog.Cry());

        Cat oCat = new Cat();
    Console.WriteLine(oCat.Cry());

        Console.ReadKey();
    }

//IAnimal.cs
interface IAnimal
{
    string Cry();
}


//Dog.cs
class Dog : IAnimal
{
    public string Cry()
    {
        return "Woof!";
    }
}
