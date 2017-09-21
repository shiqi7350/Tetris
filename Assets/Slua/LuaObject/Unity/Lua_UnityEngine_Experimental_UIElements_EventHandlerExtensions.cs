using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_EventHandlerExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TakeCapture_s(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.IEventHandler a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.UIElements.EventHandlerExtensions.TakeCapture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasCapture_s(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.IEventHandler a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.UIElements.EventHandlerExtensions.HasCapture(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReleaseCapture_s(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.IEventHandler a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.UIElements.EventHandlerExtensions.ReleaseCapture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveCapture_s(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.IEventHandler a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.UIElements.EventHandlerExtensions.RemoveCapture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Schedule_s(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.IEventHandler a1;
			checkType(l,1,out a1);
			System.Action<UnityEngine.Experimental.UIElements.TimerState> a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			var ret=UnityEngine.Experimental.UIElements.EventHandlerExtensions.Schedule(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Unschedule_s(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.IEventHandler a1;
			checkType(l,1,out a1);
			System.Action<UnityEngine.Experimental.UIElements.TimerState> a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			UnityEngine.Experimental.UIElements.EventHandlerExtensions.Unschedule(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.EventHandlerExtensions");
		addMember(l,TakeCapture_s);
		addMember(l,HasCapture_s);
		addMember(l,ReleaseCapture_s);
		addMember(l,RemoveCapture_s);
		addMember(l,Schedule_s);
		addMember(l,Unschedule_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.UIElements.EventHandlerExtensions));
	}
}
