﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Common.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Artist.
        /// </summary>
        public static string Album_Artist {
            get {
                return ResourceManager.GetString("Album_Artist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image Url.
        /// </summary>
        public static string Album_ImageUrl {
            get {
                return ResourceManager.GetString("Album_ImageUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string Album_Name {
            get {
                return ResourceManager.GetString("Album_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string Artist_Name {
            get {
                return ResourceManager.GetString("Artist_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Album.
        /// </summary>
        public static string Song_Album {
            get {
                return ResourceManager.GetString("Song_Album", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Length.
        /// </summary>
        public static string Song_Length {
            get {
                return ResourceManager.GetString("Song_Length", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string Song_Name {
            get {
                return ResourceManager.GetString("Song_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tiny Song Url.
        /// </summary>
        public static string Song_TinySongUrl {
            get {
                return ResourceManager.GetString("Song_TinySongUrl", resourceCulture);
            }
        }
    }
}