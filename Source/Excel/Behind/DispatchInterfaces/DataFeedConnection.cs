﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface DataFeedConnection 
	/// SupportByVersion Excel, 15, 16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228272.aspx </remarks>
	[SupportByVersion("Excel", 15, 16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class DataFeedConnection : COMObject, NetOffice.ExcelApi.DataFeedConnection
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.ExcelApi.DataFeedConnection);
                return _contractType;
            }
        }
        private static Type _contractType;


        /// <summary>
        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DataFeedConnection);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public DataFeedConnection() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228543.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228828.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231091.aspx </remarks>
		[SupportByVersion("Excel", 15, 16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230851.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool AlwaysUseConnectionFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AlwaysUseConnectionFile");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AlwaysUseConnectionFile", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230308.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual object CommandText
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CommandText");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "CommandText", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228165.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlCmdType CommandType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCmdType>(this, "CommandType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "CommandType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj229535.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual object Connection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Connection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Connection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228534.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool EnableRefresh
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "EnableRefresh");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnableRefresh", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231324.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual DateTime RefreshDate
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDateTimePropertyGet(this, "RefreshDate");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231420.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool Refreshing
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "Refreshing");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj229272.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool RefreshOnFileOpen
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "RefreshOnFileOpen");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshOnFileOpen", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj229701.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual Int32 RefreshPeriod
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "RefreshPeriod");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshPeriod", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230500.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool SavePassword
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "SavePassword");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SavePassword", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227512.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlCredentialsMethod ServerCredentialsMethod
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCredentialsMethod>(this, "ServerCredentialsMethod");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "ServerCredentialsMethod", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj232083.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual string SourceConnectionFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceConnectionFile");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SourceConnectionFile", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231746.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual string SourceDataFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceDataFile");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SourceDataFile", value);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227329.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual void CancelRefresh()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "CancelRefresh");
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228352.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual void Refresh()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Refresh");
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231908.aspx </remarks>
		/// <param name="oDCFileName">string oDCFileName</param>
		/// <param name="description">optional object description</param>
		/// <param name="keywords">optional object keywords</param>
		[SupportByVersion("Excel", 15, 16)]
		public virtual void SaveAsODC(string oDCFileName, object description, object keywords)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SaveAsODC", oDCFileName, description, keywords);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231908.aspx </remarks>
		/// <param name="oDCFileName">string oDCFileName</param>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public virtual void SaveAsODC(string oDCFileName)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SaveAsODC", oDCFileName);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231908.aspx </remarks>
		/// <param name="oDCFileName">string oDCFileName</param>
		/// <param name="description">optional object description</param>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public virtual void SaveAsODC(string oDCFileName, object description)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SaveAsODC", oDCFileName, description);
		}

		#endregion

		#pragma warning restore
	}
}


