using System;
using System.Runtime.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap;

public class InteractiveManagerWrap
{
	public static void __Register(IntPtr L)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int __CreateInstance(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			_ = 4;
			/*Error near IL_002a: Unknown opcode: 0xB1*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_ClearData(IntPtr L)
	{
		//IL_0021: Invalid comparison between Unknown and I
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			if ((nint)/*Error near IL_0026: Stack underflow*/ >= (nint)(nuint)ex)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0026: Unknown opcode: 0xFD*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_AddInteractiveGroup(IntPtr L)
	{
		//IL_003b: Expected native int or pointer, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_003b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_AddInteractiveObj(IntPtr L)
	{
		//IL_003b: Expected native int or pointer, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_003b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_removeInteractiveObj(IntPtr L)
	{
		//IL_003b: Expected native int or pointer, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_003b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _m_setInteractiveObjState(IntPtr L)
	{
		//IL_0031: Invalid comparison between Unknown and Obj
		//IL_0039: Expected native int or pointer, but got Obj
		while (true)
		{
			try
			{
				/*Error: Unknown opcode: 0xFD*/;
			}
			catch (Exception ex)
			{
				if ((object)/*Error near IL_0033: Stack underflow*/ != ex)
				{
					continue;
				}
				if ((int)/*Error near IL_0038: Stack underflow*/ == 0)
				{
					/*Error: Invalid branch target*/;
				}
				_ = *(int*)unchecked((nint)null);
			}
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_triggerInteractiveObjState(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			_ = 2;
			/*Error near IL_002a: Unknown opcode: 0xB1*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_setInteractiveNpcState(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			_ = 2;
			/*Error near IL_002a: Unknown opcode: 0xB1*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_setInteractiveObjActiveState(IntPtr L)
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					/*Error: Unknown opcode: 0xFD*/;
				case 19:
					if ((int)/*Error near IL_0018: Stack underflow*/ != 0)
					{
						/*Error: Invalid branch target*/;
					}
					/*Error near IL_0018: Metadata token must be either a methoddef, memberref or methodspec*/;
				}
			}
			catch (Exception ex)
			{
				if (ex == null)
				{
					/*OpCode not supported: DebugBreak*/;
					((int[])/*Error near IL_0045: Stack underflow*/)[/*Error near IL_0045: Stack underflow*/] = (int)/*Error near IL_0045: Stack underflow*/;
					/*Error near IL_0045: Unknown opcode: 0xA8*/;
				}
				try0000_dispatch = 19;
			}
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_setInteractiveObjInterState(IntPtr L)
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					/*Error: Unknown opcode: 0xFD*/;
				case 19:
					if ((int)/*Error near IL_0018: Stack underflow*/ != 0)
					{
						/*Error: Invalid branch target*/;
					}
					/*Error near IL_0018: Metadata token must be either a methoddef, memberref or methodspec*/;
				}
			}
			catch (Exception ex)
			{
				if (ex == null)
				{
					/*OpCode not supported: DebugBreak*/;
					((int[])/*Error near IL_0045: Stack underflow*/)[/*Error near IL_0045: Stack underflow*/] = (int)/*Error near IL_0045: Stack underflow*/;
					/*Error near IL_0045: Unknown opcode: 0xA8*/;
				}
				try0000_dispatch = 19;
			}
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_ForceActiveInterObj(IntPtr L)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected I4, but got Unknown
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			_003F val = checked(/*Error near IL_0033: Stack underflow*/ * ex);
			/*OpCode not supported: DebugBreak*/;
			((int[])/*Error near IL_0035: Stack underflow*/)[/*Error near IL_0035: Stack underflow*/] = (int)val;
			/*Error near IL_0035: Unknown opcode: 0xA8*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_setInteractiveInterActiveByGroup(IntPtr L)
	{
		//IL_0037: Expected I4, but got Obj
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			((int[])/*Error near IL_0037: Stack underflow*/)[/*Error near IL_0037: Stack underflow*/] = (int)ex;
			if (/*Error near IL_003c: Stack underflow*/ != /*Error near IL_003c: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_003e: Stack underflow*/>> (int)checked((nuint)/*Error near IL_003d: Stack underflow*/);
			/*Error near IL_003e: Unknown opcode: 0xF4*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_addopTiggerOpListener(IntPtr L)
	{
		//IL_003b: Expected native int or pointer, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_003b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_removeTiggerOpListener(IntPtr L)
	{
		//IL_003b: Expected native int or pointer, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_003b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_triggerOpListener(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_006e: Unknown opcode: 0xF6*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_getPbDuration(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			switch (~checked((sbyte)/*Error near IL_004b: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			}
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_GetPbName(IntPtr L)
	{
		//IL_0047: Invalid comparison between Unknown and Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref /*Error near IL_0049: Stack underflow*/) > System.Runtime.CompilerServices.Unsafe.As<Exception, UIntPtr>(ref ex))
			{
				/*Error near IL_0049: ldarg 2 (out-of-bounds)*/;
				_ = -568621158876440296L;
				/*Error near IL_0054: Unknown opcode: 0xCA*/;
			}
			_ = ((uint[])2)[~3];
			/*Error near IL_004f: ldloc 218 (out-of-bounds)*/;
			_ = 5;
			/*Error near IL_0052: Unknown opcode: 0xF8*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_refreshTypeState(IntPtr L)
	{
		//IL_0047: Expected I4, but got Obj
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			((int[])/*Error near IL_0047: Stack underflow*/)[/*Error near IL_0047: Stack underflow*/] = (int)ex;
			if (/*Error near IL_004c: Stack underflow*/ != /*Error near IL_004c: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_004e: Stack underflow*/>> (int)checked((nuint)/*Error near IL_004d: Stack underflow*/);
			/*Error near IL_004e: Unknown opcode: 0xF4*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _m_getLogicDeletaTime_xlua_st_(IntPtr L)
	{
		//IL_0021: Invalid comparison between Unknown and Obj
		//IL_0029: Expected native int or pointer, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref /*Error near IL_0023: Stack underflow*/) < System.Runtime.CompilerServices.Unsafe.As<Exception, UIntPtr>(ref ex))
			{
				/*Error: Invalid branch target*/;
			}
			if ((int)/*Error near IL_0028: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = *(int*)unchecked((nint)null);
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_SetIneractiveUI(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0044: Unknown opcode: 0xFF*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _g_get__Uid(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			if ((uint)checked((byte)(object)ex) <= 1727359239u)
			{
				/*Error: Invalid branch target*/;
			}
			*(IntPtr*)(nint)/*Error near IL_0033: Stack underflow*/ = (IntPtr)2;
			_ = ((uint[])/*Error near IL_0034: Stack underflow*/)[/*Error near IL_0034: Stack underflow*/];
			/*Error near IL_0034: Unknown opcode: 0xE9*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _s_set__Uid(IntPtr L)
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
