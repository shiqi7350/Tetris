using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_RepeatButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.RepeatButton o;
			System.Action a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			System.Int64 a2;
			checkType(l,3,out a2);
			System.Int64 a3;
			checkType(l,4,out a3);
			o=new UnityEngine.Experimental.UIElements.RepeatButton(a1,a2,a3);
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
		getTypeTable(l,"UnityEngine.Experimental.UIElements.RepeatButton");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.RepeatButton),typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
