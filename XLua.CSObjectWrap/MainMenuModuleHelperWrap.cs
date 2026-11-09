using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap;

public class MainMenuModuleHelperWrap
{
	public static void __Register(IntPtr L)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int __CreateInstance(IntPtr L)
	{
		switch (*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_GetMainMenuSceneRoot_xlua_st_(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0024: Unknown opcode: 0xEE*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_GetActiveScene_xlua_st_(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0026: Invalid metadata token*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_DeActiveScene_xlua_st_(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0026: Invalid metadata token*/;
		}
	}
}
