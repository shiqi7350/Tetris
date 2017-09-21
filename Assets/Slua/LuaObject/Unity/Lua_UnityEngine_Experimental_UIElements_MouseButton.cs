using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_MouseButton : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.MouseButton");
		addMember(l,0,"LeftMouse");
		addMember(l,1,"RightMouse");
		addMember(l,2,"MiddleMouse");
		LuaDLL.lua_pop(l, 1);
	}
}
