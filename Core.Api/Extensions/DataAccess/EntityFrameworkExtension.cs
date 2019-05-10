﻿using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Core.Api.Extensions.DataAccess
{
    /// <summary>
    ///
    /// </summary>
    public static class EntityFrameworkExtension
    {
        /// <summary>
        /// 调用ADO.NET执行SQL语句查询泛型集合.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="database">数据库连接上下文.</param>
        /// <param name="sql">SQL语句.</param>
        /// <param name="parameter">SQL语句需要的参数.</param>
        /// <returns></returns>
        public static List<T> FromSql<T>(this DatabaseFacade database, string sql, object parameter = null)
        {
            List<T> result;
            using (DbCommand command = database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                if (parameter != null)
                {
                    object[] parameters = parameter.ToSqlParamsArray();
                    command.Parameters.AddRange(parameters);
                }

                database.OpenConnection();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    result = dt.ToList<T>();
                    return result;
                }
            }
        }
    }
}
