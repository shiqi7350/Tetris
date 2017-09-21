using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_VR_Boundary : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TryGetDimensions_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Vector3 a1;
				var ret=UnityEngine.Experimental.VR.Boundary.TryGetDimensions(out a1);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a1);
				return 3;
			}
			else if(argc==2){
				UnityEngine.Vector3 a1;
				UnityEngine.Experimental.VR.Boundary.Type a2;
				checkEnum(l,2,out a2);
				var ret=UnityEngine.Experimental.VR.Boundary.TryGetDimensions(out a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a1);
				return 3;
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
	static public int TryGetGeometry_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Collections.Generic.List<UnityEngine.Vector3> a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Experimental.VR.Boundary.TryGetGeometry(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Collections.Generic.List<UnityEngine.Vector3> a1;
				checkType(l,1,out a1);
				UnityEngine.Experimental.VR.Boundary.Type a2;
				checkEnum(l,2,out a2);
				var ret=UnityEngine.Experimental.VR.Boundary.TryGetGeometry(a1,a2);
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
	static public int get_visible(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.VR.Boundary.visible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_visible(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Experimental.VR.Boundary.visible=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_configured(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.VR.Boundary.configured);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.VR.Boundary");
		addMember(l,TryGetDimensions_s);
		addMember(l,TryGetGeometry_s);
		addMember(l,"visible",get_visible,set_visible,false);
		addMember(l,"configured",get_configured,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.VR.Boundary));
	}
}
