using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.CutomerType
{
    public class SilverCustomer : Customer
    {
        public SilverCustomer()
        {

        }
        public SilverCustomer(IErrorHandler errorHandler) : base(errorHandler)
        {

        }

        public override float CalculateDiscount()
        {
            this.Discount = 20;

            return Discount;
        }

    }
    public class GoldCustomer : Customer
    {
        public GoldCustomer()
        {

        }
        public GoldCustomer(IErrorHandler errorHandler) : base(errorHandler)
        {

        }
        public override float CalculateDiscount()
        {
            this.Discount = 30;

            return Discount;
        }

    }
    public class EnquiryCustomer : Prospect
    {
        public override float CalculateDiscount()
        {
            this.Discount = 5;

            return Discount;
        }

    }
    
}
