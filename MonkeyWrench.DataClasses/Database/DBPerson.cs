/*
 * DBPerson.cs
 *
 * Authors:
 *   Rolf Bjarne Kvinge (RKvinge@novell.com)
 *   
 * Copyright 2009 Novell, Inc. (http://www.novell.com)
 *
 * See the LICENSE file included with the distribution for details.
 *
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace MonkeyWrench.DataClasses
{
	public partial class DBPerson : DBRecord
	{
		public const string TableName = "Person";
		public string [] Emails;

		public DBPerson ()
		{
		}
	
		public DBPerson (IDataReader reader) 
			: base (reader)
		{
		}

		public string [] Roles
		{
			get { return roles == null ? null : roles.Split (new char [] { ',' }, StringSplitOptions.RemoveEmptyEntries); }
		}
	}
}

