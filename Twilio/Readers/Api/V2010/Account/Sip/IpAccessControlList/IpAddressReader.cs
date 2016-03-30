using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Readers;
using Twilio.Resources;
using Twilio.Resources.Api.V2010.Account.Sip.IpAccessControlList;

namespace Twilio.Readers.Api.V2010.Account.Sip.IpAccessControlList {

    public class IpAddressReader : Reader<IpAddressResource> {
        private string accountSid;
        private string ipAccessControlListSid;
    
        /**
         * Construct a new IpAddressReader
         * 
         * @param accountSid The account_sid
         * @param ipAccessControlListSid The ip_access_control_list_sid
         */
        public IpAddressReader(string accountSid, string ipAccessControlListSid) {
            this.accountSid = accountSid;
            this.ipAccessControlListSid = ipAccessControlListSid;
        }
    
        /**
         * Make the request to the Twilio API to perform the read
         * 
         * @param client TwilioRestClient with which to make the request
         * @return IpAddressResource ResourceSet
         */
        public override async Task<ResourceSet<IpAddressResource>> ExecuteAsync(TwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                TwilioRestClient.Domains.API,
                "/2010-04-01/Accounts/" + this.accountSid + "/SIP/IpAccessControlLists/" + this.ipAccessControlListSid + "/IpAddresses.json"
            );
            
            AddQueryParams(request);
            
            Page<IpAddressResource> page = await PageForRequest(client, request);
            
            return new ResourceSet<IpAddressResource>(this, client, page);
        }
    
        /**
         * Retrieve the next page from the Twilio API
         * 
         * @param nextPageUri URI from which to retrieve the next page
         * @param client TwilioRestClient with which to make the request
         * @return Next Page
         */
        public override Page<IpAddressResource> NextPage(string nextPageUri, TwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                nextPageUri
            );
            
            var task = PageForRequest(client, request);
            task.Wait();
            
            return task.Result;
        }
    
        /**
         * Generate a Page of IpAddressResource Resources for a given request
         * 
         * @param client TwilioRestClient with which to make the request
         * @param request Request to generate a page for
         * @return Page for the Request
         */
        protected async Task<Page<IpAddressResource>> PageForRequest(TwilioRestClient client, Request request) {
            Response response = await client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("IpAddressResource read failed: Unable to connect to server");
            } else if (response.GetStatusCode() != TwilioRestClient.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            Page<IpAddressResource> result = new Page<IpAddressResource>();
            result.deserialize("ip_addresses", response.GetContent());
            
            return result;
        }
    
        /**
         * Add the requested query string arguments to the Request
         * 
         * @param request Request to add query string arguments to
         */
        private void AddQueryParams(Request request) {
            request.AddQueryParam("PageSize", GetPageSize().ToString());
        }
    }
}