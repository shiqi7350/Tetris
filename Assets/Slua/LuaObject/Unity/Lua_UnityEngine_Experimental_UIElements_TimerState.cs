using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_TimerState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TimerState o;
			o=new UnityEngine.Experimental.UIElements.TimerState();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_start(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TimerState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.start);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_start(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TimerState self;
			checkValueType(l,1,out self);
			System.Int64 v;
			checkType(l,2,out v);
			self.start=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_now(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TimerState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.now);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_now(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TimerState self;
			checkValueType(l,1,out self);
			System.Int64 v;
			checkType(l,2,out v);
			self.now=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deltaTime(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TimerState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.deltaTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.TimerState");
		addMember(l,"start",get_start,set_start,true);
		addMember(l,"now",get_now,set_now,true);
		addMember(l,"deltaTime",get_deltaTime,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.TimerState),typeof(System.ValueType));
	}
}
