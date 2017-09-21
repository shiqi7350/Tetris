using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_VisualElementExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GlobalToBound_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Rect))){
				UnityEngine.Experimental.UIElements.VisualElement a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				var ret=UnityEngine.Experimental.UIElements.VisualElementExtensions.GlobalToBound(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Vector2))){
				UnityEngine.Experimental.UIElements.VisualElement a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Experimental.UIElements.VisualElementExtensions.GlobalToBound(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LocalToGlobal_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Rect))){
				UnityEngine.Experimental.UIElements.VisualElement a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				var ret=UnityEngine.Experimental.UIElements.VisualElementExtensions.LocalToGlobal(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Vector2))){
				UnityEngine.Experimental.UIElements.VisualElement a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Experimental.UIElements.VisualElementExtensions.LocalToGlobal(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChangeCoordinatesTo_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Rect))){
				UnityEngine.Experimental.UIElements.VisualElement a1;
				checkType(l,1,out a1);
				UnityEngine.Experimental.UIElements.VisualElement a2;
				checkType(l,2,out a2);
				UnityEngine.Rect a3;
				checkValueType(l,3,out a3);
				var ret=UnityEngine.Experimental.UIElements.VisualElementExtensions.ChangeCoordinatesTo(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Experimental.UIElements.VisualElement),typeof(UnityEngine.Vector2))){
				UnityEngine.Experimental.UIElements.VisualElement a1;
				checkType(l,1,out a1);
				UnityEngine.Experimental.UIElements.VisualElement a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Experimental.UIElements.VisualElementExtensions.ChangeCoordinatesTo(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StretchToParentSize_s(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.UIElements.VisualElementExtensions.StretchToParentSize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.VisualElementExtensions");
		addMember(l,GlobalToBound_s);
		addMember(l,LocalToGlobal_s);
		addMember(l,ChangeCoordinatesTo_s);
		addMember(l,StretchToParentSize_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.UIElements.VisualElementExtensions));
	}
}
