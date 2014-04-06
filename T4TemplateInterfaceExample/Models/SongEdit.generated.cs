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
	public partial class SongEdit
		: BusinessBase<SongEdit>, ISongEdit
	{
		public static readonly PropertyInfo<int> SongIdProperty = RegisterProperty<int>(pi => pi.SongId); 
		public int SongId
		{
			get { return GetProperty(SongIdProperty); }
			set { SetProperty(SongIdProperty, value); } 
		}
		public static readonly PropertyInfo<int> AlbumIdProperty = RegisterProperty<int>(pi => pi.AlbumId); 	
		[Display(ResourceType = typeof(AppResources), Name = "Song_Album")] 
		public int AlbumId
		{
			get { return GetProperty(AlbumIdProperty); }
			set { SetProperty(AlbumIdProperty, value); } 
		}
		public static readonly PropertyInfo<String> NameProperty = RegisterProperty<String>(pi => pi.Name); 	
		[MaxLength(128)] 	
		[Display(ResourceType = typeof(AppResources), Name = "Song_Name")] 
		public String Name
		{
			get { return GetProperty(NameProperty); }
			set { SetProperty(NameProperty, value); } 
		}
		public static readonly PropertyInfo<String> LengthProperty = RegisterProperty<String>(pi => pi.Length); 	
		[MaxLength(10)] 	
		[Display(ResourceType = typeof(AppResources), Name = "Song_Length")] 
		public String Length
		{
			get { return GetProperty(LengthProperty); }
			set { SetProperty(LengthProperty, value); } 
		}
		public static readonly PropertyInfo<String> TinySongUrlProperty = RegisterProperty<String>(pi => pi.TinySongUrl); 	
		[MaxLength(256)] 	
		[Display(ResourceType = typeof(AppResources), Name = "Song_TinySongUrl")] 
		public String TinySongUrl
		{
			get { return GetProperty(TinySongUrlProperty); }
			set { SetProperty(TinySongUrlProperty, value); } 
		}
	}
}
