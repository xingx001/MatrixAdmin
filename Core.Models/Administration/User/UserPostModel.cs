﻿using System;
using System.Linq;
using Core.Entity;
using Core.Entity.Enums;
using Core.Extension;
using Core.Extension.ExpressionBuilder.Generics;

namespace Core.Model.Administration.User
{
    /// <summary>
    /// User post model.
    /// </summary>
    public class UserPostModel : Pager
    {
        /// <summary>
        /// 是否已被删除.
        /// </summary>
        public bool? IsEnable { get; set; }

        /// <summary>
        /// 登录名.
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 展示名.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 状态.
        /// </summary>
        public IsForbiddenEnum? Status { get; set; }

        /// <summary>
        /// 角色.
        /// </summary>
        public int? RoleId { get; set; }

        /// <summary>
        /// 开始创建时间.
        /// </summary>
        public DateTime? StartCreateTime { get; set; }

        /// <summary>
        /// 结束创建时间.
        /// </summary>
        public DateTime? EndCreateTime { get; set; }

        public IQueryable<Entity.User> GenerateQuery(IQueryable<Entity.User> query)
        {
            query = query.AddFilter(this.RoleId, o => o.UserRoleMapping.Any(x => x.RoleId == this.RoleId));
            query = query.AddFilter(this.IsEnable, o => o.IsEnable);
            query = query.AddFilter(this.Status, o => o.Status == (int?)this.Status);
            query = query.AddFilter(this.DisplayName, o => o.DisplayName.Contains(this.DisplayName));
            query = query.AddFilter(this.LoginName, o => o.LoginName.Contains(this.LoginName));
            query = query.AddDateTimeBetweenFilter(this.StartCreateTime, this.EndCreateTime, o => o.CreateTime);

            query = query.OrderByDescending(o => o.CreateTime);
            return query;
        }
    }
}
