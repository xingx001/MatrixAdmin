﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Core.Extension;
using Core.Model;
using Core.Mvc.Areas.Redirect.Controllers;
using Core.Mvc.Areas.Redirect.ViewConfiguration.Home;
using Core.Mvc.Framework;
using Core.Web.Sidebar;
using Core.Web.ViewConfiguration;

namespace Core.Mvc.Areas.Redirect.ViewConfiguration.Button
{
    public class Button : SearchGridPage<object>
    {
        protected override string FileName { get; } = "buttons";

        public override string Render()
        {
            var url = new Url(typeof(Api.Controllers.IconController), nameof(Api.Controllers.IconController.Index));
            Task<ResponseModel> a = HttpClientAsync.GetAsync<IList<Icon>>(url);
            List<Icon> icons = (List<Icon>)a.Result.Data;
            string iconHtml = default;
            foreach (var icon in icons)
            {
                iconHtml += $"<li><i class=\"{icon.Code}\"></i> {icon.Code}</li>";
            }

            return base.Render().Replace("{{icon-png}}", iconHtml);
        }

        public override IList<string> Css()
        {
            return new List<string>
            {
                "/css/fullcalendar.css",
                "/font-awesome/css/font-awesome.css",
            };
        }

        protected override IList<string> JavaScript()
        {
            return new List<string>
            {
               "/js/matrix.js",
            };
        }

        protected override GridConfiguration<object> GridConfiguration()
        {
            return null;
        }

        protected override string ContentHeader()
        {
            ContentHeader contentHeader = new ContentHeader("Buttons & Icons");
            contentHeader.AddAnchor(new Anchor(new Url(typeof(RedirectController), nameof(RedirectController.Index)), "Home", "Go to Home", "icon-home", "tip-bottom"));
            return contentHeader.Render();
        }
    }
}