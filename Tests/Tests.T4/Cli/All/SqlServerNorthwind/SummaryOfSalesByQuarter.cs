// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using System.Data.SqlTypes;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SqlServerNorthwind
{
	[Table("Summary of Sales by Quarter", IsView = true)]
	public class SummaryOfSalesByQuarter
	{
		[Column("ShippedDate", DataType = DataType.DateTime, DbType = "datetime")] public SqlDateTime? ShippedDate { get; set; } // datetime
		[Column("OrderID"    , DataType = DataType.Int32   , DbType = "int"     )] public SqlInt32     OrderId     { get; set; } // int
		[Column("Subtotal"   , DataType = DataType.Money   , DbType = "money"   )] public SqlMoney?    Subtotal    { get; set; } // money
	}
}