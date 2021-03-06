/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// DefaultsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Autopilot.V1.Assistant 
{

    public class DefaultsResource : Resource 
    {
        private static Request BuildFetchRequest(FetchDefaultsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Defaults",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns> 
        public static DefaultsResource Fetch(FetchDefaultsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns> 
        public static async System.Threading.Tasks.Task<DefaultsResource> FetchAsync(FetchDefaultsOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns> 
        public static DefaultsResource Fetch(string pathAssistantSid, ITwilioRestClient client = null)
        {
            var options = new FetchDefaultsOptions(pathAssistantSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns> 
        public static async System.Threading.Tasks.Task<DefaultsResource> FetchAsync(string pathAssistantSid, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new FetchDefaultsOptions(pathAssistantSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateDefaultsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Defaults",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns> 
        public static DefaultsResource Update(UpdateDefaultsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns> 
        public static async System.Threading.Tasks.Task<DefaultsResource> UpdateAsync(UpdateDefaultsOptions options, 
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="defaults"> The defaults </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns> 
        public static DefaultsResource Update(string pathAssistantSid, 
                                              object defaults = null, 
                                              ITwilioRestClient client = null)
        {
            var options = new UpdateDefaultsOptions(pathAssistantSid){Defaults = defaults};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="defaults"> The defaults </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns> 
        public static async System.Threading.Tasks.Task<DefaultsResource> UpdateAsync(string pathAssistantSid, 
                                                                                      object defaults = null, 
                                                                                      ITwilioRestClient client = null)
        {
            var options = new UpdateDefaultsOptions(pathAssistantSid){Defaults = defaults};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a DefaultsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DefaultsResource object represented by the provided JSON </returns> 
        public static DefaultsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DefaultsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The assistant_sid
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The data
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }

        private DefaultsResource()
        {

        }
    }

}