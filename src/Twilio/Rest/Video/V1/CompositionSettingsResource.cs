/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// CompositionSettingsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Video.V1 
{

    public class CompositionSettingsResource : Resource 
    {
        private static Request BuildFetchRequest(FetchCompositionSettingsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/CompositionSettings/Default",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch CompositionSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CompositionSettings </returns> 
        public static CompositionSettingsResource Fetch(FetchCompositionSettingsOptions options, 
                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch CompositionSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CompositionSettings </returns> 
        public static async System.Threading.Tasks.Task<CompositionSettingsResource> FetchAsync(FetchCompositionSettingsOptions options, 
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
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CompositionSettings </returns> 
        public static CompositionSettingsResource Fetch(ITwilioRestClient client = null)
        {
            var options = new FetchCompositionSettingsOptions();
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CompositionSettings </returns> 
        public static async System.Threading.Tasks.Task<CompositionSettingsResource> FetchAsync(ITwilioRestClient client = null)
        {
            var options = new FetchCompositionSettingsOptions();
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateCompositionSettingsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                "/v1/CompositionSettings/Default",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create CompositionSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CompositionSettings </returns> 
        public static CompositionSettingsResource Create(CreateCompositionSettingsOptions options, 
                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create CompositionSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CompositionSettings </returns> 
        public static async System.Threading.Tasks.Task<CompositionSettingsResource> CreateAsync(CreateCompositionSettingsOptions options, 
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> Friendly name of the configuration to be shown in the console </param>
        /// <param name="awsCredentialsSid"> SID of the Stored Credential resource CRxx </param>
        /// <param name="encryptionKeySid"> SID of the Public Key resource CRxx </param>
        /// <param name="awsS3Url"> Identity of the external location where the compositions should be stored. We only support
        ///                DNS-compliant URLs like http://<my-bucket>.s3-<aws-region>.amazonaws.com/compositions, where
        ///                compositions is the path where you want compositions to be stored. </param>
        /// <param name="awsStorageEnabled"> true|false When set to true, all Compositions will be written to the AwsS3Url
        ///                         specified above. When set to false, all Compositions will be stored in Twilio's cloud.
        ///                         </param>
        /// <param name="encryptionEnabled"> true|false When set to true, all Compositions will be stored encrypted. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CompositionSettings </returns> 
        public static CompositionSettingsResource Create(string friendlyName, 
                                                         string awsCredentialsSid = null, 
                                                         string encryptionKeySid = null, 
                                                         Uri awsS3Url = null, 
                                                         bool? awsStorageEnabled = null, 
                                                         bool? encryptionEnabled = null, 
                                                         ITwilioRestClient client = null)
        {
            var options = new CreateCompositionSettingsOptions(friendlyName){AwsCredentialsSid = awsCredentialsSid, EncryptionKeySid = encryptionKeySid, AwsS3Url = awsS3Url, AwsStorageEnabled = awsStorageEnabled, EncryptionEnabled = encryptionEnabled};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> Friendly name of the configuration to be shown in the console </param>
        /// <param name="awsCredentialsSid"> SID of the Stored Credential resource CRxx </param>
        /// <param name="encryptionKeySid"> SID of the Public Key resource CRxx </param>
        /// <param name="awsS3Url"> Identity of the external location where the compositions should be stored. We only support
        ///                DNS-compliant URLs like http://<my-bucket>.s3-<aws-region>.amazonaws.com/compositions, where
        ///                compositions is the path where you want compositions to be stored. </param>
        /// <param name="awsStorageEnabled"> true|false When set to true, all Compositions will be written to the AwsS3Url
        ///                         specified above. When set to false, all Compositions will be stored in Twilio's cloud.
        ///                         </param>
        /// <param name="encryptionEnabled"> true|false When set to true, all Compositions will be stored encrypted. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CompositionSettings </returns> 
        public static async System.Threading.Tasks.Task<CompositionSettingsResource> CreateAsync(string friendlyName, 
                                                                                                 string awsCredentialsSid = null, 
                                                                                                 string encryptionKeySid = null, 
                                                                                                 Uri awsS3Url = null, 
                                                                                                 bool? awsStorageEnabled = null, 
                                                                                                 bool? encryptionEnabled = null, 
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new CreateCompositionSettingsOptions(friendlyName){AwsCredentialsSid = awsCredentialsSid, EncryptionKeySid = encryptionKeySid, AwsS3Url = awsS3Url, AwsStorageEnabled = awsStorageEnabled, EncryptionEnabled = encryptionEnabled};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a CompositionSettingsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CompositionSettingsResource object represented by the provided JSON </returns> 
        public static CompositionSettingsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CompositionSettingsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The Twilio Account SID associated with this item
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Friendly name of the configuration to be shown in the console
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// SID of the Stored Credential resource CRxx
        /// </summary>
        [JsonProperty("aws_credentials_sid")]
        public string AwsCredentialsSid { get; private set; }
        /// <summary>
        /// URL of the S3 bucket where the compositions should be stored. We only support DNS-compliant URLs like http://<my-bucket>.s3-<aws-region>.amazonaws.com/compositions, where compositions is the path where you want compositions to be stored.
        /// </summary>
        [JsonProperty("aws_s3_url")]
        public Uri AwsS3Url { get; private set; }
        /// <summary>
        /// true|false When set to true, all Compositions will be written to the AwsS3Url specified above. When set to false, all Compositions will be stored in Twilio's cloud.
        /// </summary>
        [JsonProperty("aws_storage_enabled")]
        public bool? AwsStorageEnabled { get; private set; }
        /// <summary>
        /// SID of the Public Key resource CRxx
        /// </summary>
        [JsonProperty("encryption_key_sid")]
        public string EncryptionKeySid { get; private set; }
        /// <summary>
        /// true|false When set to true, all Compositions will be stored encrypted.
        /// </summary>
        [JsonProperty("encryption_enabled")]
        public bool? EncryptionEnabled { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private CompositionSettingsResource()
        {

        }
    }

}