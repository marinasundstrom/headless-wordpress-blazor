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
    public partial class Navigation
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("content")]
        public NavigationContent Content { get; set; }
    }

    public partial class NavigationContent
    {
        [JsonPropertyName("rendered")]
        public string Rendered { get; set; }
    }
}
