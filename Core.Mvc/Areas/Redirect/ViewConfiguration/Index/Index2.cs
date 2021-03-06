﻿using System.Collections.Generic;
using Core.Mvc.Areas.Redirect.ViewConfiguration.Home;
using Core.Web.ViewConfiguration;

namespace Core.Mvc.Areas.Redirect.ViewConfiguration.Index
{
    public class Index2 : SearchGridPage<object>
    {
        protected override string FileName
        {
            get
            {
                return "Index2";
            }
        }

        public override IList<string> CssFiles()
        {
            return new List<string>
            {
                "/css/fullcalendar.css",

                "/font-awesome/css/font-awesome.css",
            };
        }

        protected override IList<string> JavaScriptFiles()
        {
            return new List<string>
            {
               "/js/excanvas.min.js",
               "/js/jquery.flot.min.js",
               "/js/jquery.flot.resize.min.js",
               "/js/jquery.peity.min.js",
               "/js/matrix.js",
               "/js/fullcalendar.min.js",
               "/js/matrix.calendar.js",
               "/js/jquery.validate.js",
               "/js/matrix.form_validation.js",
               "/js/jquery.wizard.js",
               "/js/jquery.uniform.js",
               "/js/matrix.popover.js",
               "/js/jquery.dataTables.min.js",
               "/js/matrix.tables.js",
               "/js/matrix.interface.js",
            };
        }

        protected override GridConfiguration<object> GridConfiguration()
        {
            return null;
        }
    }
}