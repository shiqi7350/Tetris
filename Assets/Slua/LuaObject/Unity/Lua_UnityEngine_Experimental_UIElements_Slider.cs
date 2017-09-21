using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_Slider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider o;
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Action<System.Single> a3;
			LuaDelegation.checkDelegate(l,4,out a3);
			UnityEngine.Experimental.UIElements.Slider.Direction a4;
			checkEnum(l,5,out a4);
			System.Single a5;
			checkType(l,6,out a5);
			o=new UnityEngine.Experimental.UIElements.Slider(a1,a2,a3,a4,a5);
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
	static public int AdjustDragElement(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.AdjustDragElement(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dragElement(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dragElement);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lowValue(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
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
	static public int set_lowValue(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lowValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_highValue(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
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
	static public int set_highValue(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.highValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_range(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.range);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pageSize(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pageSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pageSize(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.pageSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_value(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
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
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
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
	static public int get_direction(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
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
			UnityEngine.Experimental.UIElements.Slider self=(UnityEngine.Experimental.UIElements.Slider)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.Slider");
		addMember(l,AdjustDragElement);
		addMember(l,"dragElement",get_dragElement,null,true);
		addMember(l,"lowValue",get_lowValue,set_lowValue,true);
		addMember(l,"highValue",get_highValue,set_highValue,true);
		addMember(l,"range",get_range,null,true);
		addMember(l,"pageSize",get_pageSize,set_pageSize,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"direction",get_direction,set_direction,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.Slider),typeof(UnityEngine.Experimental.UIElements.VisualContainer));
	}
}
