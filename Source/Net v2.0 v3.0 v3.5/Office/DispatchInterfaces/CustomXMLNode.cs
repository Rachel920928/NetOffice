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
	/// DispatchInterface CustomXMLNode SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CustomXMLNode : _IMsoDispObj
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(CustomXMLNode);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNodes Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				NetOffice.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string BaseName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNodes ChildNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildNodes", paramsArray);
				NetOffice.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode FirstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstChild", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode LastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastChild", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string NamespaceURI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceURI", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode NextSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NextSibling", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string NodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeValue", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public COMObject OwnerDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerDocument", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLPart OwnerPart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerPart", paramsArray);
				NetOffice.OfficeApi.CustomXMLPart newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLPart.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPart;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode PreviousSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreviousSibling", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode ParentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentNode", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string XPath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XPath", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		/// <param name="NodeType">NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType</param>
		/// <param name="NodeValue">string NodeValue</param>
		[SupportByLibrary("Office", 12,14)]
		public void AppendChildNode(string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType, nodeValue);
			Invoker.Method(this, "AppendChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XML">string XML</param>
		[SupportByLibrary("Office", 12,14)]
		public void AppendChildSubtree(string xML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML);
			Invoker.Method(this, "AppendChildSubtree", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool HasChildNodes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "HasChildNodes", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		/// <param name="NodeType">NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType</param>
		/// <param name="NodeValue">string NodeValue</param>
		/// <param name="NextSibling">NetOffice.OfficeApi.CustomXMLNode NextSibling</param>
		[SupportByLibrary("Office", 12,14)]
		public void InsertNodeBefore(string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue, NetOffice.OfficeApi.CustomXMLNode nextSibling)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType, nodeValue, nextSibling);
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XML">string XML</param>
		/// <param name="NextSibling">NetOffice.OfficeApi.CustomXMLNode NextSibling</param>
		[SupportByLibrary("Office", 12,14)]
		public void InsertSubtreeBefore(string xML, NetOffice.OfficeApi.CustomXMLNode nextSibling)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML, nextSibling);
			Invoker.Method(this, "InsertSubtreeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Child">NetOffice.OfficeApi.CustomXMLNode Child</param>
		[SupportByLibrary("Office", 12,14)]
		public void RemoveChild(NetOffice.OfficeApi.CustomXMLNode child)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(child);
			Invoker.Method(this, "RemoveChild", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="OldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		/// <param name="Name">string Name</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		/// <param name="NodeType">NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType</param>
		/// <param name="NodeValue">string NodeValue</param>
		[SupportByLibrary("Office", 12,14)]
		public void ReplaceChildNode(NetOffice.OfficeApi.CustomXMLNode oldNode, string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldNode, name, namespaceURI, nodeType, nodeValue);
			Invoker.Method(this, "ReplaceChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XML">string XML</param>
		/// <param name="OldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		[SupportByLibrary("Office", 12,14)]
		public void ReplaceChildSubtree(string xML, NetOffice.OfficeApi.CustomXMLNode oldNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML, oldNode);
			Invoker.Method(this, "ReplaceChildSubtree", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XPath">string XPath</param>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNodes SelectNodes(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XPath">string XPath</param>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode SelectSingleNode(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}