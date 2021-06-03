using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Frontend.Pages
{
    public partial class MenuItem
    {
        [JsonPropertyName("ID")]
        public long Id { get; set; }

        [JsonPropertyName("post_author")]
        public long PostAuthor { get; set; }

        [JsonPropertyName("post_date")]
        [JsonIgnore]
        public DateTimeOffset PostDate { get; set; }

        [JsonPropertyName("post_date_gmt")]
        [JsonIgnore]
        public DateTimeOffset PostDateGmt { get; set; }

        [JsonPropertyName("post_content")]
        public string PostContent { get; set; }

        [JsonPropertyName("post_title")]
        public string PostTitle { get; set; }

        [JsonPropertyName("post_excerpt")]
        public string PostExcerpt { get; set; }

        [JsonPropertyName("post_status")]
        public string PostStatus { get; set; }

        [JsonPropertyName("comment_status")]
        public string CommentStatus { get; set; }

        [JsonPropertyName("ping_status")]
        public string PingStatus { get; set; }

        [JsonPropertyName("post_password")]
        public string PostPassword { get; set; }

        [JsonPropertyName("post_name")]
        public string PostName { get; set; }

        [JsonPropertyName("to_ping")]
        public string ToPing { get; set; }

        [JsonPropertyName("pinged")]
        public string Pinged { get; set; }

        [JsonPropertyName("post_modified")]
        [JsonIgnore]
        public DateTimeOffset PostModified { get; set; }

        [JsonPropertyName("post_modified_gmt")]
        [JsonIgnore]
        public DateTimeOffset PostModifiedGmt { get; set; }

        [JsonPropertyName("post_content_filtered")]
        public string PostContentFiltered { get; set; }

        [JsonPropertyName("post_parent")]
        public long PostParent { get; set; }

        [JsonPropertyName("guid")]
        public Uri Guid { get; set; }

        [JsonPropertyName("menu_order")]
        public long MenuOrder { get; set; }

        [JsonPropertyName("post_type")]
        public string PostType { get; set; }

        [JsonPropertyName("post_mime_type")]
        public string PostMimeType { get; set; }

        [JsonPropertyName("comment_count")]
        public long CommentCount { get; set; }

        [JsonPropertyName("filter")]
        public string Filter { get; set; }

        [JsonPropertyName("db_id")]
        public long DbId { get; set; }

        [JsonPropertyName("menu_item_parent")]
        public long MenuItemParent { get; set; }

        [JsonPropertyName("object_id")]
        public long ObjectId { get; set; }

        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("type_label")]
        public string TypeLabel { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("target")]
        public string Target { get; set; }

        [JsonPropertyName("attr_title")]
        public string AttrTitle { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("classes")]
        public string[] Classes { get; set; }

        [JsonPropertyName("xfn")]
        public string Xfn { get; set; }
    }
}
