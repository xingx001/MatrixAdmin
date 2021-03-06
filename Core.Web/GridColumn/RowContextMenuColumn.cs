﻿using Core.Shared.Utilities;
using System;
using System.Linq.Expressions;

namespace Core.Web.GridColumn
{
    public class RowContextMenuColumn<T> : BaseGridColumn<T>
    {
        private readonly Expression<Func<T, int?>> _expression;

        public RowContextMenuColumn(Expression<Func<T, int?>> expression, string thead, string url) : base(thead)
        {
            Check.NotNull(expression, nameof(expression));

            this._expression = expression;
            this.Url = url;
        }

        public string Url { get; set; }

        public override string RenderTd(T entity)
        {
            Check.NotNull(entity, nameof(entity));

            var value = this._expression.Compile()(entity);
            string innerHtml = $"<span class=\"icon-list dropdown-toggle\" data-url=\"{this.Url}\" data-id=\"{value}\" data-toggle=\"dropdown\"></span>" +
                               $"<div class=\"dropdown-menu\"></div>";
            return this.RenderTd(innerHtml);
        }
    }
}