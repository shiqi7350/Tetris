using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_ScheduleBuilder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScheduleBuilder o;
			o=new UnityEngine.Experimental.UIElements.ScheduleBuilder();
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
	static public int StartingIn(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScheduleBuilder self;
			checkValueType(l,1,out self);
			System.Int64 a1;
			checkType(l,2,out a1);
			var ret=self.StartingIn(a1);
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
	static public int Every(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScheduleBuilder self;
			checkValueType(l,1,out self);
			System.Int64 a1;
			checkType(l,2,out a1);
			var ret=self.Every(a1);
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
	static public int Until(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScheduleBuilder self;
			checkValueType(l,1,out self);
			System.Func<System.Boolean> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			var ret=self.Until(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.ScheduleBuilder");
		addMember(l,StartingIn);
		addMember(l,Every);
		addMember(l,Until);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.ScheduleBuilder),typeof(System.ValueType));
	}
}
