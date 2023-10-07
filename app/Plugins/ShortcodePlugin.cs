﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Pchp.Core;
using Peachpie.AspNetCore.Mvc;
using Peachpie.AspNetCore.Web;
using PeachPied.WordPress.Standard;

namespace PeachPied.Demo.Plugins
{
    class ShortcodePlugin : IWpPlugin
    {
        public ShortcodePlugin()
        {
        }

        public ValueTask ConfigureAsync(WpApp app, CancellationToken token)
        {
            app.AddShortcode("dotnetWpUser", new Func<string>(() => //new shortcode_handler((attrs, content) =>
            {
                var user = (WP_User)app.Context.Call("wp_get_current_user", Array.Empty<PhpValue>()).AsObject();
                if (user != null)
                {
                    return $"Your WP_User ID is {user.ID}.";
                }
                else
                {
                    return "You are not logged in.";
                }
            }));

            return ValueTask.CompletedTask;
        }
    }
}
