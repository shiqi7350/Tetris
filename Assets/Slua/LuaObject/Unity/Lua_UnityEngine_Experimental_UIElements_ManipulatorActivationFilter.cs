using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_ManipulatorActivationFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ManipulatorActivationFilter o;
			o=new UnityEngine.Experimental.UIElements.ManipulatorActivationFilter();
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
	static public int Matches(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ManipulatorActivationFilter self;
			checkValueType(l,1,out self);
			UnityEngine.Event a1;
			checkType(l,2,out a1);
			var ret=self.Matches(a1);
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
	static public int get_button(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ManipulatorActivationFilter self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.button);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_button(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ManipulatorActivationFilter self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.UIElements.MouseButton v;
			checkEnum(l,2,out v);
			self.button=v;
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
	static public int get_modifiers(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ManipulatorActivationFilter self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.modifiers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_modifiers(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ManipulatorActivationFilter self;
			checkValueType(l,1,out self);
			UnityEngine.EventModifiers v;
			checkEnum(l,2,out v);
			self.modifiers=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.ManipulatorActivationFilter");
		addMember(l,Matches);
		addMember(l,"button",get_button,set_button,true);
		addMember(l,"modifiers",get_modifiers,set_modifiers,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.ManipulatorActivationFilter),typeof(System.ValueType));
	}
}
