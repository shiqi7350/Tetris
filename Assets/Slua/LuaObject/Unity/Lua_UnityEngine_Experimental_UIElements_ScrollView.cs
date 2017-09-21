using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_ScrollView : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.UIElements.ScrollView o;
			if(argc==1){
				o=new UnityEngine.Experimental.UIElements.ScrollView();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				o=new UnityEngine.Experimental.UIElements.ScrollView(a1,a2);
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
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
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
	static public int get_kDefaultScrollerValues(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.UIElements.ScrollView.kDefaultScrollerValues);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_horizontalScrollerValues(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.horizontalScrollerValues);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_horizontalScrollerValues(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.horizontalScrollerValues=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_verticalScrollerValues(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.verticalScrollerValues);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_verticalScrollerValues(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.verticalScrollerValues=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showHorizontal(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showHorizontal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showHorizontal(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.showHorizontal=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showVertical(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showVertical);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showVertical(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.showVertical=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_needsHorizontal(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.needsHorizontal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_needsVertical(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.needsVertical);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scrollOffset(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scrollOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scrollOffset(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.scrollOffset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_contentView(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentView);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_contentViewport(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentViewport);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_horizontalScroller(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.horizontalScroller);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_verticalScroller(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.ScrollView self=(UnityEngine.Experimental.UIElements.ScrollView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.verticalScroller);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.ScrollView");
		addMember(l,HandleEvent);
		addMember(l,"kDefaultScrollerValues",get_kDefaultScrollerValues,null,false);
		addMember(l,"horizontalScrollerValues",get_horizontalScrollerValues,set_horizontalScrollerValues,true);
		addMember(l,"verticalScrollerValues",get_verticalScrollerValues,set_verticalScrollerValues,true);
		addMember(l,"showHorizontal",get_showHorizontal,set_showHorizontal,true);
		addMember(l,"showVertical",get_showVertical,set_showVertical,true);
		addMember(l,"needsHorizontal",get_needsHorizontal,null,true);
		addMember(l,"needsVertical",get_needsVertical,null,true);
		addMember(l,"scrollOffset",get_scrollOffset,set_scrollOffset,true);
		addMember(l,"contentView",get_contentView,null,true);
		addMember(l,"contentViewport",get_contentViewport,null,true);
		addMember(l,"horizontalScroller",get_horizontalScroller,null,true);
		addMember(l,"verticalScroller",get_verticalScroller,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.ScrollView),typeof(UnityEngine.Experimental.UIElements.VisualContainer));
	}
}
