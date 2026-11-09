using System;
using System.Collections.Generic;
using TrueSync;
using UnityEngine;

namespace AIScript.ThemePerk;

public class Theme_FireWave : BaseTheme
{
	private const string path_FireWaveBullet = "Misc/FateCard/Theme_fireWave";

	private const string path_FireWaveBullet_11 = "Misc/FateCard/Theme_fireWave_11";

	private const string path_FireWaveBullet_12 = "Misc/FateCard/Theme_fireWave_12";

	private const string path_FireWaveBullet_11_12 = "Misc/FateCard/Theme_fireWave_11_12";

	private readonly FP circleRadius;

	private readonly FP speed;

	private static readonly int fireWaveTag;

	private readonly int fireWaveDamageTag;

	private const string triggerFxPath = "FX/Perk/fx_perk_base_fire_trigger_s";

	private static readonly int fireBuffTag;

	private const int perkId_1 = 500201;

	private readonly FP trigger_Percentage1;

	private readonly FP cd_1;

	private const int hitDamageId_1 = 500201;

	private const int perkId_2 = 500202;

	private readonly FP trigger_Percentage2;

	private readonly FP cd_2;

	private const int hitDamageId_2 = 500202;

	private const int perkId_3 = 500203;

	private readonly FP trigger_Percentage3;

	private readonly FP cd_3;

	private const int hitDamageId_3 = 500203;

	private const int perkId_4 = 500204;

	private readonly FP trigger_Percentage4;

	private readonly FP cd_4;

	private const int hitDamageId_4 = 500204;

	private const int perkId_8 = 500208;

	private readonly FP cd_8;

	private const int triggerCount = 3;

	private readonly Dictionary<int, int> buffIdDic_8;

	private const int perkId_9 = 500209;

	private readonly FP cd_9;

	private readonly Dictionary<int, int> attriIdDic_9;

	private const int perkId_10 = 500210;

	private readonly FP cd_10;

	private readonly int _actorSkillOrUltraTag;

	private readonly Dictionary<int, int> attriIdDic_10;

	private const int perkId_11 = 500211;

	private readonly Dictionary<int, int> attrIdDic_11;

	private const int perkId_12 = 500212;

	private readonly FP speed_12;

	private readonly Dictionary<int, int> attriIdDic_12;

	private const int perkId_13 = 500213;

	private readonly FP range_13;

	private const string fxPath_13 = "FX/Perk/fx_perk_base_fire_flame_wave_burn_13";

	private readonly Dictionary<int, int> dicHitId_13;

	private const int perkId_14 = 500214;

	private static readonly int fireMarkTag;

	private readonly FP range_14;

	private const string path_Bullet14 = "Misc/FateCard/Theme_fireWave_14";

	private const int hitDamageId_14 = 500214;

	private readonly Dictionary<int, int> dicCD_14;

	private readonly Dictionary<int, int> dicTriggerPercent_14;

	private readonly Dictionary<int, int> dicNum_14;

	private const int perkId_15 = 500215;

	private readonly FP cd_15;

	private readonly Dictionary<int, int> attriIdDic_15;

	private readonly FP minOffsetAngle;

	private readonly FP maxOffsetAngle;

	private const int perkId_1p = 500216;

	private readonly FP re_cd;

	private readonly FP re_cdMax;

	private const int perkId_2p = 500217;

	private readonly FP cd_2p;

	private readonly FP fixPercent;

	private const string bomFxPath = "FX/Perk/fx_perk_base_fire_flame_wave_burn_13q02";

	private const int perkId_3p = 500218;

	private readonly FP cd_3p;

	private readonly int buffId_3p;

	private Dictionary<string, GameObject> _fireWavePrefabDic;

	private Dictionary<long, int> _bulletHitCountDic;

	private Dictionary<long, long> _bulletReflectSet;

	private FP reCd;

	private Dictionary<long, long> _perk11Dic;

	private List<long> _perk3Pls;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)unchecked((int)((ushort[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_NormalAtk()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		checked
		{
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0L;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_Dodge()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		checked
		{
			((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0f;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_CastSkill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		checked
		{
			((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0.0;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_CastAssistSkill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected Obj, but got I4
		checked
		{
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void ShootFireWave(int hitDamageId)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xA9*/;
	}

	protected override void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			MonsterAdventureActor monsterAdventureActor = (MonsterAdventureActor)/*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
		/*Error near IL_007e: Unknown opcode: 0xE5*/;
	}

	protected override void OnHitPre(AdventureActorReceiveDamageBeforeSettlementEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = -4.8502306E+17f;
			/*Error near IL_000e: Unknown opcode: 0xCD*/;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_000c: Stack underflow*/ >> unchecked((int)/*Error near IL_000c: Stack underflow*/));
		}
	}

	protected override void OnHitPost(AdventureActorReceiveDamageEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = /*Error near IL_000a: Stack underflow*/% /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_000c: Stack underflow*/ >> unchecked((int)/*Error near IL_000c: Stack underflow*/));
		}
	}

	private unsafe void OnBulletReflect(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xAF*/;
	}

	private unsafe void OnBulletFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB1*/;
	}

	private unsafe void OnActorGetBuff(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)(*unchecked((int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void OnActorRefreshBuff(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/+ *unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private FP GetFixedCD(FP cd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)((int[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe GameObject GetFireWavePrefab()
	{
		((sbyte[])(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))[-12] = (sbyte)/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
		((IntPtr[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (IntPtr)0;
		/*Error near IL_0007: Unknown opcode: 0xB0*/;
	}

	private GameObject getFireBulletPrefab(string curPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
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
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		}
	}

	public Theme_FireWave()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xF3*/;
		}
	}

	unsafe static Theme_FireWave()
	{
		((sbyte[])(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))[-11] = (sbyte)/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
		if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xF0*/;
	}
}
