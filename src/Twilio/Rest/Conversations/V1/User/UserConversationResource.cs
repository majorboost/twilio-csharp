/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// UserConversationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Conversations.V1.User
{

    public class UserConversationResource : Resource
    {
        public sealed class NotificationLevelEnum : StringEnum
        {
            private NotificationLevelEnum(string value) : base(value) {}
            public NotificationLevelEnum() {}
            public static implicit operator NotificationLevelEnum(string value)
            {
                return new NotificationLevelEnum(value);
            }

            public static readonly NotificationLevelEnum Default = new NotificationLevelEnum("default");
            public static readonly NotificationLevelEnum Muted = new NotificationLevelEnum("muted");
        }

        public sealed class StateEnum : StringEnum
        {
            private StateEnum(string value) : base(value) {}
            public StateEnum() {}
            public static implicit operator StateEnum(string value)
            {
                return new StateEnum(value);
            }

            public static readonly StateEnum Inactive = new StateEnum("inactive");
            public static readonly StateEnum Active = new StateEnum("active");
            public static readonly StateEnum Closed = new StateEnum("closed");
        }

        private static Request BuildUpdateRequest(UpdateUserConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                "/v1/Users/" + options.PathUserSid + "/Conversations/" + options.PathConversationSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Update a specific User Conversation.
        /// </summary>
        /// <param name="options"> Update UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static UserConversationResource Update(UpdateUserConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific User Conversation.
        /// </summary>
        /// <param name="options"> Update UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<UserConversationResource> UpdateAsync(UpdateUserConversationOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific User Conversation.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. </param>
        /// <param name="notificationLevel"> The Notification Level of this User Conversation. </param>
        /// <param name="lastReadTimestamp"> The date of the last message read in conversation by the user. </param>
        /// <param name="lastReadMessageIndex"> The index of the last read Message. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static UserConversationResource Update(string pathUserSid,
                                                      string pathConversationSid,
                                                      UserConversationResource.NotificationLevelEnum notificationLevel = null,
                                                      DateTime? lastReadTimestamp = null,
                                                      int? lastReadMessageIndex = null,
                                                      ITwilioRestClient client = null)
        {
            var options = new UpdateUserConversationOptions(pathUserSid, pathConversationSid){NotificationLevel = notificationLevel, LastReadTimestamp = lastReadTimestamp, LastReadMessageIndex = lastReadMessageIndex};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific User Conversation.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. </param>
        /// <param name="notificationLevel"> The Notification Level of this User Conversation. </param>
        /// <param name="lastReadTimestamp"> The date of the last message read in conversation by the user. </param>
        /// <param name="lastReadMessageIndex"> The index of the last read Message. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<UserConversationResource> UpdateAsync(string pathUserSid,
                                                                                              string pathConversationSid,
                                                                                              UserConversationResource.NotificationLevelEnum notificationLevel = null,
                                                                                              DateTime? lastReadTimestamp = null,
                                                                                              int? lastReadMessageIndex = null,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateUserConversationOptions(pathUserSid, pathConversationSid){NotificationLevel = notificationLevel, LastReadTimestamp = lastReadTimestamp, LastReadMessageIndex = lastReadMessageIndex};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteUserConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Conversations,
                "/v1/Users/" + options.PathUserSid + "/Conversations/" + options.PathConversationSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Delete a specific User Conversation.
        /// </summary>
        /// <param name="options"> Delete UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static bool Delete(DeleteUserConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific User Conversation.
        /// </summary>
        /// <param name="options"> Delete UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteUserConversationOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific User Conversation.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static bool Delete(string pathUserSid, string pathConversationSid, ITwilioRestClient client = null)
        {
            var options = new DeleteUserConversationOptions(pathUserSid, pathConversationSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific User Conversation.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathUserSid,
                                                                          string pathConversationSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteUserConversationOptions(pathUserSid, pathConversationSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchUserConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                "/v1/Users/" + options.PathUserSid + "/Conversations/" + options.PathConversationSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific User Conversation.
        /// </summary>
        /// <param name="options"> Fetch UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static UserConversationResource Fetch(FetchUserConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific User Conversation.
        /// </summary>
        /// <param name="options"> Fetch UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<UserConversationResource> FetchAsync(FetchUserConversationOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific User Conversation.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static UserConversationResource Fetch(string pathUserSid,
                                                     string pathConversationSid,
                                                     ITwilioRestClient client = null)
        {
            var options = new FetchUserConversationOptions(pathUserSid, pathConversationSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific User Conversation.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<UserConversationResource> FetchAsync(string pathUserSid,
                                                                                             string pathConversationSid,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new FetchUserConversationOptions(pathUserSid, pathConversationSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadUserConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                "/v1/Users/" + options.PathUserSid + "/Conversations",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieve a list of all User Conversations for the User.
        /// </summary>
        /// <param name="options"> Read UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static ResourceSet<UserConversationResource> Read(ReadUserConversationOptions options,
                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<UserConversationResource>.FromJson("conversations", response.Content);
            return new ResourceSet<UserConversationResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all User Conversations for the User.
        /// </summary>
        /// <param name="options"> Read UserConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UserConversationResource>> ReadAsync(ReadUserConversationOptions options,
                                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UserConversationResource>.FromJson("conversations", response.Content);
            return new ResourceSet<UserConversationResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all User Conversations for the User.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserConversation </returns>
        public static ResourceSet<UserConversationResource> Read(string pathUserSid,
                                                                 int? pageSize = null,
                                                                 long? limit = null,
                                                                 ITwilioRestClient client = null)
        {
            var options = new ReadUserConversationOptions(pathUserSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all User Conversations for the User.
        /// </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the User. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserConversation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UserConversationResource>> ReadAsync(string pathUserSid,
                                                                                                         int? pageSize = null,
                                                                                                         long? limit = null,
                                                                                                         ITwilioRestClient client = null)
        {
            var options = new ReadUserConversationOptions(pathUserSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<UserConversationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UserConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<UserConversationResource> NextPage(Page<UserConversationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Conversations)
            );

            var response = client.Request(request);
            return Page<UserConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<UserConversationResource> PreviousPage(Page<UserConversationResource> page,
                                                                  ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Conversations)
            );

            var response = client.Request(request);
            return Page<UserConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a UserConversationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserConversationResource object represented by the provided JSON </returns>
        public static UserConversationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<UserConversationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique ID of the Account responsible for this conversation.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique ID of the Conversation Service this conversation belongs to.
        /// </summary>
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }
        /// <summary>
        /// The unique ID of the Conversation for this message.
        /// </summary>
        [JsonProperty("conversation_sid")]
        public string ConversationSid { get; private set; }
        /// <summary>
        /// The number of unread Messages in the Conversation.
        /// </summary>
        [JsonProperty("unread_messages_count")]
        public int? UnreadMessagesCount { get; private set; }
        /// <summary>
        /// The index of the last read Message .
        /// </summary>
        [JsonProperty("last_read_message_index")]
        public int? LastReadMessageIndex { get; private set; }
        /// <summary>
        /// Participant Sid.
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// The unique ID for the User.
        /// </summary>
        [JsonProperty("user_sid")]
        public string UserSid { get; private set; }
        /// <summary>
        /// The human-readable name of this conversation.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The current state of this User Conversation
        /// </summary>
        [JsonProperty("conversation_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserConversationResource.StateEnum ConversationState { get; private set; }
        /// <summary>
        /// Timer date values for this conversation.
        /// </summary>
        [JsonProperty("timers")]
        public object Timers { get; private set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }
        /// <summary>
        /// The date that this conversation was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this conversation was last updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Creator of this conversation.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }
        /// <summary>
        /// The Notification Level of this User Conversation.
        /// </summary>
        [JsonProperty("notification_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserConversationResource.NotificationLevelEnum NotificationLevel { get; private set; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Absolute URLs to access the participant and conversation of this user conversation.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private UserConversationResource()
        {

        }
    }

}