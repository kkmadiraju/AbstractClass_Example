// This animal is too important to be created directly.
// It only gives orders.
public abstract class Animal
{
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("Zzz... (abstract animals also need rest)");
    }
}

// A Dog that actually follows the rules
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

// A Cat that ignores your rules (as usual)
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow... or maybe not. Depends on my mood.");
    }
}
