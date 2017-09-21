using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_ChangeType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.ChangeType");
		addMember(l,1,"Repaint");
		addMember(l,2,"StylesPath");
		addMember(l,4,"Transform");
		addMember(l,8,"Styles");
		addMember(l,16,"Layout");
		LuaDLL.lua_pop(l, 1);
	}
}
