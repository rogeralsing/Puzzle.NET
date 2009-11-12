// *
// * Copyright (C) 2005 Mats Helander : http://www.puzzleframework.com
// *
// * This library is free software; you can redistribute it and/or modify it
// * under the terms of the GNU Lesser General Public License 2.1 or later, as
// * published by the Free Software Foundation. See the included license.txt
// * or http://www.gnu.org/copyleft/lesser.html for details.
// *
// *

using System;
using Puzzle.NPersist.Framework.Sql.Visitor;

namespace Puzzle.NPersist.Framework.Sql.Dom
{
	/// <summary>
	/// Summary description for SqlAvgFunction.
	/// </summary>
	public class SqlAvgFunction : SqlFunction
	{
		public SqlAvgFunction(SqlExpression sqlExpression, bool distinct)
		{
			this.sqlExpression = sqlExpression;
			this.distinct = distinct;
		}

		public SqlAvgFunction(SqlExpression sqlExpression) : this(sqlExpression, false)
		{
		}

		public SqlAvgFunction() : this(null, false)
		{
		}

		public override void Accept(ISqlVisitor visitor)
		{
			visitor.Visiting(this);	
			visitor.Visited(this);	
		}	

		#region Property  SqlExpression
		
		private SqlExpression sqlExpression;
		
		public SqlExpression SqlExpression
		{
			get { return this.sqlExpression; }
			set { this.sqlExpression = value; }
		}
		
		#endregion

		#region Property  Distinct
		
		private bool distinct;
		
		public bool Distinct
		{
			get { return this.distinct; }
			set { this.distinct = value; }
		}
		
		#endregion
	}
}