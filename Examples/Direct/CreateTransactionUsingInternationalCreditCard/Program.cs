﻿// Copyright [2011] [PagSeguro Internet Ltda.]
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using System.Net;
using Nerdscode.PagSeguro.Constants;
using Nerdscode.PagSeguro.Domain;
using Nerdscode.PagSeguro.Domain.Direct;
using Nerdscode.PagSeguro.Exception;
using Nerdscode.PagSeguro.Resources;
using Nerdscode.PagSeguro.Service;

namespace CreateTransactionUsingCreditCard
{
    class Program
    {
        static void Main(string[] args)
        {

            PagSeguroConfiguration.UrlXmlConfiguration = ".../.../.../.../.../Configuration/PagSeguroConfig.xml";

            bool isSandbox = false;
            EnvironmentConfiguration.ChangeEnvironment(isSandbox);

            // Instantiate a new checkout
            CreditCardCheckout checkout = new CreditCardCheckout();

            // Sets the payment mode
            checkout.PaymentMode = PaymentMode.DEFAULT;

            // Sets the receiver e-mail should will get paid
            checkout.ReceiverEmail = "backoffice@lojamodelo.com.br";

            // Sets the currency
            checkout.Currency = Currency.Brl;

            // Add items
            checkout.Items.Add(new Item("0001", "Notebook Prata", 2, 2000.00m));
            checkout.Items.Add(new Item("0002", "Notebook Rosa", 2, 150.99m));

            // Sets a reference code for this checkout, it is useful to identify this payment in future notifications.
            checkout.Reference = "REF1234";

            // Sets shipping information for this payment request
            checkout.Shipping = new Shipping();
            checkout.Shipping.ShippingType = ShippingType.Sedex;
            checkout.Shipping.Cost = 0.00m;
            checkout.Shipping.Address = new Address(
                "BRA",
                "SP",
                "Sao Paulo",
                "Jardim Paulistano",
                "01452002",
                "Av. Brig. Faria Lima",
                "1384",
                "5o andar"
            );

            // Sets your customer information.
            // If you using SANDBOX you must use an email @sandbox.pagseguro.com.br
            checkout.Sender = new Sender(
                "Joao Comprador",
                "comprador@uol.com.br",
                new Phone("11", "56273440")
            );

            SenderDocument senderCPF = new SenderDocument(Documents.GetDocumentByType("CPF"), "12345678909");
            checkout.Sender.Documents.Add(senderCPF);

            // Sets credit card token.
            checkout.Token = "1f31f3de024e4e5f8539d84cbc8b2a49";

            //Sets installments information
            checkout.Installment = new Installment(1, 50.00m);

            // Sets the url used by PagSeguro for redirect user after ends checkout process
            checkout.NotificationURL = "http://www.lojamodelo.com.br";

            try
            {
                AccountCredentials credentials = new AccountCredentials("", "");
                Transaction result = TransactionService.CreateCheckout(credentials, checkout);
                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (PagSeguroServiceException exception)
            {
                Console.WriteLine(exception.Message + "\n");
                foreach (ServiceError element in exception.Errors)
                {
                    Console.WriteLine(element + "\n");
                }
                Console.ReadKey();
            }
        }
    }
}
