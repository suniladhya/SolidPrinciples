using SolidPrinciples;
using SolidPrinciples.CutomerType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer c = new GoldCustomer();
            IReadableCustomer rc = new GoldCustomer();

            //Interface Seggregation
            /* *
             * ICustomer, IReadableCustomer are different and they are used as and when Required
             * when new demand is there, without modifying instance "c", we can create new instance of "IReadableCustomer" and use it
             * */
            c.Add();

            rc.Add();
            rc.read();


            //DIP
            ICustomer silverCutomer = new SilverCustomer(new ErrorHandler());
        }
    }
}
