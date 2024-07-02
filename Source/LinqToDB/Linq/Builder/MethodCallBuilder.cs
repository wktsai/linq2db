﻿using System.Linq;
using System.Linq.Expressions;

namespace LinqToDB.Linq.Builder
{
	using LinqToDB.Expressions;

	abstract class MethodCallBuilder : ISequenceBuilder
	{
		public BuildSequenceResult BuildSequence(ExpressionBuilder builder, BuildInfo buildInfo)
			=> BuildMethodCall(builder, (MethodCallExpression)buildInfo.Expression, buildInfo);

		public virtual bool IsSequence(ExpressionBuilder builder, BuildInfo buildInfo)
		{
			var mc = (MethodCallExpression)buildInfo.Expression;
			return mc.IsQueryable()
				? builder.IsSequence(new BuildInfo(buildInfo, mc.Arguments[0]))
				: false;
		}

		public virtual bool IsAggregationContext(ExpressionBuilder builder, BuildInfo buildInfo) 
			=> false;

		protected abstract BuildSequenceResult BuildMethodCall(ExpressionBuilder builder, MethodCallExpression methodCall, BuildInfo buildInfo);
	}
}
