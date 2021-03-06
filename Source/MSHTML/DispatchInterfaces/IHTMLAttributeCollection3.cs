﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSHTMLApi
{
	/// <summary>
	/// DispatchInterface IHTMLAttributeCollection3 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface)]
	[TypeId("30510469-98B5-11CF-BB82-00AA00BDCE0B")]
	public interface IHTMLAttributeCollection3 : IHTMLAttributeCollection2
	{
		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="pNodeIn">NetOffice.MSHTMLApi.IHTMLDOMAttribute pNodeIn</param>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		new NetOffice.MSHTMLApi.IHTMLDOMAttribute setNamedItem(NetOffice.MSHTMLApi.IHTMLDOMAttribute pNodeIn);

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		NetOffice.MSHTMLApi.IHTMLDOMAttribute item(Int32 index);

		#endregion
	}
}
