class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("BaseClass method");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("DerivedClass method");
    }
}