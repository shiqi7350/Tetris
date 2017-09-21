using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_Manipulator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator o;
			o=new UnityEngine.Experimental.UIElements.Manipulator();
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
	static public int HandleEvent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
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
	static public int OnLostCapture(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
			self.OnLostCapture();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnLostKeyboardFocus(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
			self.OnLostKeyboardFocus();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_target(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.target);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_target(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
			UnityEngine.Experimental.UIElements.VisualElement v;
			checkType(l,2,out v);
			self.target=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_phaseInterest(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.phaseInterest);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_phaseInterest(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
			UnityEngine.Experimental.UIElements.EventPhase v;
			checkEnum(l,2,out v);
			self.phaseInterest=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_panel(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.Manipulator self=(UnityEngine.Experimental.UIElements.Manipulator)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.panel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.Manipulator");
		addMember(l,HandleEvent);
		addMember(l,OnLostCapture);
		addMember(l,OnLostKeyboardFocus);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"phaseInterest",get_phaseInterest,set_phaseInterest,true);
		addMember(l,"panel",get_panel,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.Manipulator));
	}
}
