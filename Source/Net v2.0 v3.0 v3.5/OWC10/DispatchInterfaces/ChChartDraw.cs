//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface ChChartDraw SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChChartDraw : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ChChartDraw);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChChartDraw(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChChartDraw(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChChartDraw(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChChartDraw() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChChartDraw(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChInterior Interior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Interior", paramsArray);
				NetOffice.OWC10Api.ChInterior newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChInterior.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChInterior;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChBorder Border
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Border", paramsArray);
				NetOffice.OWC10Api.ChBorder newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChBorder.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChBorder;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChFont Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				NetOffice.OWC10Api.ChFont newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChFont.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChFont;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChLine Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				NetOffice.OWC10Api.ChLine newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChLine.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartDrawModesEnum DrawType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DrawType", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartDrawModesEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 hDC
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hDC", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="id">Int32 id</param>
		[SupportByLibrary("OWC10", 1)]
		public void BeginObject(Int32 id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			Invoker.Method(this, "BeginObject", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void EndObject()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "EndObject", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="x0">Int32 x0</param>
		/// <param name="y0">Int32 y0</param>
		/// <param name="x1">Int32 x1</param>
		/// <param name="y1">Int32 y1</param>
		[SupportByLibrary("OWC10", 1)]
		public void DrawLine(Int32 x0, Int32 y0, Int32 x1, Int32 y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x0, y0, x1, y1);
			Invoker.Method(this, "DrawLine", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Left">Int32 Left</param>
		/// <param name="Top">Int32 Top</param>
		/// <param name="Right">Int32 Right</param>
		/// <param name="Bottom">Int32 Bottom</param>
		[SupportByLibrary("OWC10", 1)]
		public void DrawRectangle(Int32 left, Int32 top, Int32 right, Int32 bottom)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, right, bottom);
			Invoker.Method(this, "DrawRectangle", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Left">Int32 Left</param>
		/// <param name="Top">Int32 Top</param>
		/// <param name="Right">Int32 Right</param>
		/// <param name="Bottom">Int32 Bottom</param>
		[SupportByLibrary("OWC10", 1)]
		public void DrawEllipse(Int32 left, Int32 top, Int32 right, Int32 bottom)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, right, bottom);
			Invoker.Method(this, "DrawEllipse", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="bstrText">string bstrText</param>
		/// <param name="Left">Int32 Left</param>
		/// <param name="Top">Int32 Top</param>
		[SupportByLibrary("OWC10", 1)]
		public void DrawText(string bstrText, Int32 left, Int32 top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrText, left, top);
			Invoker.Method(this, "DrawText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="xValues">object xValues</param>
		/// <param name="yValues">object yValues</param>
		[SupportByLibrary("OWC10", 1)]
		public void DrawPolyLine(object xValues, object yValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xValues, yValues);
			Invoker.Method(this, "DrawPolyLine", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="xValues">object xValues</param>
		/// <param name="yValues">object yValues</param>
		[SupportByLibrary("OWC10", 1)]
		public void DrawPolygon(object xValues, object yValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xValues, yValues);
			Invoker.Method(this, "DrawPolygon", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Text">string Text</param>
		[SupportByLibrary("OWC10", 1)]
		public object TextWidth(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			object returnItem = Invoker.MethodReturn(this, "TextWidth", paramsArray);
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

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Text">string Text</param>
		[SupportByLibrary("OWC10", 1)]
		public object TextHeight(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			object returnItem = Invoker.MethodReturn(this, "TextHeight", paramsArray);
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

		#endregion
		#pragma warning restore
	}
}