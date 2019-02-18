using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class SilverCustomer : Customer
    {
        public override float CalculateDiscount()
        {
            this.Discount = 20;

            return Discount;
        }

    }
    class GoldCustomer : Customer
    {
        public override float CalculateDiscount()
        {
            this.Discount = 30;

            return Discount;
        }

    }
    class EnquiryCustomer : Prospect
    {
        public override float CalculateDiscount()
        {
            this.Discount = 5;

            return Discount;
        }

    }

    public class Prospect : IProspect, IPerson
    {
        public int Age
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string CustomerName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float Discount
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
