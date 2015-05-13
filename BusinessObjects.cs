using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tx_BO_reporting
{
    public class Product
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        private float fSalesTax = 1.07F;

        public override string ToString()
        {
            return String.Format("The price of {0} ({1}) is including sales tax {2:c}", Name, ProductCode, Price * fSalesTax);
        }
    }

    public class Report
    {
        public Product Product { get; set; }
        public string Title { get; set; }
    }


}
