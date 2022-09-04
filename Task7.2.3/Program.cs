class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass: BaseClass
{
    public override void Display()
    {
        Console.WriteLine("Метод класса DerivedClass");
    }
}
