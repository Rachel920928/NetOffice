//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.MSHTMLApi
{
	///<summary>
	/// Interface IElementBehaviorSiteOM SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IElementBehaviorSiteOM : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IElementBehaviorSiteOM);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementBehaviorSiteOM(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementBehaviorSiteOM(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementBehaviorSiteOM(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementBehaviorSiteOM() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementBehaviorSiteOM(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pchEvent">string pchEvent</param>
		/// <param name="lFlags">Int32 lFlags</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 RegisterEvent(string pchEvent, Int32 lFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pchEvent, lFlags);
			object returnItem = Invoker.MethodReturn(this, "RegisterEvent", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pchEvent">string pchEvent</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 GetEventCookie(string pchEvent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pchEvent);
			object returnItem = Invoker.MethodReturn(this, "GetEventCookie", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="lCookie">Int32 lCookie</param>
		/// <param name="pEventObject">NetOffice.MSHTMLApi.IHTMLEventObj pEventObject</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 FireEvent(Int32 lCookie, NetOffice.MSHTMLApi.IHTMLEventObj pEventObject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lCookie, pEventObject);
			object returnItem = Invoker.MethodReturn(this, "FireEvent", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLEventObj CreateEventObject()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateEventObject", paramsArray);
			NetOffice.MSHTMLApi.IHTMLEventObj newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLEventObj;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pchName">string pchName</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 RegisterName(string pchName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pchName);
			object returnItem = Invoker.MethodReturn(this, "RegisterName", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pchUrn">string pchUrn</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 RegisterUrn(string pchUrn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pchUrn);
			object returnItem = Invoker.MethodReturn(this, "RegisterUrn", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}