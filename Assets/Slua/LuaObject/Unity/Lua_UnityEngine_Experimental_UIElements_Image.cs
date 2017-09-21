using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_Image : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Image o;
			o=new UnityEngine.Experimental.UIElements.Image();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_image(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Image self=(UnityEngine.Experimental.UIElements.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.image);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_image(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Image self=(UnityEngine.Experimental.UIElements.Image)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.image=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scaleMode(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Image self=(UnityEngine.Experimental.UIElements.Image)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.scaleMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scaleMode(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Image self=(UnityEngine.Experimental.UIElements.Image)checkSelf(l);
			UnityEngine.ScaleMode v;
			checkEnum(l,2,out v);
			self.scaleMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.Image");
		addMember(l,"image",get_image,set_image,true);
		addMember(l,"scaleMode",get_scaleMode,set_scaleMode,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.Image),typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
