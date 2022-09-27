class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }
}

class DerivedClass: BaseClass
{
    public int num;

    public override int Counter
    {
        get
        {
            return num;
        }
        set
        {
            if(num < 0)
            {
                Console.WriteLine("Num can be more then 0 only");
            }
            else
            {
                num = value;
            }
        }
    }
}