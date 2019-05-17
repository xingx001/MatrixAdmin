﻿using System;
using System.Linq.Expressions;

namespace Core.Extension.ExpressionBuilder.Generics
{
    public class StringIsEmptyFilter<T> : BaseSingleFilter<T>
    {
        public StringIsEmptyFilter(Expression<Func<T, string>> expression, string value) : base(expression.GetPropertyName(), Operations.Operation.IsEmpty, value)
        {
        }
    }
}
