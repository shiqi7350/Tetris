using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_PickingMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.PickingMode");
		addMember(l,0,"Position");
		addMember(l,1,"Ignore");
		LuaDLL.lua_pop(l, 1);
	}
}
