//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface FileDialog SupportByLibrary Office, 10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FileDialog : _IMsoDispObj
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(FileDialog);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
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
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.FileDialogFilters Filters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filters", paramsArray);
				NetOffice.OfficeApi.FileDialogFilters newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.FileDialogFilters.LateBindingApiWrapperType) as NetOffice.OfficeApi.FileDialogFilters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public Int32 FilterIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FilterIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FilterIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string ButtonName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ButtonName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ButtonName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public bool AllowMultiSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowMultiSelect", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowMultiSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoFileDialogView InitialView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InitialView", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoFileDialogView)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InitialView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string InitialFileName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InitialFileName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InitialFileName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.FileDialogSelectedItems SelectedItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectedItems", paramsArray);
				NetOffice.OfficeApi.FileDialogSelectedItems newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.FileDialogSelectedItems.LateBindingApiWrapperType) as NetOffice.OfficeApi.FileDialogSelectedItems;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoFileDialogType DialogType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DialogType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoFileDialogType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string Item
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public Int32 Show()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Show", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void Execute()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Execute", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}