using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_Button : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Button o;
			System.Action a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			o=new UnityEngine.Experimental.UIElements.Button(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.Button");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.Button),typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
