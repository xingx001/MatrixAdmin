﻿using System.Collections.Generic;
using Core.Model;
using Core.Mvc.Areas.Administration.SearchFilterConfigurations;
using Core.Mvc.Areas.Redirect.Routes;
using Core.Mvc.Areas.Redirect.ViewConfiguration.Home;
using Core.Web.JavaScript;
using Core.Web.SearchFilterConfiguration;
using Core.Web.Sidebar;
using Core.Web.ViewConfiguration;
using Resources = Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Permission.PermissionIndexResource;

namespace Core.Mvc.Areas.Administration.ViewConfiguration.Permission
{
    public class PermissionIndex : SearchGridPage<object>
    {
        private readonly HttpResponseModel _response;

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionIndex"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        public PermissionIndex(HttpResponseModel response)
        {
            this._response = response;
        }

        public override IList<string> CssFiles()
        {
            return new List<string>();
        }

        public override string Render()
        {
            PermissionGridConfiguration configuration = new PermissionGridConfiguration(this._response);
            string table = configuration.GenerateGridColumn();
            var html = base.Render().Replace("{{Table}}", table);

            return html;
        }

        protected override IList<string> JavaScriptFiles()
        {
            return new List<string>
            {
               Js.Permission.Index
            };
        }

        protected override SearchFilterConfiguration SearchFilterConfiguration()
        {
            return new PermissionSearchFilterConfiguration();
        }

        protected override GridConfiguration<object> GridConfiguration()
        {
            return null;
        }

        protected override string ContentHeader()
        {
            ContentHeader contentHeader = new ContentHeader(Resources.WidgetTitle);
            contentHeader.AddAnchor(new Anchor(RedirectRoute.Index, "首页", "返回首页", "icon-home", "tip-bottom"));
            string html = contentHeader.Render();
            return html;
        }

        protected override IList<ViewInstanceConstruction> CreateViewInstanceConstructions()
        {
            IList<ViewInstanceConstruction> constructions = new List<ViewInstanceConstruction>
            {
                new IndexViewInstance(),
                new PermissionViewInstance()
            };
            return constructions;
        }
    }
}