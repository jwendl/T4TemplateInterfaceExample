//  ----------------------------------------------------------------------------------------------
//  Template: Generates a business object that has properties based on the interface provided.
//  Author: Justin Wendlandt
//  Website: www.jwendl.net
//  Based on the work of: http://blog.baltrinic.com
//  Links: 
//          MSDN about developing T4 files: http://msdn.microsoft.com/en-us/library/bb126445.aspx
//                                          http://msdn.microsoft.com/en-us/library/dd820620.aspx 
//  ----------------------------------------------------------------------------------------------
using Csla;
using Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace CslaMagenicMasters.Business.Models
{
	/// <summary>
	/// Generated partial classes for properties.
	/// </summary>
	[Serializable]
	public partial class Artist
		: ReadOnlyBase<Artist>, IArtist
	{
		public static readonly PropertyInfo<int> ArtistIdProperty = RegisterProperty<int>(pi => pi.ArtistId); 
		public int ArtistId
		{
			get { return GetProperty(ArtistIdProperty); }
		}
		public static readonly PropertyInfo<String> NameProperty = RegisterProperty<String>(pi => pi.Name); 	
		[MaxLength(128)] 	
		[Display(ResourceType = typeof(AppResources), Name = "Artist_Name")] 
		public String Name
		{
			get { return GetProperty(NameProperty); }
		}
	}
}
