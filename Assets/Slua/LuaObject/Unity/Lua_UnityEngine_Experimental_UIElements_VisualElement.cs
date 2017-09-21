using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UIElements_VisualElement : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement o;
			o=new UnityEngine.Experimental.UIElements.VisualElement();
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
	static public int OnStylesResolved(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
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
	static public int InsertManipulator(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.UIElements.IManipulator a2;
			checkType(l,3,out a2);
			self.InsertManipulator(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddManipulator(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.IManipulator a1;
			checkType(l,2,out a1);
			self.AddManipulator(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveManipulator(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.IManipulator a1;
			checkType(l,2,out a1);
			self.RemoveManipulator(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dirty(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.ChangeType a1;
			checkEnum(l,2,out a1);
			self.Dirty(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsDirty(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.ChangeType a1;
			checkEnum(l,2,out a1);
			var ret=self.IsDirty(a1);
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
	static public int ClearDirty(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.ChangeType a1;
			checkEnum(l,2,out a1);
			self.ClearDirty(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DoRepaint(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			self.DoRepaint();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ContainsPoint(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.ContainsPoint(a1);
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
	static public int ContainsPointToLocal(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.ContainsPointToLocal(a1);
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
	static public int Overlaps(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			var ret=self.Overlaps(a1);
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
	static public int HandleEvent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
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
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
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
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
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
	static public int SetSize(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.SetSize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetPositionProperties(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			self.ResetPositionProperties();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearClassList(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			self.ClearClassList();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddToClassList(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.AddToClassList(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveFromClassList(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.RemoveFromClassList(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClassListContains(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.ClassListContains(a1);
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
	static public int get_usePixelCaching(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.usePixelCaching);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_usePixelCaching(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.usePixelCaching=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transform(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.transform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transform(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.transform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_position(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_contentRect(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_globalBound(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.globalBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_localBound(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_globalTransform(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.globalTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_parent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.parent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_parent(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.VisualContainer v;
			checkType(l,2,out v);
			self.parent=v;
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
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.panel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_phaseInterest(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
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
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
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
	static public int get_pickingMode(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.pickingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pickingMode(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.PickingMode v;
			checkEnum(l,2,out v);
			self.pickingMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_name(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxWidth(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxWidth(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxHeight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxHeight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minWidth(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minWidth(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.minWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minHeight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minHeight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.minHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flex(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flex(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.flex=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_positionLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.positionLeft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_positionLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.positionLeft=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_positionTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.positionTop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_positionTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.positionTop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_positionRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.positionRight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_positionRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.positionRight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_positionBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.positionBottom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_positionBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.positionBottom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_marginLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.marginLeft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_marginLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.marginLeft=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_marginTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.marginTop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_marginTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.marginTop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_marginRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.marginRight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_marginRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.marginRight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_marginBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.marginBottom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_marginBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.marginBottom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.borderLeft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.borderLeft=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.borderTop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.borderTop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.borderRight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.borderRight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.borderBottom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.borderBottom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_paddingLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paddingLeft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_paddingLeft(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.paddingLeft=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_paddingTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paddingTop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_paddingTop(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.paddingTop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_paddingRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paddingRight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_paddingRight(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.paddingRight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_paddingBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paddingBottom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_paddingBottom(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.paddingBottom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_positionType(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.positionType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_positionType(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.PositionType v;
			checkEnum(l,2,out v);
			self.positionType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_backgroundSize(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.backgroundSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_backgroundSize(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.ImageScaleMode v;
			checkEnum(l,2,out v);
			self.backgroundSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_alignSelf(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.alignSelf);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alignSelf(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.Align v;
			checkEnum(l,2,out v);
			self.alignSelf=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textAlignment(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.textAlignment);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_textAlignment(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.TextAnchor v;
			checkEnum(l,2,out v);
			self.textAlignment=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fontStyle(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.fontStyle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fontStyle(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.FontStyle v;
			checkEnum(l,2,out v);
			self.fontStyle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textClipping(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.textClipping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_textClipping(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.TextClipping v;
			checkEnum(l,2,out v);
			self.textClipping=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_font(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.font);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_font(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Font v;
			checkType(l,2,out v);
			self.font=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fontSize(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fontSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fontSize(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.fontSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wordWrap(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.wordWrap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wordWrap(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.wordWrap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_backgroundImage(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.backgroundImage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_backgroundImage(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Texture2D v;
			checkType(l,2,out v);
			self.backgroundImage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textColor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_textColor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.textColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_backgroundColor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.backgroundColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_backgroundColor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.backgroundColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderColor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.borderColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderColor(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.borderColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderWidth(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.borderWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderWidth(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.borderWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderRadius(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.borderRadius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderRadius(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.borderRadius=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overflow(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.overflow);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overflow(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			UnityEngine.Experimental.UIElements.StyleEnums.Overflow v;
			checkEnum(l,2,out v);
			self.overflow=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_text(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_text(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tooltip(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tooltip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tooltip(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.tooltip=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_visible(IntPtr l) {
		try {
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.visible);
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
			UnityEngine.Experimental.UIElements.VisualElement self=(UnityEngine.Experimental.UIElements.VisualElement)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.visible=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UIElements.VisualElement");
		addMember(l,OnStylesResolved);
		addMember(l,InsertManipulator);
		addMember(l,AddManipulator);
		addMember(l,RemoveManipulator);
		addMember(l,Dirty);
		addMember(l,IsDirty);
		addMember(l,ClearDirty);
		addMember(l,DoRepaint);
		addMember(l,ContainsPoint);
		addMember(l,ContainsPointToLocal);
		addMember(l,Overlaps);
		addMember(l,HandleEvent);
		addMember(l,OnLostCapture);
		addMember(l,OnLostKeyboardFocus);
		addMember(l,SetSize);
		addMember(l,ResetPositionProperties);
		addMember(l,ClearClassList);
		addMember(l,AddToClassList);
		addMember(l,RemoveFromClassList);
		addMember(l,ClassListContains);
		addMember(l,"usePixelCaching",get_usePixelCaching,set_usePixelCaching,true);
		addMember(l,"transform",get_transform,set_transform,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"contentRect",get_contentRect,null,true);
		addMember(l,"globalBound",get_globalBound,null,true);
		addMember(l,"localBound",get_localBound,null,true);
		addMember(l,"globalTransform",get_globalTransform,null,true);
		addMember(l,"parent",get_parent,set_parent,true);
		addMember(l,"panel",get_panel,null,true);
		addMember(l,"phaseInterest",get_phaseInterest,set_phaseInterest,true);
		addMember(l,"pickingMode",get_pickingMode,set_pickingMode,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"maxWidth",get_maxWidth,set_maxWidth,true);
		addMember(l,"maxHeight",get_maxHeight,set_maxHeight,true);
		addMember(l,"minWidth",get_minWidth,set_minWidth,true);
		addMember(l,"minHeight",get_minHeight,set_minHeight,true);
		addMember(l,"flex",get_flex,set_flex,true);
		addMember(l,"positionLeft",get_positionLeft,set_positionLeft,true);
		addMember(l,"positionTop",get_positionTop,set_positionTop,true);
		addMember(l,"positionRight",get_positionRight,set_positionRight,true);
		addMember(l,"positionBottom",get_positionBottom,set_positionBottom,true);
		addMember(l,"marginLeft",get_marginLeft,set_marginLeft,true);
		addMember(l,"marginTop",get_marginTop,set_marginTop,true);
		addMember(l,"marginRight",get_marginRight,set_marginRight,true);
		addMember(l,"marginBottom",get_marginBottom,set_marginBottom,true);
		addMember(l,"borderLeft",get_borderLeft,set_borderLeft,true);
		addMember(l,"borderTop",get_borderTop,set_borderTop,true);
		addMember(l,"borderRight",get_borderRight,set_borderRight,true);
		addMember(l,"borderBottom",get_borderBottom,set_borderBottom,true);
		addMember(l,"paddingLeft",get_paddingLeft,set_paddingLeft,true);
		addMember(l,"paddingTop",get_paddingTop,set_paddingTop,true);
		addMember(l,"paddingRight",get_paddingRight,set_paddingRight,true);
		addMember(l,"paddingBottom",get_paddingBottom,set_paddingBottom,true);
		addMember(l,"positionType",get_positionType,set_positionType,true);
		addMember(l,"backgroundSize",get_backgroundSize,set_backgroundSize,true);
		addMember(l,"alignSelf",get_alignSelf,set_alignSelf,true);
		addMember(l,"textAlignment",get_textAlignment,set_textAlignment,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"textClipping",get_textClipping,set_textClipping,true);
		addMember(l,"font",get_font,set_font,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"wordWrap",get_wordWrap,set_wordWrap,true);
		addMember(l,"backgroundImage",get_backgroundImage,set_backgroundImage,true);
		addMember(l,"textColor",get_textColor,set_textColor,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"borderColor",get_borderColor,set_borderColor,true);
		addMember(l,"borderWidth",get_borderWidth,set_borderWidth,true);
		addMember(l,"borderRadius",get_borderRadius,set_borderRadius,true);
		addMember(l,"overflow",get_overflow,set_overflow,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"tooltip",get_tooltip,set_tooltip,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"visible",get_visible,set_visible,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.UIElements.VisualElement));
	}
}
