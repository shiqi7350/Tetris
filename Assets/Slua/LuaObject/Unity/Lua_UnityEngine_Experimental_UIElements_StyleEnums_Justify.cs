using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_StyleEnums_Justify : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.StyleEnums.Justify");
		addMember(l,0,"FlexStart");
		addMember(l,1,"Center");
		addMember(l,2,"FlexEnd");
		addMember(l,3,"SpaceBetween");
		addMember(l,4,"SpaceAround");
		LuaDLL.lua_pop(l, 1);
	}
}
