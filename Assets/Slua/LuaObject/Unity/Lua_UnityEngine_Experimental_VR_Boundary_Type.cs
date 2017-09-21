using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_VR_Boundary_Type : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.VR.Boundary.Type");
		addMember(l,0,"PlayArea");
		addMember(l,1,"TrackedArea");
		LuaDLL.lua_pop(l, 1);
	}
}
