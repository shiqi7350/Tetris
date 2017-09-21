using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_StyleEnums_FlexDirection : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.StyleEnums.FlexDirection");
		addMember(l,0,"Column");
		addMember(l,1,"ColumnReverse");
		addMember(l,2,"Row");
		addMember(l,3,"RowReverse");
		LuaDLL.lua_pop(l, 1);
	}
}
