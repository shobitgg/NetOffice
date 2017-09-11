﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.AccessApi.Events
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersion("Access", 9,10,11,12,14,15,16)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("BC9E4352-F037-11CD-8701-00AA003F0F07"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _CustomControlEvents
	{
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2076)]
		void Updated([In] [Out] ref object code);

		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2019)]
		void Enter();

		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2075)]
		void Exit([In] [Out] ref object cancel);

		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2073)]
		void GotFocus();

		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2074)]
		void LostFocus();
	}

    #endregion

    #region SinkHelper

    [InternalEntity(InternalEntityKind.SinkHelper)]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class _CustomControlEvents_SinkHelper : SinkHelper, _CustomControlEvents
	{
		#region Static
		
		public static readonly string Id = "BC9E4352-F037-11CD-8701-00AA003F0F07";
		
		#endregion
		
		#region Ctor

		public _CustomControlEvents_SinkHelper(ICOMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			SetupEventBinding(connectPoint);
		}
		
		#endregion
			
		#region _CustomControlEvents
		
		public void Updated([In] [Out] ref object code)
        {
            if (!Validate("Updated"))
            {
                Invoker.ReleaseParamsArray(code);
                return;
            }

			object[] paramsArray = new object[1];
			paramsArray.SetValue(code, 0);
			EventBinding.RaiseCustomEvent("Updated", ref paramsArray);

			code = ToInt16(paramsArray[0]);
		}

		public void Enter()
        {
            if (!Validate("Enter"))
            {
                return;
            }

			object[] paramsArray = new object[0];
			EventBinding.RaiseCustomEvent("Enter", ref paramsArray);
		}

		public void Exit([In] [Out] ref object cancel)
        {
            if (!Validate("Exit"))
            {
                Invoker.ReleaseParamsArray(cancel);
                return;
            }

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			EventBinding.RaiseCustomEvent("Exit", ref paramsArray);

			cancel = ToInt16(paramsArray[0]);
        }

		public void GotFocus()
        {
            if (!Validate("GotFocus"))
            {
                return;
            }

			object[] paramsArray = new object[0];
			EventBinding.RaiseCustomEvent("GotFocus", ref paramsArray);
		}

		public void LostFocus()
        {
            if (!Validate("LostFocus"))
            {
                return;
            }

			object[] paramsArray = new object[0];
			EventBinding.RaiseCustomEvent("LostFocus", ref paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}