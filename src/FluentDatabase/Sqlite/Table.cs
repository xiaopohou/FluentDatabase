﻿using System;
using System.IO;

namespace FluentDatabase.Sqlite
{
	public class Table : TableBase
	{
		protected override void WriteTableBegin( StreamWriter writer )
		{
			throw new NotImplementedException();
		}

		protected override void WriteTableEnd( StreamWriter writer )
		{
			throw new NotImplementedException();
		}

		protected override IColumn CreateColumn()
		{
			return new Column();
		}
	}
}