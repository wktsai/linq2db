// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SQLiteNorthwind
{
	[Table("Suppliers")]
	public class Supplier : IEquatable<Supplier>
	{
		[Column("SupplierID"  , DataType  = DataType.Int32  , DbType   = "int"           , Length = 4            , Precision = 10, Scale     = 0, IsPrimaryKey = true)] public int     SupplierId   { get; set; } // int
		[Column("CompanyName" , CanBeNull = false           , DataType = DataType.VarChar, DbType = "varchar(40)", Length    = 40, Precision = 0, Scale        = 0   )] public string  CompanyName  { get; set; } = null!; // varchar(40)
		[Column("ContactName" , DataType  = DataType.VarChar, DbType   = "varchar(30)"   , Length = 30           , Precision = 0 , Scale     = 0                     )] public string? ContactName  { get; set; } // varchar(30)
		[Column("ContactTitle", DataType  = DataType.VarChar, DbType   = "varchar(30)"   , Length = 30           , Precision = 0 , Scale     = 0                     )] public string? ContactTitle { get; set; } // varchar(30)
		[Column("Address"     , DataType  = DataType.VarChar, DbType   = "varchar(60)"   , Length = 60           , Precision = 0 , Scale     = 0                     )] public string? Address      { get; set; } // varchar(60)
		[Column("City"        , DataType  = DataType.VarChar, DbType   = "varchar(15)"   , Length = 15           , Precision = 0 , Scale     = 0                     )] public string? City         { get; set; } // varchar(15)
		[Column("Region"      , DataType  = DataType.VarChar, DbType   = "varchar(15)"   , Length = 15           , Precision = 0 , Scale     = 0                     )] public string? Region       { get; set; } // varchar(15)
		[Column("PostalCode"  , DataType  = DataType.VarChar, DbType   = "varchar(10)"   , Length = 10           , Precision = 0 , Scale     = 0                     )] public string? PostalCode   { get; set; } // varchar(10)
		[Column("Country"     , DataType  = DataType.VarChar, DbType   = "varchar(15)"   , Length = 15           , Precision = 0 , Scale     = 0                     )] public string? Country      { get; set; } // varchar(15)
		[Column("Phone"       , DataType  = DataType.VarChar, DbType   = "varchar(24)"   , Length = 24           , Precision = 0 , Scale     = 0                     )] public string? Phone        { get; set; } // varchar(24)
		[Column("Fax"         , DataType  = DataType.VarChar, DbType   = "varchar(24)"   , Length = 24           , Precision = 0 , Scale     = 0                     )] public string? Fax          { get; set; } // varchar(24)
		[Column("HomePage"    , DataType  = DataType.Text   , DbType   = "text(max)"     , Length = 2147483647   , Precision = 0 , Scale     = 0                     )] public string? HomePage     { get; set; } // text(max)

		#region IEquatable<T> support
		private static readonly IEqualityComparer<Supplier> _equalityComparer = ComparerBuilder.GetEqualityComparer<Supplier>(c => c.SupplierId);

		public bool Equals(Supplier? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as Supplier);
		}
		#endregion
	}
}