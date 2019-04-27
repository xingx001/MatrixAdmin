﻿using Core.Extension;
using Core.Model.Entity;
using Core.Model.PostModel;
using Core.Model.ResponseModels;
using Core.Mvc.ViewConfiguration.Administration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core.Mvc.Controllers
{
    public class PermissionController : StandardController
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public PermissionController(IHostingEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
        }

        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var url = new Url(typeof(Api.Controllers.PermissionController), nameof(Api.Controllers.PermissionController.Index));
            var model = AsyncRequest.GetAsync<IList<Permission>>(url).Result;
            PermissionIndex table = new PermissionIndex(HostingEnvironment, model);

            return this.ViewConfiguration(table);
        }

        /// <summary>
        /// Grid state change.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GridStateChange(PermissionPostModel model)
        {
            var url = new Url(typeof(Api.Controllers.PermissionController), nameof(Api.Controllers.PermissionController.Search));
            ResponseModel response = AsyncRequest.PostAsync<IList<Permission>, PermissionPostModel>(url, model).Result;
            PermissionGridConfiguration configuration = new PermissionGridConfiguration(response);

            return this.GridConfiguration(configuration);
        }
    }
}