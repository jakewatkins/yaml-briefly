//
//  File: GuestBook.cs
//  Date: 2023-2-20
//  Description:
//
//
using System;
namespace yamldemo
{
	public class GuestBook
	{
		public GuestBook()
		{
			Entries = new List<GuestEntry>();
		}

		public List<GuestEntry> Entries { get; set; }
	}
}

