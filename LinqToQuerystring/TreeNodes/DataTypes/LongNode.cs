﻿namespace LinqToQuerystring.TreeNodes.DataTypes
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using Antlr.Runtime;

    using LinqToQuerystring.TreeNodes.Base;

    public class LongNode : TreeNode
    {
        public LongNode(Type inputType, IToken payload, TreeNodeFactory treeNodeFactory)
            : base(inputType, payload, treeNodeFactory)
        {
        }

        public override Expression BuildLinqExpression(IQueryable query, Expression expression, Expression item = null)
        {
            return Expression.Constant(Convert.ToInt64(this.Text.Replace("L", string.Empty), System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}