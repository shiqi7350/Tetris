using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_StyleEnums_ImageScaleMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.UIElements.StyleEnums.ImageScaleMode");
		addMember(l,0,"StretchToFill");
		addMember(l,1,"ScaleAndCrop");
		addMember(l,2,"ScaleToFit");
		LuaDLL.lua_pop(l, 1);
	}
}
