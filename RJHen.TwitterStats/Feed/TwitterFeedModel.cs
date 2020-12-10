using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

//========================================================================
// Strongly typed object to transform JSON payload. Used QuickType.IO 
// website to help create this typesafe object in C#
//========================================================================
namespace RJHen.TwitterStats.Feed.Model
{

    public partial class Tweet
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("includes")]
        public Includes Includes { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("possibly_sensitive")]
        public bool PossiblySensitive { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("entities")]
        public Entities Entities { get; set; }

        [JsonProperty("attachments")]
        public Attachments Attachments { get; set; }

        [JsonProperty("reply_settings")]
        public string ReplySettings { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("referenced_tweets")]
        public ReferencedTweet[] ReferencedTweets { get; set; }

        [JsonProperty("public_metrics")]
        public PublicMetrics PublicMetrics { get; set; }
    }

    public partial class Attachments
    {
        [JsonProperty("media_keys")]
        public string[] MediaKeys { get; set; }
    }

    public partial class Entities
    {
        [JsonProperty("mentions")]
        public Mention[] Mentions { get; set; }

        [JsonProperty("urls")]
        public Url[] Urls { get; set; }

        [JsonProperty("hashtags")]
        public Hashtag[] Hashtags { get; set; }
    }

    public partial class Hashtag
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public partial class Mention
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }

        [JsonProperty("url")]
        public Uri UrlUrl { get; set; }

        [JsonProperty("expanded_url")]
        public Uri ExpandedUrl { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("unwound_url")]
        public Uri UnwoundUrl { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class PublicMetrics
    {
        [JsonProperty("retweet_count")]
        public long RetweetCount { get; set; }

        [JsonProperty("reply_count")]
        public long ReplyCount { get; set; }

        [JsonProperty("like_count")]
        public long LikeCount { get; set; }

        [JsonProperty("quote_count")]
        public long QuoteCount { get; set; }
    }

    public partial class ReferencedTweet
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class Includes
    {
        [JsonProperty("media")]
        public Media[] Media { get; set; }

        [JsonProperty("users")]
        public User[] Users { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("media_key")]
        public string MediaKey { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class User
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Tweet
    {
        public static Tweet FromJson(string json) => JsonConvert.DeserializeObject<Tweet>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Tweet self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}


