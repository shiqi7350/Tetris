using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_StyleEnums_Overflow : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.StyleEnums.Overflow");
		addMember(l,0,"Visible");
		addMember(l,1,"Hidden");
		addMember(l,2,"Scroll");
		LuaDLL.lua_pop(l, 1);
	}
}
