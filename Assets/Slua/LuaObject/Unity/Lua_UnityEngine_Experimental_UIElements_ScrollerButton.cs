using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_ScrollerButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollerButton o;
			System.Action a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			System.Int64 a2;
			checkType(l,3,out a2);
			System.Int64 a3;
			checkType(l,4,out a3);
			o=new UnityEngine.Experimental.UIElements.ScrollerButton(a1,a2,a3);
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
	static public int get_clickable(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollerButton self=(UnityEngine.Experimental.UIElements.ScrollerButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clickable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clickable(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollerButton self=(UnityEngine.Experimental.UIElements.ScrollerButton)checkSelf(l);
			UnityEngine.Experimental.UIElements.Clickable v;
			checkType(l,2,out v);
			self.clickable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.ScrollerButton");
		addMember(l,"clickable",get_clickable,set_clickable,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.ScrollerButton),typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
