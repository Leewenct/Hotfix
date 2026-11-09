using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap;

public class SoldierActorWrap
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
	private static int _m_LoadData(IntPtr L)
	{
		//IL_0317: Expected I4, but got Obj
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			((int[])/*Error near IL_0317: Stack underflow*/)[/*Error near IL_0317: Stack underflow*/] = (int)ex;
			((double[])/*Error near IL_0318: Stack underflow*/)[/*Error near IL_0318: Stack underflow*/] = (double)/*Error near IL_0318: Stack underflow*/;
			/*Error near IL_0318: Invalid metadata token*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_GetPotentialLv(IntPtr L)
	{
		//IL_0035: Invalid comparison between I and Unknown
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			_003F val = /*Error near IL_0029: ldarg 2 (out-of-bounds)*/;
			_ = -3525198653131253480L;
			/*Error near IL_0033: stloc 248 (out-of-bounds)*/;
			if ((nint)L < (nint)val)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0037: Unknown opcode: 0xF6*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_FindNearestConfrontTarget(IntPtr L)
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
	private static int _m_HasPartnerType(IntPtr L)
	{
		//IL_003c: Invalid comparison between Unknown and I4
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			if ((int)/*Error near IL_0035: ldarga 137 (out-of-bounds)*/ <= 1727359249)
			{
				/*Error: Invalid branch target*/;
			}
			if (ex != null)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0046: Unknown opcode: 0xE2*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_GetTotalCost(IntPtr L)
	{
		//IL_0035: Invalid comparison between I and Unknown
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			_003F val = /*Error near IL_0029: ldarg 2 (out-of-bounds)*/;
			_ = -3525198653131253480L;
			/*Error near IL_0033: stloc 248 (out-of-bounds)*/;
			if ((nint)L < (nint)val)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0037: Unknown opcode: 0xF6*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_ConsumeEnergy(IntPtr L)
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
	private static int _m_BeginEnergyRegenSuspend(IntPtr L)
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
	private static int _m_EndEnergyRegenSuspend(IntPtr L)
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
	private static int _m_SetEnergy(IntPtr L)
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
	private static int _m_SetMaxEnergy(IntPtr L)
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
	private static int _m_SetEnergyRecoverRate(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002a: Unknown opcode: 0xBB*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_SetEnergyRecoverRateFP(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			_ = (sbyte)ex;
			/*Error near IL_002e: Unknown opcode: 0xE7*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_SetEnergyRecoverRatePercent(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			_ = (sbyte)ex;
			/*Error near IL_002e: Unknown opcode: 0xE7*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_ModifyEnergyRecoverRatePercent(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			_ = (sbyte)ex;
			/*Error near IL_002e: Unknown opcode: 0xE7*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_SetupPrimeFSM(IntPtr L)
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
	private static int _m_LevelStart(IntPtr L)
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
	private static int _m_Despawn(IntPtr L)
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
	private static int _m_OnShowHud(IntPtr L)
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
	private static int _m_EnterSupportCastStance(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_008c: Unknown opcode: 0xE6*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _m_ExitSupportCastStance(IntPtr L)
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
	private static int _m_PromoteToBattle(IntPtr L)
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
	private unsafe static int _g_get_UseInheritElementOnHit(IntPtr L)
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
	private static int _g_get_monsterInfo(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0027: Unknown opcode: 0xB0*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _g_get_soldierChessAI(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0027: Unknown opcode: 0xB0*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _g_get_isSupport(IntPtr L)
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
	private static int _g_get_energyRecoverRate(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0027: Unknown opcode: 0xB0*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _g_get_EnergyRecoverRateFP(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002c: Invalid branch target*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _g_get_isEnergyFull(IntPtr L)
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
	private static int _g_get_soldierRole(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002c: Invalid branch target*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _g_get_gridIndex(IntPtr L)
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
	private unsafe static int _g_get_isEnemyCamp(IntPtr L)
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
	private static int _g_get_soldierAI(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0027: Unknown opcode: 0xB0*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _g_get_isCastingSupport(IntPtr L)
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
	private static int _g_get_onStageType(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002c: Invalid branch target*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _g_get_normalSkillId(IntPtr L)
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
	private unsafe static int _g_get_mainSkillId(IntPtr L)
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
	private unsafe static int _g_get_supportSkillId(IntPtr L)
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
	private static int _g_get_normalAttackRadius(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002c: Invalid branch target*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _g_get_skillRadius(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002c: Invalid branch target*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private unsafe static int _g_get_stopNormalAttack(IntPtr L)
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
	private unsafe static int _g_get_spawnSkillSkillId(IntPtr L)
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
	private unsafe static int _g_get_isAimAtTarget(IntPtr L)
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
	private unsafe static int _g_get_energy(IntPtr L)
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
	private unsafe static int _g_get_maxEnergy(IntPtr L)
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
	private unsafe static int _g_get_isSkillEndStartRecover(IntPtr L)
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
	private unsafe static int _s_set_energyRecoverRate(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception ex)
		{
			if ((uint)checked((ushort)(object)ex) <= 1727359238u)
			{
				/*Error: Invalid branch target*/;
			}
			*(IntPtr*)(nint)/*Error near IL_0033: Stack underflow*/ = (IntPtr)2;
			_ = ((uint[])/*Error near IL_0034: Stack underflow*/)[/*Error near IL_0034: Stack underflow*/];
			/*Error near IL_0034: Unknown opcode: 0xE9*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _s_set_soldierRole(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _s_set_gridIndex(IntPtr L)
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
	private static int _s_set_isEnemyCamp(IntPtr L)
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
	private static int _s_set_soldierAI(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_0037: Unknown opcode: 0xB0*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _s_set_isCastingSupport(IntPtr L)
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
	private static int _s_set_onStageType(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _s_set_normalSkillId(IntPtr L)
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
	private static int _s_set_mainSkillId(IntPtr L)
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
	private static int _s_set_supportSkillId(IntPtr L)
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
	private static int _s_set_normalAttackRadius(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _s_set_skillRadius(IntPtr L)
	{
		try
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		catch (Exception)
		{
			/*Error near IL_002b: Not a type handle*/;
		}
	}

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	private static int _s_set_stopNormalAttack(IntPtr L)
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
	private static int _s_set_spawnSkillSkillId(IntPtr L)
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
	private static int _s_set_isAimAtTarget(IntPtr L)
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
	private static int _s_set_energy(IntPtr L)
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
	private static int _s_set_maxEnergy(IntPtr L)
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
	private static int _s_set_isSkillEndStartRecover(IntPtr L)
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
