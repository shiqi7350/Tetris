using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_StyleEnums_Wrap : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.StyleEnums.Wrap");
		addMember(l,0,"NoWrap");
		addMember(l,1,"Wrap");
		LuaDLL.lua_pop(l, 1);
	}
}
