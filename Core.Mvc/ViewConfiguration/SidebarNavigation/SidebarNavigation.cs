﻿using Core.Web.Sidebar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Resource.ViewConfiguration;

namespace Core.Mvc.ViewConfiguration.SidebarNavigation
{
    public class SidebarNavigation
    {
        public SidebarNavigation()
        {

        }


        public IList<string> Css()
        {
            return new List<string>
            {
                "/css/bootstrap.min.css",
                "/css/bootstrap-responsive.min.css",
                "/css/uniform.css",
                "/css/select2.css",
                "/css/matrix-style.css",
                "/css/matrix-media.css",
                "/font-awesome/css/font-awesome.css",
            };
        }

        public IList<string> Javascript()
        {
            return new List<string>
            {
                "/js/jquery.min.js",
                "/js/jquery.ui.custom.js",
                "/js/select2.min.js",
                "/js/jquery.dataTables.min.js",
                "/js/matrix.js",
                "/lib/jquery/dist/jquery.js",
                "/js/bootstrap.min.js",
                "/js/bootstrap-datetimepicker.js",
            };
        }

        public string Render()
        {
            SubMenu forms = new SubMenu("icon icon-th-list", "", "Forms", 3);
            forms.AddLinkButton(new LinkedAnchor("/Redirect/formcommon", "Basic Form"));
            forms.AddLinkButton(new LinkedAnchor("/Redirect/formvalidation", "Form with Validation"));
            forms.AddLinkButton(new LinkedAnchor("/Redirect/formwizard", "Form with Wizard"));


            SubMenu addons = new SubMenu("icon icon-file", "", "Addons", 5);
            addons.AddLinkButton(new LinkedAnchor("/Redirect/index2", "Dashboard2"));
            addons.AddLinkButton(new LinkedAnchor("/Redirect/gallery", "Gallery"));
            addons.AddLinkButton(new LinkedAnchor("/Redirect/calendar", "Calendar"));
            addons.AddLinkButton(new LinkedAnchor("/Redirect/invoice", "Invoice"));
            addons.AddLinkButton(new LinkedAnchor("/Redirect/chat", "Chat option"));

            SubMenu error = new SubMenu("icon icon-info-sign", "", "Error", 4);
            error.AddLinkButton(new LinkedAnchor("/Redirect/error403", "Error 403"));
            error.AddLinkButton(new LinkedAnchor("/Redirect/error404", "Error 404"));
            error.AddLinkButton(new LinkedAnchor("/Redirect/error405", "Error 405"));
            error.AddLinkButton(new LinkedAnchor("/Redirect/error500", "Error 500"));

            SubMenu manage = new SubMenu("icon icon-user", "", IndexBaseResource.SystemManage, 8);
            manage.AddLinkButton(new LinkedAnchor("/User/UserManage", IndexBaseResource.UserManage));
            manage.AddLinkButton(new LinkedAnchor("/User/RoleManage", IndexBaseResource.RoleManage));
            manage.AddLinkButton(new LinkedAnchor("/User/PermissionManage", IndexBaseResource.PermissionManage));
            manage.AddLinkButton(new LinkedAnchor("/User/MenuManage", IndexBaseResource.MenuManage));
            manage.AddLinkButton(new LinkedAnchor("/User/IconManage", IndexBaseResource.IconManage));

            SubMenu log = new SubMenu("icon icon-edit", "", IndexBaseResource.LogManage, 2);
            log.AddLinkButton(new LinkedAnchor("/Log/error", IndexBaseResource.ErrorLog));

            Sidebar sidebar = new Sidebar();
            sidebar.AddSubMenu(new SubMenu("icon icon-home", "/Redirect/index", "Dashboard", 0, true));
            sidebar.AddSubMenu(manage);
            sidebar.AddSubMenu(log);
            sidebar.AddSubMenu(new SubMenu("icon icon-signal", "/Redirect/charts", "Charts &amp; Graphs"));
            sidebar.AddSubMenu(new SubMenu("icon icon-inbox", "/Redirect/widgets", "Widgets"));
            sidebar.AddSubMenu(new SubMenu("icon icon-th", "/Redirect/tables", "Tables"));
            sidebar.AddSubMenu(new SubMenu("icon icon-fullscreen", "/Redirect/grid", "Full width"));
            sidebar.AddSubMenu(forms);
            sidebar.AddSubMenu(new SubMenu("icon icon-tint", "/Redirect/buttons", "Buttons &amp; Icons"));
            sidebar.AddSubMenu(new SubMenu("icon icon-pencil", "/Redirect/interface", "Elements"));
            sidebar.AddSubMenu(addons);
            sidebar.AddSubMenu(error);

            sidebar.AddSubContent(new SidebarContent("Monthly Bandwidth Transfer", 0.77, "21419.94 / 14000 MB", "progress progress-mini progress-danger active progress-striped"));
            sidebar.AddSubContent(new SidebarContent("Disk Space Usage", 0.87, "604.44 / 4000 MB", "progress progress-mini active progress-striped"));
            sidebar.AddSubContent(new SidebarContent("CPU Usage", 0.27, "1.3 / 4.8 Hz", "progress progress-mini active progress-striped"));

            return sidebar.Render();
        }
    }
}
