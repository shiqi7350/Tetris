using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_Clickable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.UIElements.Clickable o;
			if(argc==4){
				System.Action a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				System.Int64 a3;
				checkType(l,4,out a3);
				o=new UnityEngine.Experimental.UIElements.Clickable(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.Action a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				o=new UnityEngine.Experimental.UIElements.Clickable(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HandleEvent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Clickable self=(UnityEngine.Experimental.UIElements.Clickable)checkSelf(l);
			UnityEngine.Event a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.UIElements.VisualElement a2;
			checkType(l,3,out a2);
			var ret=self.HandleEvent(a1,a2);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lastMousePosition(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Clickable self=(UnityEngine.Experimental.UIElements.Clickable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lastMousePosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.Clickable");
		addMember(l,HandleEvent);
		addMember(l,"lastMousePosition",get_lastMousePosition,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.Clickable),typeof(UnityEngine.Experimental.UIElements.MouseManipulator));
	}
}
