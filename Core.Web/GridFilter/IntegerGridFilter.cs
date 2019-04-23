﻿using System;
using System.Linq.Expressions;

namespace Core.Web.GridFilter
{
    public class IntegerGridFilter<T> : BaseGridFilter<T>
    {
        private readonly Expression<Func<T, int>> expression;

        public IntegerGridFilter(Expression<Func<T, int>> expression, string thead) : base(thead)
        {
            this.expression = expression;
        }
    }
}