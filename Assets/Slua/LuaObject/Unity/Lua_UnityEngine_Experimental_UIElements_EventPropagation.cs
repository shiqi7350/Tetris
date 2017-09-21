using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_EventPropagation : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.EventPropagation");
		addMember(l,0,"Continue");
		addMember(l,1,"Stop");
		LuaDLL.lua_pop(l, 1);
	}
}
