﻿using System.Linq;
using AutoMapper;
using Core.Api.ControllerHelpers;
using Core.Entity;
using Core.Extension;
using Core.Model;
using Core.Model.Log;
using Core.Api.Framework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core.Api.Controllers
{
    /// <summary>
    /// Log controller.
    /// </summary>
    public class LogController : StandardController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogController"/> class.
        /// </summary>
        /// <param name="dbContext">The dbContext.</param>
        /// <param name="mapper">The mapper.</param>
        public LogController(CoreContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            using (this.DbContext)
            {
                IQueryable<Log> query = this.DbContext.Log.AsNoTracking();
                query = query.OrderByDescending(o => o.CreateTime);
                Pager pager = Pager.CreateDefaultInstance();

                return this.StandardSearchResponse(query, pager, LogModel.Convert);
            }
        }

        [HttpPost]
        public IActionResult Search(LogPostModel model)
        {
            using (this.DbContext)
            {
                IQueryable<Log> query = this.DbContext.Log.AsNoTracking();

                query = query.AddFilter(o => o.LogLevel == (int?)model.LogLevel, model.LogLevel);
                query = query.AddFilter(o => o.SqlOperateType == (int?)model.SqlType, model.SqlType);
                query = query.AddFilter(o => o.Message.Contains(model.Message), model.Message);
                query = query.AddDateTimeBetweenFilter(model.StartTime, model.EndTime, o => o.CreateTime);
                query = query.OrderByDescending(o => o.CreateTime);

                return this.StandardSearchResponse(query, model, LogModel.Convert);
            }
        }

        /// <summary>
        /// 删除用户.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [HttpGet]
        public IActionResult Clear()
        {
            HttpResponseModel response = LogControllerHelper.DeleteAll();
            return this.Ok(response);
        }
    }
}