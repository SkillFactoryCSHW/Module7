//Delivery
abstract class Delivery
{
    public string Address;
}

class HomeDelivery : Delivery
{
    /* ... */
}

class PickPointDelivery : Delivery
{
    /* ... */
}

class ShopDelivery : Delivery
{
    /* ... */
}

//Payment
abstract class Payment
{
    public double price;

    public Payment(double price)
    {
        this.price = price;
    }
}

class OnlinePayment : Payment
{
    private string requisites;
    private double discount;

    private OnlinePayment(double price, string requisites) : base(price)
    {
        this.requisites = requisites;
    }

    private OnlinePayment(double price, string requisites, bool promocode) : base(price)
    {
        this.requisites = requisites;
        //Discount 10%
        price *= 0.9;
    }

    public string Payment
    {
        get
        {
            return requisites;
        }
        set
        {
            if (true)
            {
                requisites = value;
            }
            else
            {
                Console.WriteLine("Need correct requisites");
            }
        }
    }
}

class CourierPayment : Payment
{
    private double deliveryCost;

    public CourierPayment(double price, double deliveryCost) : base(price)
    {
        this.deliveryCost = deliveryCost;
        this.price = deliveryCost + price;
    }
}

//FeedBack
class VideoFeedBack
{
}

class FeedBack
{
    private VideoFeedBack videoFeedBack;

    public FeedBack()
    {
        videoFeedBack = new VideoFeedBack();
    }
}

//Description
class Description
{
    public static int MaxSymbols = 1000;

    public Description(int value)
    {
        if (value < MaxSymbols)
        {
            value = MaxSymbols;
        }
        else
        {
            Console.WriteLine("Too many characters");
        }
    }
}

//Number
class Number
{
    public void Display<TNumber>(TNumber id)
    {
        Console.WriteLine(id.ToString());
    }
}

//Order
class Order<TDelivery,TPayment, TDescription, TNumber> where TDelivery : Delivery where TPayment : Payment where TDescription : Description where TNumber : Number
{
    public TDelivery Delivery;

    public TPayment Payment;

    public TNumber Number;

    public TDescription Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}