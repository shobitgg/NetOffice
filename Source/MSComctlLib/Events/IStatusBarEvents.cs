﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.MSComctlLibApi.Events
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersion("MSComctlLib", 6)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("8E3867A2-8586-11D1-B16A-00C0F0283628"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface IStatusBarEvents
	{
		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1)]
		void PanelClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2)]
		void PanelDblClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-605)]
		void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-606)]
		void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-607)]
		void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-600)]
		void Click();

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-601)]
		void DblClick();

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1550)]
		void OLEStartDrag([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object allowedEffects);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1551)]
		void OLEGiveFeedback([In] [Out] ref object effect, [In] [Out] ref object defaultCursors);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1552)]
		void OLESetData([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object dataFormat);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1553)]
		void OLECompleteDrag([In] [Out] ref object effect);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1554)]
		void OLEDragOver([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y, [In] [Out] ref object state);

		[SupportByVersion("MSComctlLib", 6)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1555)]
		void OLEDragDrop([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);
	}

    #endregion

    #region SinkHelper

    [InternalEntity(InternalEntityKind.SinkHelper)]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class IStatusBarEvents_SinkHelper : SinkHelper, IStatusBarEvents
	{
		#region Static
		
		public static readonly string Id = "8E3867A2-8586-11D1-B16A-00C0F0283628";
		
		#endregion

		#region Construction

		public IStatusBarEvents_SinkHelper(ICOMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			SetupEventBinding(connectPoint);
		}
		
		#endregion

		#region IStatusBarEvents
		
		public void PanelClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel)
        {
            if (!Validate("PanelClick"))
            {
                Invoker.ReleaseParamsArray(panel);
                return;
            }

			NetOffice.MSComctlLibApi.Panel newPanel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSComctlLibApi.Panel>(EventClass, panel, NetOffice.MSComctlLibApi.Panel.LateBindingApiWrapperType);
			object[] paramsArray = new object[1];
			paramsArray[0] = newPanel;
			EventBinding.RaiseCustomEvent("PanelClick", ref paramsArray);
		}

		public void PanelDblClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel)
        {
            if (!Validate("PanelDblClick"))
            {
                Invoker.ReleaseParamsArray(panel);
                return;
            }

            NetOffice.MSComctlLibApi.Panel newPanel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSComctlLibApi.Panel>(EventClass, panel, NetOffice.MSComctlLibApi.Panel.LateBindingApiWrapperType);
            object[] paramsArray = new object[1];
			paramsArray[0] = newPanel;
			EventBinding.RaiseCustomEvent("PanelDblClick", ref paramsArray);
		}

		public void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y)
		{
            if (!Validate("MouseDown"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

			Int16 newButton = Convert.ToInt16(button);
			Int16 newShift = Convert.ToInt16(shift);
			Int32 newx = Convert.ToInt32(x);
			Int32 newy = Convert.ToInt32(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			EventBinding.RaiseCustomEvent("MouseDown", ref paramsArray);
		}

		public void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y)
		{
            if (!Validate("MouseDown"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

			Int16 newButton = Convert.ToInt16(button);
			Int16 newShift = Convert.ToInt16(shift);
			Int32 newx = Convert.ToInt32(x);
			Int32 newy = Convert.ToInt32(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			EventBinding.RaiseCustomEvent("MouseMove", ref paramsArray);
		}

		public void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y)
        {
            if (!Validate("MouseUp"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

			Int16 newButton = Convert.ToInt16(button);
			Int16 newShift = Convert.ToInt16(shift);
			Int32 newx = Convert.ToInt32(x);
			Int32 newy = Convert.ToInt32(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			EventBinding.RaiseCustomEvent("MouseUp", ref paramsArray);
		}

		public void Click()
		{
            if (!Validate("Click"))
            {  
                return;
            }

            object[] paramsArray = new object[0];
			EventBinding.RaiseCustomEvent("Click", ref paramsArray);
		}

		public void DblClick()
		{
            if (!Validate("DblClick"))
            {
                return;
            }

            object[] paramsArray = new object[0];
			EventBinding.RaiseCustomEvent("DblClick", ref paramsArray);
		}

		public void OLEStartDrag([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object allowedEffects)
		{
            if (!Validate("OLEStartDrag"))
            {
                Invoker.ReleaseParamsArray(data, allowedEffects);
                return;
            }

            NetOffice.MSComctlLibApi.DataObject newData = new NetOffice.MSComctlLibApi.DataObject(EventClass, data);
            (newData as ICOMProxyShareProvider).GetProxyShare().Acquire();

            object[] paramsArray = new object[2];
			paramsArray.SetValue(newData, 0);
			paramsArray.SetValue(allowedEffects, 1);
			EventBinding.RaiseCustomEvent("OLEStartDrag", ref paramsArray);

            data = newData.UnderlyingObject;
            allowedEffects = ToInt32(paramsArray[1]);

            (newData as ICOMProxyShareProvider).GetProxyShare().Release();
        }

		public void OLEGiveFeedback([In] [Out] ref object effect, [In] [Out] ref object defaultCursors)
		{
            if (!Validate("OLEGiveFeedback"))
            {
                Invoker.ReleaseParamsArray(effect, defaultCursors);
                return;
            }

			object[] paramsArray = new object[2];
			paramsArray.SetValue(effect, 0);
			paramsArray.SetValue(defaultCursors, 1);
			EventBinding.RaiseCustomEvent("OLEGiveFeedback", ref paramsArray);

			effect = ToInt32(paramsArray[0]);
			defaultCursors = ToBoolean(paramsArray[1]);
		}

		public void OLESetData([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object dataFormat)
        {
            if (!Validate("OLEGiveFeedback"))
            {
                Invoker.ReleaseParamsArray(data, dataFormat);
                return;
            }

            NetOffice.MSComctlLibApi.DataObject newData = new NetOffice.MSComctlLibApi.DataObject(EventClass, data);
            (newData as ICOMProxyShareProvider).GetProxyShare().Acquire();

            object[] paramsArray = new object[2];
			paramsArray.SetValue(newData, 0);
			paramsArray.SetValue(dataFormat, 1);
			EventBinding.RaiseCustomEvent("OLESetData", ref paramsArray);

            data = newData.UnderlyingObject;
            dataFormat = ToInt32(paramsArray[1]);

            (newData as ICOMProxyShareProvider).GetProxyShare().Release();
        }

		public void OLECompleteDrag([In] [Out] ref object effect)
        {
            if (!Validate("OLECompleteDrag"))
            {
                Invoker.ReleaseParamsArray(effect);
                return;
            }

			object[] paramsArray = new object[1];
			paramsArray.SetValue(effect, 0);
			EventBinding.RaiseCustomEvent("OLECompleteDrag", ref paramsArray);

			effect = ToInt32(paramsArray[0]);
        }

		public void OLEDragOver([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y, [In] [Out] ref object state)
        {
            if (!Validate("OLEDragOver"))
            {
                Invoker.ReleaseParamsArray(data, effect, button, shift, x, y, state);
                return;
            }

            NetOffice.MSComctlLibApi.DataObject newData = new NetOffice.MSComctlLibApi.DataObject(EventClass, data);
            (newData as ICOMProxyShareProvider).GetProxyShare().Acquire();

            object[] paramsArray = new object[7];
			paramsArray.SetValue(newData, 0);
			paramsArray.SetValue(effect, 1);
			paramsArray.SetValue(button, 2);
			paramsArray.SetValue(shift, 3);
			paramsArray.SetValue(x, 4);
			paramsArray.SetValue(y, 5);
			paramsArray.SetValue(state, 6);
			EventBinding.RaiseCustomEvent("OLEDragOver", ref paramsArray);

            data = newData.UnderlyingObject;
            effect = ToInt16(paramsArray[1]);
            button = ToInt16(paramsArray[2]);
            shift = ToInt16(paramsArray[3]);
            x = ToSingle(paramsArray[4]);
			y = ToSingle(paramsArray[5]);
			state = ToInt16(paramsArray[6]);

            (newData as ICOMProxyShareProvider).GetProxyShare().Release();
        }

		public void OLEDragDrop([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y)
		{
            if (!Validate("OLEDragDrop"))
            {
                Invoker.ReleaseParamsArray(data, effect, button, shift, x, y);
                return;
            }

            NetOffice.MSComctlLibApi.DataObject newData = new NetOffice.MSComctlLibApi.DataObject(EventClass, data);
            (newData as ICOMProxyShareProvider).GetProxyShare().Acquire();

            object[] paramsArray = new object[6];
			paramsArray.SetValue(newData, 0);
			paramsArray.SetValue(effect, 1);
			paramsArray.SetValue(button, 2);
			paramsArray.SetValue(shift, 3);
			paramsArray.SetValue(x, 4);
			paramsArray.SetValue(y, 5);
			EventBinding.RaiseCustomEvent("OLEDragDrop", ref paramsArray);

            data = newData.UnderlyingObject;
            effect = ToInt16(paramsArray[1]);
            button = ToInt16(paramsArray[2]);
            shift = ToInt16(paramsArray[3]);
            x = ToSingle(paramsArray[4]);
            y = ToSingle(paramsArray[5]);

            (newData as ICOMProxyShareProvider).GetProxyShare().Release();
        }

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}