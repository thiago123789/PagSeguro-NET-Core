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
//   limitation

using System;
using System.Xml;
using Nerdscode.PagSeguro.Domain;

namespace Nerdscode.PagSeguro.XmlParse
{
    /// <summary>
    /// 
    /// </summary>
    internal static class CreditorFeesSerializer
    {
        internal const string CreditorFees = "creditorFees";

        private const string IntermediationRateAmount = "intermediationRateAmount";
        private const string IntermediationFeeAmount = "intermediationFeeAmount";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="item"></param>
        internal static void Read(XmlReader reader, CreditorFees creditorFees)
        {

            if (reader.IsEmptyElement)
            {
                XMLParserUtils.SkipNode(reader);
                return;
            }

            reader.ReadStartElement(CreditorFeesSerializer.CreditorFees);
            reader.MoveToContent();

            while (!reader.EOF)
            {
                if (XMLParserUtils.IsEndElement(reader, CreditorFeesSerializer.CreditorFees))
                {
                    XMLParserUtils.SkipNode(reader);
                    break;
                }

                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case CreditorFeesSerializer.IntermediationRateAmount:
                            creditorFees.intermediationRateAmount = reader.ReadElementContentAsDecimal();
                            break;
                        case CreditorFeesSerializer.IntermediationFeeAmount:
                            creditorFees.intermediationFeeAmount = reader.ReadElementContentAsDecimal();
                            break;
                        default:
                            XMLParserUtils.SkipElement(reader);
                            break;
                    }
                }
                else
                {
                    XMLParserUtils.SkipNode(reader);
                }
            }
        }
    }
}
