﻿using System;
using System.Data;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkCore.Generator.Metadata.Generation
{
    [DebuggerDisplay("Property: {PropertyName}, Column: {ColumnName}, Type: {StoreType}")]
    public class Property : ModelBase
    {
        public Entity Entity { get; set; }

        public string PropertyName { get; set; }

        public string ColumnName { get; set; }

        public string StoreType { get; set; }

        public string NativeType { get; set; }

        public DbType DataType { get; set; }

        public Type SystemType { get; set; }

        public bool? IsNullable { get; set; }

        public bool IsRequired => this.IsNullable == false;

        public bool IsOptional => this.IsNullable == true;

        public bool? IsPrimaryKey { get; set; }

        public bool? IsForeignKey { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsRowVersion { get; set; }

        public bool? IsUnique { get; set; }

        public bool? IsMaxLength { get; set; }

        public int? Size { get; set; }

        public int? Precision { get; set; }

        public int? Scale { get; set; }

        public string Default { get; set; }

        public ValueGenerated? ValueGenerated { get; set; }
    }
}
