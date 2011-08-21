//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface _Slide SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Slide : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_Slide);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Slide(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Slide(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Slide(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Slide() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Slide(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shapes Shapes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shapes", paramsArray);
				NetOffice.PowerPointApi.Shapes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Shapes.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shapes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.HeadersFooters HeadersFooters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeadersFooters", paramsArray);
				NetOffice.PowerPointApi.HeadersFooters newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.HeadersFooters.LateBindingApiWrapperType) as NetOffice.PowerPointApi.HeadersFooters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideShowTransition SlideShowTransition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideShowTransition", paramsArray);
				NetOffice.PowerPointApi.SlideShowTransition newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.SlideShowTransition.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideShowTransition;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ColorScheme ColorScheme
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorScheme", paramsArray);
				NetOffice.PowerPointApi.ColorScheme newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ColorScheme.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ColorScheme;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColorScheme", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange Background
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Background", paramsArray);
				NetOffice.PowerPointApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 SlideID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideID", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 PrintSteps
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintSteps", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.PpSlideLayout Layout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Layout", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpSlideLayout)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Layout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Tags Tags
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tags", paramsArray);
				NetOffice.PowerPointApi.Tags newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Tags.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Tags;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 SlideIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideIndex", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 SlideNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideNumber", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState DisplayMasterShapes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayMasterShapes", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayMasterShapes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState FollowMasterBackground
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FollowMasterBackground", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FollowMasterBackground", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideRange NotesPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NotesPage", paramsArray);
				NetOffice.PowerPointApi.SlideRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.SlideRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideRange;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi._Master Master
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Master", paramsArray);
				NetOffice.PowerPointApi._Master newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi._Master;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Hyperlinks Hyperlinks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hyperlinks", paramsArray);
				NetOffice.PowerPointApi.Hyperlinks newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Hyperlinks.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Hyperlinks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Scripts Scripts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Scripts", paramsArray);
				NetOffice.OfficeApi.Scripts newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Scripts.LateBindingApiWrapperType) as NetOffice.OfficeApi.Scripts;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Comments Comments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comments", paramsArray);
				NetOffice.PowerPointApi.Comments newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Comments.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Comments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Design Design
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Design", paramsArray);
				NetOffice.PowerPointApi.Design newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Design.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Design;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Design", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.TimeLine TimeLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TimeLine", paramsArray);
				NetOffice.PowerPointApi.TimeLine newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.TimeLine.LateBindingApiWrapperType) as NetOffice.PowerPointApi.TimeLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Int32 SectionNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SectionNumber", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.CustomLayout CustomLayout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomLayout", paramsArray);
				NetOffice.PowerPointApi.CustomLayout newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.CustomLayout.LateBindingApiWrapperType) as NetOffice.PowerPointApi.CustomLayout;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CustomLayout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.ThemeColorScheme ThemeColorScheme
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThemeColorScheme", paramsArray);
				NetOffice.OfficeApi.ThemeColorScheme newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ThemeColorScheme.LateBindingApiWrapperType) as NetOffice.OfficeApi.ThemeColorScheme;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex BackgroundStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackgroundStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackgroundStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.CustomerData CustomerData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomerData", paramsArray);
				NetOffice.PowerPointApi.CustomerData newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.CustomerData.LateBindingApiWrapperType) as NetOffice.PowerPointApi.CustomerData;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public Int32 sectionIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "sectionIndex", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasNotesPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasNotesPage", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideRange Duplicate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Duplicate", paramsArray);
			NetOffice.PowerPointApi.SlideRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.SlideRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="FilterName">string FilterName</param>
		/// <param name="ScaleWidth">Int32 ScaleWidth</param>
		/// <param name="ScaleHeight">Int32 ScaleHeight</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Export(string fileName, string filterName, Int32 scaleWidth, Int32 scaleHeight)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, filterName, scaleWidth, scaleHeight);
			Invoker.Method(this, "Export", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="toPos">Int32 toPos</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public void MoveTo(Int32 toPos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(toPos);
			Invoker.Method(this, "MoveTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public void ApplyTemplate(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "ApplyTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="themeName">string themeName</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void ApplyTheme(string themeName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(themeName);
			Invoker.Method(this, "ApplyTheme", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="themeColorSchemeName">string themeColorSchemeName</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void ApplyThemeColorScheme(string themeColorSchemeName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(themeColorSchemeName);
			Invoker.Method(this, "ApplyThemeColorScheme", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="SlideLibraryUrl">string SlideLibraryUrl</param>
		/// <param name="Overwrite">bool Overwrite</param>
		/// <param name="UseSlideOrder">bool UseSlideOrder</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void PublishSlides(string slideLibraryUrl, bool overwrite, bool useSlideOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(slideLibraryUrl, overwrite, useSlideOrder);
			Invoker.Method(this, "PublishSlides", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		/// <param name="toSection">Int32 toSection</param>
		[SupportByLibrary("PowerPoint", 14)]
		public void MoveToSectionStart(Int32 toSection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(toSection);
			Invoker.Method(this, "MoveToSectionStart", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}