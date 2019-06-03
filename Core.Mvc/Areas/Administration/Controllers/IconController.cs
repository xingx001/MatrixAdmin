﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Core.Extension;
using Core.Model.Administration.Icon;
using Core.Mvc.Areas.Administration.ViewConfiguration.Icon;
using Core.Mvc.Framework;
using Microsoft.AspNetCore.Mvc;
using ApiController = Core.Api.Controllers.IconController;

namespace Core.Mvc.Areas.Administration.Controllers
{
    [Area(nameof(Administration))]
    public class IconController : StandardController
    {
        /// <summary>
        /// The index page.
        /// </summary>
        /// <returns>A IActionResult.</returns>
        public async Task<IActionResult> Index()
        {
            var url = new Url(typeof(ApiController), nameof(ApiController.Index));
            var responseModel = await HttpClientAsync.GetAsync<IList<Icon>>(url);
            IconIndex<IconPostModel> index = new IconIndex<IconPostModel>(responseModel);

            return this.SearchGridConfiguration(index);
        }

        /// <summary>
        /// Grid state change.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>A IActionResult.</returns>
        [HttpPost]
        public async Task<IActionResult> GridStateChange(IconPostModel model)
        {
            var url = new Url(typeof(ApiController), nameof(ApiController.Search));
            var response = await HttpClientAsync.PostAsync<IList<Icon>, IconPostModel>(url, model);
            IconGridConfiguration configuration = new IconGridConfiguration(response);

            return this.GridConfiguration(configuration);
        }

        /// <summary>
        /// The add dialog.
        /// </summary>
        /// <returns>A IActionResult.</returns>
        [HttpGet]
        public IActionResult AddDialog()
        {
            return null;
        }
    }
}