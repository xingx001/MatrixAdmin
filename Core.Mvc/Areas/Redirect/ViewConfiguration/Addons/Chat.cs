﻿using System.Collections.Generic;
using Core.Mvc.Areas.Redirect.Routes;
using Core.Mvc.Areas.Redirect.ViewConfiguration.Home;
using Core.Web.SearchFilterConfiguration;
using Core.Web.Sidebar;
using Core.Web.ViewConfiguration;

namespace Core.Mvc.Areas.Redirect.ViewConfiguration.Addons
{
    public class Chat : SearchGridPage<object>
    {
        protected override string FileName
        {
            get
            {
                return "Chat";
            }
        }

        public override IList<string> CssFiles()
        {
            return new List<string>
            {
                "/font-awesome/css/font-awesome.css",
            };
        }

        protected override IList<string> JavaScriptFiles()
        {
            return new List<string>
            {
               Javascript.Matrix,
               Javascript.MatrixChat,
            };
        }

        protected override SearchFilterConfiguration SearchFilterConfiguration()
        {
            return null;
        }

        protected override GridConfiguration<object> GridConfiguration()
        {
            return null;
        }

        protected override string ContentHeader()
        {
            ContentHeader contentHeader = new ContentHeader("Gallery");
            contentHeader.AddAnchor(new Anchor(RedirectRoute.Index, "Home", "Go to Home", "icon-home", "tip-bottom"));
            return contentHeader.Render();
        }
    }
}