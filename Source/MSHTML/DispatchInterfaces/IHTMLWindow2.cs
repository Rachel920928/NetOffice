﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSHTMLApi
{
	/// <summary>
	/// DispatchInterface IHTMLWindow2 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface)]
	[TypeId("332C4427-26CB-11D0-B483-00C04FD90119")]
	public interface IHTMLWindow2 : IHTMLFramesCollection2
	{
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		NetOffice.MSHTMLApi.IHTMLFramesCollection2 frames { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		string defaultStatus { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		string status { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		NetOffice.MSHTMLApi.IHTMLImageElementFactory Image { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLLocation location { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IOmHistory history { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object opener { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IOmNavigator navigator { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		string name { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 parent { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 self { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 top { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 window { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onfocus { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onblur { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onload { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onbeforeunload { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onunload { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onhelp { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onerror { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onresize { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object onscroll { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLDocument2 document { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLEventObj get_event();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSHTML", 4), ProxyResult]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		object _newEnum { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		NetOffice.MSHTMLApi.IHTMLScreen screen { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		NetOffice.MSHTMLApi.IHTMLOptionElementFactory Option { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		bool closed { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IOmNavigator clientInformation { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		object offscreenBuffering { get; set; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSHTML", 4), ProxyResult]
		object external { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersion("MSHTML", 4)]
		Int32 setTimeout(string expression, Int32 msec, object language);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		Int32 setTimeout(string expression, Int32 msec);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByVersion("MSHTML", 4)]
		void clearTimeout(Int32 timerID);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		[SupportByVersion("MSHTML", 4)]
		void alert(object message);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		void alert();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		[SupportByVersion("MSHTML", 4)]
		bool confirm(object message);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		bool confirm();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		/// <param name="defstr">optional string defstr = undefined</param>
		[SupportByVersion("MSHTML", 4)]
		object prompt(object message, object defstr);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		object prompt();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		object prompt(object message);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		void close();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		/// <param name="features">optional string features = </param>
		/// <param name="replace">optional bool replace = false</param>
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name, object features, object replace);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 open();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 open(object url);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		/// <param name="features">optional string features = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name, object features);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">string url</param>
		[SupportByVersion("MSHTML", 4)]
		void navigate(string url);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		/// <param name="varOptions">optional object varOptions</param>
		[SupportByVersion("MSHTML", 4)]
		object showModalDialog(string dialog, object varArgIn, object varOptions);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		object showModalDialog(string dialog);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		object showModalDialog(string dialog, object varArgIn);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		/// <param name="helpArg">optional object helpArg</param>
		/// <param name="features">optional string features = </param>
		[SupportByVersion("MSHTML", 4)]
		void showHelp(string helpURL, object helpArg, object features);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		void showHelp(string helpURL);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		/// <param name="helpArg">optional object helpArg</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		void showHelp(string helpURL, object helpArg);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		void focus();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		void blur();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		void scroll(Int32 x, Int32 y);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersion("MSHTML", 4)]
		Int32 setInterval(string expression, Int32 msec, object language);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		Int32 setInterval(string expression, Int32 msec);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByVersion("MSHTML", 4)]
		void clearInterval(Int32 timerID);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="code">string code</param>
		/// <param name="language">optional string language = jScript</param>
		[SupportByVersion("MSHTML", 4)]
		object execScript(string code, object language);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="code">string code</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		object execScript(string code);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		string toString();

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		void scrollBy(Int32 x, Int32 y);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		void scrollTo(Int32 x, Int32 y);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		void moveTo(Int32 x, Int32 y);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		void moveBy(Int32 x, Int32 y);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		void resizeTo(Int32 x, Int32 y);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		void resizeBy(Int32 x, Int32 y);

		#endregion
	}
}
