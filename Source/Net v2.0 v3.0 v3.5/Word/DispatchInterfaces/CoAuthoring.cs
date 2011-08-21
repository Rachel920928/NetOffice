//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface CoAuthoring SupportByLibrary Word, 14
	///</summary>
	[SupportByLibrary("Word", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CoAuthoring : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(CoAuthoring);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CoAuthoring(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CoAuthoring(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CoAuthoring(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CoAuthoring() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CoAuthoring(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.CoAuthors Authors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Authors", paramsArray);
				NetOffice.WordApi.CoAuthors newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.CoAuthors.LateBindingApiWrapperType) as NetOffice.WordApi.CoAuthors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.CoAuthor Me
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Me", paramsArray);
				NetOffice.WordApi.CoAuthor newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.CoAuthor.LateBindingApiWrapperType) as NetOffice.WordApi.CoAuthor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool PendingUpdates
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PendingUpdates", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.CoAuthLocks Locks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Locks", paramsArray);
				NetOffice.WordApi.CoAuthLocks newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.CoAuthLocks.LateBindingApiWrapperType) as NetOffice.WordApi.CoAuthLocks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.CoAuthUpdates Updates
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Updates", paramsArray);
				NetOffice.WordApi.CoAuthUpdates newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.CoAuthUpdates.LateBindingApiWrapperType) as NetOffice.WordApi.CoAuthUpdates;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.Conflicts Conflicts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Conflicts", paramsArray);
				NetOffice.WordApi.Conflicts newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Conflicts.LateBindingApiWrapperType) as NetOffice.WordApi.Conflicts;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool CanShare
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanShare", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool CanMerge
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanMerge", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}