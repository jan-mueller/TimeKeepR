using System;

namespace Core
{
	/// <summary>
	/// Record business object
	/// </summary>
	public class Record
	{
		#region members
		private uint id;

		private uint projectId;
		
		private string[] tags;

		private DateTime startTime;

		private DateTime endTime;
		#endregion

		#region construction
		public Record ()
		{
		}
		#endregion

		#region properties
		public uint ProjectId {
			get {
				return projectId;
			}
			set { 
				this.projectId = value;
			}
		}

		public string[] Tags {
			get {
				return tags;
			}
			set { 
				this.tags = value;
			}
		}

		public DateTime StartTime {
			get {
				return startTime;
			}
			set {
				startTime = value;
			}
		}

		public DateTime EndTime {
			get {
				return endTime;
			}
			set {
				endTime = value;
			}
		}
		#endregion
	}
}

