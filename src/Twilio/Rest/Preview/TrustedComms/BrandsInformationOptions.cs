/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.TrustedComms
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve the newest available BrandInformation
    /// </summary>
    public class FetchBrandsInformationOptions : IOptions<BrandsInformationResource>
    {
        /// <summary>
        /// Standard `If-None-Match` HTTP header
        /// </summary>
        public string IfNoneMatch { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (IfNoneMatch != null)
            {
                p.Add(new KeyValuePair<string, string>("If-None-Match", IfNoneMatch));
            }

            return p;
        }
    }

}