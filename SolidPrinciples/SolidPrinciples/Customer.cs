using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class Customer : ICustomer, IReadableCustomer
    {
        IErrorHandler _errorHandler;
        public Customer(IErrorHandler errorHandler)
        {
            _errorHandler = errorHandler;
        }
        public Customer()
        {
            _errorHandler = new ErrorHandler();
        }
        /*
         *OCP Violation
         */
        // CustomerType type{ get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public float Discount { get; set; }

        public virtual float CalculateDiscount()
        {
            Discount = 0;
            try
            {
                /*
                 *
                 * Incasse Switch case is used, thee main problem is , when ever a new customer is added, A new case needs to be added.
                 * Again the test cases needs to be re-written 
                 * It leads to breaking the Open Close Principle.
                 * Hence Switch case need to be replaced by Inheritance
                 * 
                 */
                //switch (type)
                //{
                //    case CustomerType.GoldCutomer:
                //        Discount = 30;
                //        break;
                //    case CustomerType.SilverCustomer:
                //        Discount = 20;
                //        break;
                //    case CustomerType.EnquiryCustomer:
                //        Discount = 5;
                //        break;
                //    default:
                //        Discount = 0;
                //        break;
                //}


            }
            catch (Exception ex)
            {
                ErrorHandler e = new ErrorHandler();
                e.HandleError(ex);
            }
            return Discount;
        }

        //It should Do Customer Validation only as per the SRP
        //Againin Catch block it should delegate the Task of Looging to File/Event Handler to Separate class
        public void Add()
        {
            try
            {
                //Add customer to DB
                Console.WriteLine("Customer added Successfully.");
            }
            catch (Exception ex)
            {
                IErrorHandler e = _errorHandler;
                e.HandleError(ex);
            }
        }

        public void read()
        {
            //Logic to Display Customer Data
            Console.WriteLine("Read customer Data");
        }
    }

    public class Prospect : IProspect
    {
        /*
         *OCP Violation
         */
        // CustomerType type{ get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public float Discount { get; set; }

        public virtual float CalculateDiscount()
        {
            Discount = 0;
            try
            {


            }
            catch (Exception ex)
            {
                ErrorHandler e = new ErrorHandler();
                e.HandleError(ex);
            }
            return Discount;
        }
        

    }


}
