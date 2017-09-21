using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_Scroller : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller o;
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Action<System.Single> a3;
			LuaDelegation.checkDelegate(l,4,out a3);
			UnityEngine.Experimental.UIElements.Slider.Direction a4;
			checkEnum(l,5,out a4);
			o=new UnityEngine.Experimental.UIElements.Scroller(a1,a2,a3,a4);
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
	static public int PropagateEnabled(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			UnityEngine.Experimental.UIElements.VisualContainer a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.PropagateEnabled(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Adjust(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Adjust(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ScrollPageUp(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			self.ScrollPageUp();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ScrollPageDown(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			self.ScrollPageDown();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_slider(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.slider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lowButton(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lowButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_highButton(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.highButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_value(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_value(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.value=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lowValue(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lowValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_highValue(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.highValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_direction(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.direction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_direction(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			UnityEngine.Experimental.UIElements.Slider.Direction v;
			checkEnum(l,2,out v);
			self.direction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Scroller self=(UnityEngine.Experimental.UIElements.Scroller)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.Scroller");
		addMember(l,PropagateEnabled);
		addMember(l,Adjust);
		addMember(l,ScrollPageUp);
		addMember(l,ScrollPageDown);
		addMember(l,"slider",get_slider,null,true);
		addMember(l,"lowButton",get_lowButton,null,true);
		addMember(l,"highButton",get_highButton,null,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"lowValue",get_lowValue,null,true);
		addMember(l,"highValue",get_highValue,null,true);
		addMember(l,"direction",get_direction,set_direction,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.Scroller),typeof(UnityEngine.Experimental.UIElements.VisualContainer));
	}
}
