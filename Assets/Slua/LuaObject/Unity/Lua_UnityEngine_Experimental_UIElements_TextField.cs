using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_TextField : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.UIElements.TextField o;
			if(argc==1){
				o=new UnityEngine.Experimental.UIElements.TextField();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==5){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				System.Char a4;
				checkType(l,5,out a4);
				o=new UnityEngine.Experimental.UIElements.TextField(a1,a2,a3,a4);
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
	static public int OnStylesResolved(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleSheets.ICustomStyles a1;
			checkType(l,2,out a1);
			self.OnStylesResolved(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_multiline(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.multiline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_multiline(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.multiline=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPasswordField(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPasswordField);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isPasswordField(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isPasswordField=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maskChar(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maskChar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maskChar(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			System.Char v;
			checkType(l,2,out v);
			self.maskChar=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_doubleClickSelectsWord(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.doubleClickSelectsWord);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_doubleClickSelectsWord(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.doubleClickSelectsWord=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tripleClickSelectsLine(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tripleClickSelectsLine);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tripleClickSelectsLine(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.tripleClickSelectsLine=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxLength(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxLength(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.maxLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasFocus(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasFocus);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_editor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.TextField self=(UnityEngine.Experimental.UIElements.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.editor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.TextField");
		addMember(l,OnStylesResolved);
		addMember(l,"multiline",get_multiline,set_multiline,true);
		addMember(l,"isPasswordField",get_isPasswordField,set_isPasswordField,true);
		addMember(l,"maskChar",get_maskChar,set_maskChar,true);
		addMember(l,"doubleClickSelectsWord",get_doubleClickSelectsWord,set_doubleClickSelectsWord,true);
		addMember(l,"tripleClickSelectsLine",get_tripleClickSelectsLine,set_tripleClickSelectsLine,true);
		addMember(l,"maxLength",get_maxLength,set_maxLength,true);
		addMember(l,"hasFocus",get_hasFocus,null,true);
		addMember(l,"editor",get_editor,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.TextField),typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
