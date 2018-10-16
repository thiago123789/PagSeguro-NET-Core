using System;
using System.Collections.Generic;
using System.Text;
using Nerdscode.PagSeguro.Service;

namespace Nerdscode.PagSeguro.Domain.Direct
{

    public class OnlineDebitCheckout : Checkout
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
        /// Bank Name
        /// </summary>
        public string BankName
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public OnlineDebitCheckout()
        {
            this.PaymentMethod = "eft";
        }
    }
}
