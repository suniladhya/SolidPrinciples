namespace SolidPrinciples
{
    public interface IProspect: IPerson
    {
        float Discount { get; set; }
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
    }
}