namespace SolidPrinciples
{
    public interface IProspect: IPerson
    {
        float CalculateDiscount();
    }
    public interface ICustomer: IPerson
    {
        void Add();
    }
    public interface IPerson
    {
        int Age { get; set; }
        string CustomerName { get; set; }
        float Discount { get; set; }
    }

   //Suppose a new client comes and seeks a new functionality
   //So there is No need to disturb the 
    public interface IReadableCustomer:ICustomer
    {
        void read();
    }
}