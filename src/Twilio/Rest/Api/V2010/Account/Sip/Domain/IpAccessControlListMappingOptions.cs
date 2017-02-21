using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain 
{

    /// <summary>
    /// FetchIpAccessControlListMappingOptions
    /// </summary>
    public class FetchIpAccessControlListMappingOptions : IOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchIpAccessControlListMappingOptions
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="sid"> The sid </param>
        public FetchIpAccessControlListMappingOptions(string domainSid, string sid)
        {
            PathDomainSid = domainSid;
            PathSid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateIpAccessControlListMappingOptions
    /// </summary>
    public class CreateIpAccessControlListMappingOptions : IOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// The ip_access_control_list_sid
        /// </summary>
        public string IpAccessControlListSid { get; }
    
        /// <summary>
        /// Construct a new CreateIpAccessControlListMappingOptions
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="ipAccessControlListSid"> The ip_access_control_list_sid </param>
        public CreateIpAccessControlListMappingOptions(string domainSid, string ipAccessControlListSid)
        {
            PathDomainSid = domainSid;
            IpAccessControlListSid = ipAccessControlListSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (IpAccessControlListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAccessControlListSid", IpAccessControlListSid.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// ReadIpAccessControlListMappingOptions
    /// </summary>
    public class ReadIpAccessControlListMappingOptions : ReadOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
    
        /// <summary>
        /// Construct a new ReadIpAccessControlListMappingOptions
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        public ReadIpAccessControlListMappingOptions(string domainSid)
        {
            PathDomainSid = domainSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// DeleteIpAccessControlListMappingOptions
    /// </summary>
    public class DeleteIpAccessControlListMappingOptions : IOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeleteIpAccessControlListMappingOptions
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="sid"> The sid </param>
        public DeleteIpAccessControlListMappingOptions(string domainSid, string sid)
        {
            PathDomainSid = domainSid;
            PathSid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}