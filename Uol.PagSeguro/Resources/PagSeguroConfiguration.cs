// Copyright [2011] [PagSeguro Internet Ltda.]
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
using System.Xml;
using Nerdscode.PagSeguro.Domain;
using Nerdscode.PagSeguro.XmlParse;
using System.Reflection;
using System.Diagnostics;
using System.Web;

namespace Nerdscode.PagSeguro.Resources
{
    /// <summary>
    /// 
    /// </summary>
    public static class PagSeguroConfiguration
    {
        //PagSeguro .NET Library Tests
        private static string urlXmlConfiguration = ".../PagSeguroUrls.resx";

        //Website
        //private static string urlXmlConfiguration = HttpRuntime.AppDomainAppPath + "PagSeguroConfig.xml";

        private static string _moduleVersion;
        private static string _cmsVersion;
        
        /// <summary>
        /// 
        /// </summary>
        public static string UrlXmlConfiguration
        {
            get
            {
                return urlXmlConfiguration;
            }
            set
            {
                urlXmlConfiguration = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string ModuleVersion
        {
            get
            {
                return _moduleVersion;
            }

            set
            {
                _moduleVersion = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string CmsVersion
        {
            get
            {
                return _cmsVersion;
            }

            set
            {
                _cmsVersion = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string LanguageEngineDescription => Environment.Version.ToString();

        /// <summary>
        /// 
        /// </summary>
        public static Uri NotificationUri => new Uri(PagSeguroUrls.Notification);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PaymentUri => new Uri(PagSeguroUrls.Payment);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PaymentRedirectUri => new Uri(PagSeguroUrls.PaymentRedirect);

        /// <summary>
        /// 
        /// </summary>
        public static Uri SearchUri => new Uri(PagSeguroUrls.Search);

        /// <summary>
        /// 
        /// </summary>
        public static Uri SearchAbandonedUri => new Uri(PagSeguroUrls.SearchAbandoned);

        /// <summary>
        /// 
        /// </summary>
        public static Uri CancelUri => new Uri(PagSeguroUrls.Cancel);

        /// <summary>
        /// 
        /// </summary>
        public static Uri RefundUri => new Uri(PagSeguroUrls.Refund);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalUri => new Uri(PagSeguroUrls.PreApproval);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalRedirectUri => new Uri(PagSeguroUrls.PreApprovalRedirect);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalNotificationUri => new Uri(PagSeguroUrls.PreApprovalNotification);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalSearchUri => new Uri(PagSeguroUrls.PreApprovalSearch);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalCancelUri => new Uri(PagSeguroUrls.PreApprovalCancel);

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalPaymentUri => new Uri(PagSeguroUrls.PreApprovalPayment);

        /// <summary>
        /// 
        /// </summary>
        public static Uri SessionUri => new Uri(PagSeguroUrls.DirectPaymentSession);

        /// <summary>
        /// 
        /// </summary>
        public static Uri TransactionsUri => new Uri(PagSeguroUrls.DirectPaymentTransactions);

        /// <summary>
        /// 
        /// </summary>
        public static Uri InstallmentUri => new Uri(PagSeguroUrls.DirectPaymentInstallment);

        /// <summary>
        /// 
        /// </summary>
        public static Uri AuthorizarionRequestUri => new Uri(PagSeguroUrls.AuthorizationRequest);

        /// <summary>
        /// 
        /// </summary>
        public static Uri AuthorizarionUri => new Uri(PagSeguroUrls.AuthorizationURL);

        /// <summary>
        /// 
        /// </summary>
        public static Uri AuthorizarionSearchUri => new Uri(PagSeguroUrls.AuthorizationSearch);

        /// <summary>
        /// 
        /// </summary>
        public static Uri AuthorizationNotificationUri => new Uri(PagSeguroUrls.AuthorizationNotification);

        /// <summary>
        /// 
        /// </summary>
        public static int RequestTimeout => Convert.ToInt32(PagSeguroUrls.RequestTimeout);

        /// <summary>
        /// 
        /// </summary>
        public static string FormUrlEncoded => PagSeguroUrls.FormUrlEncoded;

        /// <summary>
        /// 
        /// </summary>
        public static string Encoding => PagSeguroUrls.Encoding;

        /// <summary>
        /// 
        /// </summary>
        public static string LibVersion => PagSeguroUrls.LibVersion;

    }
}
