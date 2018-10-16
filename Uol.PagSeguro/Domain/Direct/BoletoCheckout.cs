using System;
using System.Collections.Generic;
using System.Text;
using Nerdscode.PagSeguro.Service;

namespace Nerdscode.PagSeguro.Domain.Direct
{
    public class BoletoCheckout : Checkout
    {
        /// <summary>
        /// Payment Method
        /// </summary>
        public string PaymentMethod
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public BoletoCheckout()
        {
            this.PaymentMethod = "Boleto";
        }
    }
}
