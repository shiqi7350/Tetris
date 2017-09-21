using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_VisualElement_MeasureMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.VisualElement.MeasureMode");
		addMember(l,0,"Undefined");
		addMember(l,1,"Exactly");
		addMember(l,2,"AtMost");
		LuaDLL.lua_pop(l, 1);
	}
}
