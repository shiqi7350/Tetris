using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_ContextType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.ContextType");
		addMember(l,0,"Player");
		addMember(l,1,"Editor");
		LuaDLL.lua_pop(l, 1);
	}
}
