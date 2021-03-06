﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OfficeApi
{
    /// <summary>
	/// DispatchInterface CustomTaskPaneEvents 
	/// SupportByVersion Office, 12,14,15,16
	/// </summary>
	[SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
	[TypeId("8A64A872-FC6B-4D4A-926E-3A3689562C1C")]
    public interface CustomTaskPaneEvents  : ICOMObject
    {
        #region Methods

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="customTaskPaneInst">NetOffice.OfficeApi._CustomTaskPane customTaskPaneInst</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        void VisibleStateChange(NetOffice.OfficeApi._CustomTaskPane customTaskPaneInst);

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="customTaskPaneInst">NetOffice.OfficeApi._CustomTaskPane customTaskPaneInst</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        void DockPositionStateChange(NetOffice.OfficeApi._CustomTaskPane customTaskPaneInst);

        #endregion
    }
}
