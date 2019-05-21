﻿using Core.Entity;
using Core.Extension.Dapper;
using Core.Model;

namespace Core.Api.ControllerHelpers
{
    public static class LogControllerHelper
    {
        /// <summary>
        /// 清空.
        /// </summary>
        /// <returns>A ResponseModel.</returns>
        public static ResponseModel DeleteAll()
        {
            string sql = $"TRUNCATE TABLE [{nameof(Log)}]";
            CoreApiContext.Dapper2.Execute(sql);
            return ResponseModelFactory.CreateInstance;
        }
    }
}
