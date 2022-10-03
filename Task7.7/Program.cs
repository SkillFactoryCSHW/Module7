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

//Order
class Order<TDelivery,TPayment> where TDelivery : Delivery where TPayment : Payment
{
    public TDelivery Delivery;

    public TPayment Payment;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    // ... Другие поля
}