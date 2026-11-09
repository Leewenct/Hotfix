using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap;

public class DormModuleHelper_HotFixWrap
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
	private unsafe static int _m_GetCurRoomUsedCellNum_xlua_st_(IntPtr L)
	{
		//IL_0011: Invalid comparison between Unknown and Obj
		//IL_0019: Expected native int or pointer, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref /*Error near IL_0013: Stack underflow*/) < System.Runtime.CompilerServices.Unsafe.As<Exception, UIntPtr>(ref ex))
			{
				/*Error: Invalid branch target*/;
			}
			if ((int)/*Error near IL_0018: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = *(int*)unchecked((nint)null);
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_GetFur_EntityId_RootBubbleTrans_xlua_st_(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			_ = (float)ex;
			/*Error near IL_002e: Unknown opcode: 0xE7*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _m_TryPickActorAtLastPressDown_xlua_st_(IntPtr L)
	{
		//IL_0038: Expected native int or pointer, but got Obj
		//IL_003a: Expected Obj, but got I4
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			Transform val = (Transform)(object)(*(sbyte*)(nint)ex);
			/*Error near IL_003a: Unknown opcode: 0xB1*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_CaptureSceneImage_xlua_st_(IntPtr L)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid calli metadata token*/;
			}
			catch (Exception)
			{
				/*Error near IL_002a: Not a type handle*/;
			}
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_LoadSceneCaptureImageSprite_xlua_st_(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			_ = (nuint)ex;
			/*Error near IL_002d: Unknown opcode: 0x78*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_ReleaseSceneCaptureImageSprite_xlua_st_(IntPtr L)
	{
		//IL_004d: Expected I4, but got I8
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			switch ((uint)(~checked((ulong)(object)ex)))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0u:
				/*Error: Invalid branch target*/;
			case 1u:
				/*Error: Invalid branch target*/;
			case 2u:
				/*Error: Invalid branch target*/;
			case 3u:
				/*Error: Invalid branch target*/;
			case 4u:
				/*Error: Invalid branch target*/;
			case 5u:
				/*Error: Invalid branch target*/;
			case 6u:
				/*Error: Invalid branch target*/;
			}
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_CleanSceneCaptureImages_xlua_st_(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0035: ldloc 143 (out-of-bounds)*/;
			/*Error near IL_0037: Invalid metadata token*/;
		}
	}
}
