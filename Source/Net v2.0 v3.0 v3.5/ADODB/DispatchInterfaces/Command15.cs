//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Command15 SupportByLibrary ADODB, 2.1,2.5
	///</summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Command15 : _ADO
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Command15);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Connection ActiveConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveConnection", paramsArray);
				NetOffice.ADODBApi._Connection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Connection;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActiveConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string CommandText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 CommandTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandTimeout", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public bool Prepared
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Prepared", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Prepared", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Parameters Parameters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parameters", paramsArray);
				NetOffice.ADODBApi.Parameters newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ADODBApi.Parameters.LateBindingApiWrapperType) as NetOffice.ADODBApi.Parameters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.CommandTypeEnum CommandType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandType", paramsArray);
				return (NetOffice.ADODBApi.Enums.CommandTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="RecordsAffected">object RecordsAffected</param>
		/// <param name="Parameters">object Parameters</param>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset Execute(object recordsAffected, object parameters, Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recordsAffected, parameters, options);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="Direction">NetOffice.ADODBApi.Enums.ParameterDirectionEnum Direction</param>
		/// <param name="Size">Int32 Size</param>
		/// <param name="Value">optional object Value</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Parameter CreateParameter(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, NetOffice.ADODBApi.Enums.ParameterDirectionEnum direction, Int32 size, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, direction, size, value);
			object returnItem = Invoker.MethodReturn(this, "CreateParameter", paramsArray);
			NetOffice.ADODBApi._Parameter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Parameter;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="Direction">NetOffice.ADODBApi.Enums.ParameterDirectionEnum Direction</param>
		/// <param name="Size">Int32 Size</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Parameter CreateParameter(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, NetOffice.ADODBApi.Enums.ParameterDirectionEnum direction, Int32 size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, direction, size);
			object returnItem = Invoker.MethodReturn(this, "CreateParameter", paramsArray);
			NetOffice.ADODBApi._Parameter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Parameter;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}