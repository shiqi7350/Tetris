using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_StyleEnums_Align : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.StyleEnums.Align");
		addMember(l,0,"Auto");
		addMember(l,1,"FlexStart");
		addMember(l,2,"Center");
		addMember(l,3,"FlexEnd");
		addMember(l,4,"Stretch");
		LuaDLL.lua_pop(l, 1);
	}
}
