using System;
using System.Linq;
using System.Collections.Generic;

using Mono.Data.Sqlite;
using System.IO;
using System.Data;

namespace Core
{
	/// <summary>
	/// Database uses ADO.NET to create the [Items] table and create,read,update,delete data
	/// </summary>
	public class Database
	{
		static object _dblock = new object ();

		private SqliteConnection connection;

		private string path;

		/// <summary>
		/// Initializes a new instance of the <see cref="Database"/> Database.
		/// If the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		public Database (string dbPath)
		{
			var output = "";
			path = dbPath;

			bool exists = File.Exists (dbPath);

			if (!exists) {
				connection = new SqliteConnection ("Data Source=" + path);

				connection.Open ();
				var commands = new[] {
					"CREATE TABLE [Projects] (_id INTEGER PRIMARY KEY ASC, " +
					"description NTEXT, " +
					"created_at DATETIME);",
					"CREATE TABLE [Records] (_id INTEGER PRIMARY KEY ASC, " +
					"project_id INTEGER, " +
					"start_time DATETIME, end_time DATETIME)"
				};
				foreach (var command in commands) {
					using (var c = connection.CreateCommand ()) {
						c.CommandText = command;
						c.ExecuteNonQuery ();
					}
				}
			}
			Console.WriteLine (output);
		}
	}
}

