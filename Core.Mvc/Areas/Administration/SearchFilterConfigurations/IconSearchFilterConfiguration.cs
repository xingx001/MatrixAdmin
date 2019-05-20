﻿using System.Collections.Generic;
using Core.Extension;
using Core.Model.Administration.Icon;
using Core.Mvc.Areas.Administration.Controllers;
using Core.Web.Button;
using Core.Web.GridFilter;
using Core.Web.SearchFilterConfiguration;
using Resources = Core.Resource.Areas.Administration.ViewConfiguration.Icon.IconResource;

namespace Core.Mvc.Areas.Administration.SearchFilterConfigurations
{
    public class IconSearchFilterConfiguration : SearchFilterConfiguration<IconPostModel>
    {
        protected override void CreateSearchFilter(IList<BaseGridFilter> searchFilter)
        {
            searchFilter.Add(new TextGridFilter<IconPostModel>(o => o.Code, Resources.Code));
            var filter = new BooleanGridFilter<IconPostModel>(o => o.IsEnable, Resources.Status);
            filter.AddOption(true, "可用");
            filter.AddOption(false, "不可用");
            searchFilter.Add(filter);
        }

        protected override void CreateButton(IList<StandardButton> buttons)
        {
            Url searchUrl = new Url(nameof(Administration), typeof(IconController), nameof(IconController.GridStateChange));
            buttons.Add(new StandardButton("搜索", "index.search", searchUrl));
            buttons.Add(new StandardButton("清理", "core.clear"));
        }
    }
}
