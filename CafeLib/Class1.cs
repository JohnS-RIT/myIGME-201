using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    //Class: HotDrink (Abstract)
    //Purpose: Creates fields and methods for a hot drink
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public HotDrink()
        {

        }

        public HotDrink(string brand)
        {
            
        }

        public virtual void AddSugar(byte amount)
        {

        }

        public abstract void Steam();
    }

    //Class: Customer
    //Purpose: fields, properties, and methods of Customer
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get
            {
                return IMood.Mood;
            }
        }
    }

    //Class: Waiter
    //Purpose: fields, properties, and methods of Waiter
    public class Waiter : IMood
    {
        public string name;

        public string Mood
        {
            get
            {
                return Mood;
            }
        }

        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    //Interface: IMood
    //Purpose: Read only for Mood
    public interface IMood
    {
        public string Mood
        {
            get
            {
                return Mood;
            }
        }
    }

    //Class: CupOfCoffee
    //Purpose: Fields, properties, and methods for HotDrink --> CupOfCoffee
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public CupOfCoffee(string brand) :
            base(brand)
        {

        }

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }
    }

    //Class: CupOfTea
    //Purpose: Fields, properties, and methods for HotDrink --> CupOfTea
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public CupOfTea(bool customerIsWealthy)
        {

        }

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }
    }

    //Class: CupOfCocoa
    //Purpose: Fields, properties, and methods for HotDrink --> CupOfCocoa
    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public int NumCups
        {
            set
            {
                int numCups = value;
            }
        }

        public bool marshmallows;
        private string source;

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        public CupOfCocoa(bool marshmallows) :
            base("Expensive Organic Brand")
        {

        }

        public CupOfCocoa()
        {

        }

        public override void Steam()
        {

        }

        public override void AddSugar(byte amount)
        {
            base.AddSugar(amount);
        }

        public void TakeOrder()
        {

        }
    }

    //Interface: ITakeOrder
    //Purpose: TakeOrder method
    public interface ITakeOrder
    {
        public void TakeOrder();
    }
}
