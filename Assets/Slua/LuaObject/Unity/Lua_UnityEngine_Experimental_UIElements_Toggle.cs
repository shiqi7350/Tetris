using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_Toggle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Toggle o;
			System.Action a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			o=new UnityEngine.Experimental.UIElements.Toggle(a1);
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
	static public int get_on(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Toggle self=(UnityEngine.Experimental.UIElements.Toggle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.on);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_on(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Toggle self=(UnityEngine.Experimental.UIElements.Toggle)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.on=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.Toggle");
		addMember(l,"on",get_on,set_on,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.Toggle),typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
