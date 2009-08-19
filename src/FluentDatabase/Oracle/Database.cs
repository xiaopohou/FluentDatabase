﻿using System;
using System.IO;

namespace FluentDatabase.Oracle
{
	public class Database : DatabaseBase
	{
		protected override ITable CreateTable()
		{
			return new Table();
		}

		protected override void WriteUse( StreamWriter writer )
		{
			throw new NotImplementedException();
		}
	}
}