using System;

namespace Core
{
	/// <summary>
	/// Project business object
	/// </summary>
	public class Project
	{
		#region members
		private uint id;

		private string description;

		private DateTime createdAt;
		#endregion

		#region construction
		public Project ()
		{
		}
		#endregion

		#region properties
		public uint Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}
			
		public string Description {
			get {
				return description;
			}
			set {
				description = value;
			}
		}

		public DateTime CreatedAt {
			get {
				return createdAt;
			}
			set {
				createdAt = value;
			}
		}
		#endregion
	}
}

