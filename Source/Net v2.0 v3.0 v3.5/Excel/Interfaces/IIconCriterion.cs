//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IIconCriterion SupportByLibrary Excel, 12,14
	///</summary>
	[SupportByLibrary("Excel", 12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IIconCriterion : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IIconCriterion);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IIconCriterion(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IIconCriterion(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IIconCriterion(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IIconCriterion() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IIconCriterion(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlConditionValueTypes Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlConditionValueTypes)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 Operator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Operator", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Operator", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public NetOffice.ExcelApi.Enums.XlIcon Icon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Icon", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlIcon)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Icon", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}