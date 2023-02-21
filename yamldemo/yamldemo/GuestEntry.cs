//
//  File: GuestEntry.cs
//  Date: 2023-2-20
//  Description:
//
//
using System;
namespace yamldemo
{
	public class GuestEntry
	{
		public GuestEntry()
		{
			Visits = new List<GuestVisit>();
		}

		public string Name { get; set; }
		public string Email { get; set; }
		public string Note { get; set; }
		public List<GuestVisit> Visits { get; set; }
		public DateTime Created { get; set; }
	}
}

