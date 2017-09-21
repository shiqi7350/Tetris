using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_StyleEnums_PositionType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.StyleEnums.PositionType");
		addMember(l,0,"Relative");
		addMember(l,1,"Absolute");
		addMember(l,2,"Manual");
		LuaDLL.lua_pop(l, 1);
	}
}
