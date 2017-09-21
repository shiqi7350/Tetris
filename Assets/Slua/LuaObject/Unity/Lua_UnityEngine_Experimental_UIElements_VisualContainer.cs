using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_VisualContainer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer o;
			o=new UnityEngine.Experimental.UIElements.VisualContainer();
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
	static public int AddChild(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.VisualElement a1;
			checkType(l,2,out a1);
			self.AddChild(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InsertChild(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.UIElements.VisualElement a2;
			checkType(l,3,out a2);
			self.InsertChild(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveChild(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.VisualElement a1;
			checkType(l,2,out a1);
			self.RemoveChild(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveChildAt(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveChildAt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearChildren(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			self.ClearChildren();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetChildAt(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetChildAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ContainsChild(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.VisualElement a1;
			checkType(l,2,out a1);
			var ret=self.ContainsChild(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddStyleSheetPath(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.AddStyleSheetPath(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveStyleSheetPath(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.RemoveStyleSheetPath(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasStyleSheetPath(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasStyleSheetPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clipChildren(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clipChildren);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clipChildren(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.clipChildren=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_childrenCount(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.childrenCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flexDirection(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.flexDirection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flexDirection(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.FlexDirection v;
			checkEnum(l,2,out v);
			self.flexDirection=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_alignItems(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.alignItems);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alignItems(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.Align v;
			checkEnum(l,2,out v);
			self.alignItems=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_alignContent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.alignContent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alignContent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.Align v;
			checkEnum(l,2,out v);
			self.alignContent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_justifyContent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.justifyContent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_justifyContent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.Justify v;
			checkEnum(l,2,out v);
			self.justifyContent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flexWrap(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.flexWrap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flexWrap(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualContainer self=(UnityEngine.Experimental.UIElements.VisualContainer)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.Wrap v;
			checkEnum(l,2,out v);
			self.flexWrap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.VisualContainer");
		addMember(l,AddChild);
		addMember(l,InsertChild);
		addMember(l,RemoveChild);
		addMember(l,RemoveChildAt);
		addMember(l,ClearChildren);
		addMember(l,GetChildAt);
		addMember(l,ContainsChild);
		addMember(l,AddStyleSheetPath);
		addMember(l,RemoveStyleSheetPath);
		addMember(l,HasStyleSheetPath);
		addMember(l,"clipChildren",get_clipChildren,set_clipChildren,true);
		addMember(l,"childrenCount",get_childrenCount,null,true);
		addMember(l,"flexDirection",get_flexDirection,set_flexDirection,true);
		addMember(l,"alignItems",get_alignItems,set_alignItems,true);
		addMember(l,"alignContent",get_alignContent,set_alignContent,true);
		addMember(l,"justifyContent",get_justifyContent,set_justifyContent,true);
		addMember(l,"flexWrap",get_flexWrap,set_flexWrap,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.VisualContainer),typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
