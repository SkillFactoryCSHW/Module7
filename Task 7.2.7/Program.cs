class A
{
    public virtual void Display()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public new void Display()
    {
        Console.WriteLine("B");
    }
}

class C : A
{
    public override void Display()
    {
        Console.WriteLine("C");
    }
}

class D : B
{
    public void Display()
    {
        Console.WriteLine("D");
    }
}

class E : C
{
    public void Display()
    {
        Console.WriteLine("E");
    }
}