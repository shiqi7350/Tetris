using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_EventPhase : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.EventPhase");
		addMember(l,0,"Capture");
		addMember(l,1,"BubbleUp");
		LuaDLL.lua_pop(l, 1);
	}
}
