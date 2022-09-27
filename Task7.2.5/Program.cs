class Program
{
    static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        obj.Display();
    }
}

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
        base.Display();
        Console.WriteLine("DerivedClass method"); 
    }
}
