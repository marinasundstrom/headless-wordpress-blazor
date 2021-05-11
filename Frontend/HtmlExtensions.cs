using System;
using AngleSharp;
using AngleSharp.Html.Parser;

namespace Frontend
{
    public static class HtmlExtensions
    {
        public static string ReplaceMoreLink(this string str, string slug)
        {
            //Use the default configuration for AngleSharp
            var config = Configuration.Default;

            //Create a new context for evaluating webpages with the given config
            var context = BrowsingContext.New(config);

            var parser = context.GetService<IHtmlParser>();
            var source = str;
            var document = parser.ParseDocument(source);

            var element = document.QuerySelector(".more-link");

            if(element is AngleSharp.Html.Dom.IHtmlAnchorElement anchor)
            {
                anchor.Href = $"{slug}";
            }

            return document.ToHtml();
        }
    }
}
