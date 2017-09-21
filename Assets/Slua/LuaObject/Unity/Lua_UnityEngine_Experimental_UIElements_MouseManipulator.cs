using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_MouseManipulator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.MouseManipulator o;
			o=new UnityEngine.Experimental.UIElements.MouseManipulator();
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
	static public int get_activators(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.MouseManipulator self=(UnityEngine.Experimental.UIElements.MouseManipulator)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.activators);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.MouseManipulator");
		addMember(l,"activators",get_activators,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.MouseManipulator),typeof(UnityEngine.Experimental.UIElements.Manipulator));
	}
}
