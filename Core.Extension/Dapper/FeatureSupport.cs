﻿using System;
using System.Data;

namespace Core.Extension.Dapper
{
    /// <summary>
    /// Handles variances in features per DBMS.
    /// </summary>
    internal class FeatureSupport
    {
        private static readonly FeatureSupport Default = new FeatureSupport(false);
        private static readonly FeatureSupport Postgres = new FeatureSupport(true);

        private FeatureSupport(bool arrays)
        {
            this.Arrays = arrays;
        }

        /// <summary>
        /// Gets a value indicating whether true if the db supports array columns e.g. Postgresql.
        /// </summary>
        public bool Arrays { get; }

        /// <summary>
        /// Gets the feature set based on the passed connection.
        /// </summary>
        /// <param name="connection">The connection to get supported features for.</param>
        /// <returns></returns>
        public static FeatureSupport Get(IDbConnection connection)
        {
            string name = connection?.GetType().Name;
            if (string.Equals(name, "npgsqlconnection", StringComparison.OrdinalIgnoreCase))
            {
                return Postgres;
            }

            return Default;
        }

    }
}
