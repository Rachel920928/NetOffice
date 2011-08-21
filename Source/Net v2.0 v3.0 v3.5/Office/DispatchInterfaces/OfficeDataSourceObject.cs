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
	/// DispatchInterface OfficeDataSourceObject SupportByLibrary Office, 10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class OfficeDataSourceObject : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(OfficeDataSourceObject);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OfficeDataSourceObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OfficeDataSourceObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OfficeDataSourceObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OfficeDataSourceObject() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OfficeDataSourceObject(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string ConnectString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConnectString", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ConnectString", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string Table
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Table", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Table", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string DataSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSource", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public COMObject Columns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Columns", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public Int32 RowCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public COMObject Filters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filters", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="MsoMoveRow">NetOffice.OfficeApi.Enums.MsoMoveRow MsoMoveRow</param>
		/// <param name="RowNbr">Int32 RowNbr</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public Int32 Move(NetOffice.OfficeApi.Enums.MsoMoveRow msoMoveRow, Int32 rowNbr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(msoMoveRow, rowNbr);
			object returnItem = Invoker.MethodReturn(this, "Move", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrSrc">string bstrSrc</param>
		/// <param name="bstrConnect">string bstrConnect</param>
		/// <param name="bstrTable">string bstrTable</param>
		/// <param name="fOpenExclusive">Int32 fOpenExclusive</param>
		/// <param name="fNeverPrompt">Int32 fNeverPrompt</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void Open(string bstrSrc, string bstrConnect, string bstrTable, Int32 fOpenExclusive, Int32 fNeverPrompt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrSrc, bstrConnect, bstrTable, fOpenExclusive, fNeverPrompt);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="SortField1">string SortField1</param>
		/// <param name="SortAscending1">bool SortAscending1</param>
		/// <param name="SortField2">string SortField2</param>
		/// <param name="SortAscending2">bool SortAscending2</param>
		/// <param name="SortField3">string SortField3</param>
		/// <param name="SortAscending3">bool SortAscending3</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void SetSortOrder(string sortField1, bool sortAscending1, string sortField2, bool sortAscending2, string sortField3, bool sortAscending3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sortField1, sortAscending1, sortField2, sortAscending2, sortField3, sortAscending3);
			Invoker.Method(this, "SetSortOrder", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void ApplyFilter()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyFilter", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}