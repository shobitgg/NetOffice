//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface ISVGPathSegList SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ISVGPathSegList : COMObject
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
                    _type = typeof(ISVGPathSegList);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGPathSegList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGPathSegList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGPathSegList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGPathSegList() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGPathSegList(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 numberOfItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "numberOfItems", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "numberOfItems", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public void clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGPathSeg newItem</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPathSeg initialize(LateBindingApi.MSHTMLApi.ISVGPathSeg newItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem);
			object returnItem = Invoker.MethodReturn(this, "initialize", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPathSeg newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPathSeg;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPathSeg getItem(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "getItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPathSeg newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPathSeg;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGPathSeg newItem</param>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPathSeg insertItemBefore(LateBindingApi.MSHTMLApi.ISVGPathSeg newItem, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem, index);
			object returnItem = Invoker.MethodReturn(this, "insertItemBefore", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPathSeg newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPathSeg;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGPathSeg newItem</param>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPathSeg replaceItem(LateBindingApi.MSHTMLApi.ISVGPathSeg newItem, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem, index);
			object returnItem = Invoker.MethodReturn(this, "replaceItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPathSeg newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPathSeg;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPathSeg removeItem(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "removeItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPathSeg newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPathSeg;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGPathSeg newItem</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPathSeg appendItem(LateBindingApi.MSHTMLApi.ISVGPathSeg newItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem);
			object returnItem = Invoker.MethodReturn(this, "appendItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPathSeg newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPathSeg;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}