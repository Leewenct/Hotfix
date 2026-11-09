using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

namespace AIScript.ThemePerk;

public class Theme_FireRing : BaseTheme
{
	private readonly FP duration;

	private readonly FP duration_11;

	private readonly FP duration_1p;

	private readonly FP initInnerRadius;

	private readonly FP radius;

	private readonly int fireRingDamageTag;

	private const string fxPath = "FX/Perk/fx_perk_base_fire_firering_6m_1s_01";

	private const string fxPath_11 = "FX/Perk/fx_perk_base_fire_firering_9m_1s_11";

	private const string fxPath_13 = "FX/Perk/fx_perk_base_fire_firering_6m_1s_13";

	private const string fxPath_11_13 = "FX/Perk/fx_perk_base_fire_firering_9m_1s_13";

	private const string fxPath_1p = "FX/Perk/fx_perk_base_fire_firering_3m_1s_q01";

	private const string fxPath_1p_13 = "FX/Perk/fx_perk_base_fire_firering_3m_1s_13q01";

	private const string triggerFxPath = "FX/Perk/fx_perk_base_fire_trigger_s";

	private const string fxPath_bom6 = "FX/Perk/fx_perk_base_fire_firering_6m_q2";

	private const string fxPath_bom9 = "FX/Perk/fx_perk_base_fire_firering_9m_q2";

	private const string fxPath_hitQ2 = "FX/Perk/fx_perk_hit_fire_firering_q02";

	private readonly FP diffuseSpeed;

	private readonly FP diffuseInterval;

	private readonly FP attackInterval;

	private const int perkId_1 = 500101;

	private readonly FP trigger_Percentage1;

	private readonly FP cd_1;

	private const int hitDamageId_1 = 500101;

	private const int perkId_2 = 500102;

	private readonly FP trigger_Percentage2;

	private readonly FP cd_2;

	private const int hitDamageId_2 = 500102;

	private const int perkId_3 = 500103;

	private readonly FP trigger_Percentage3;

	private readonly FP cd_3;

	private const int hitDamageId_3 = 500103;

	private const int perkId_4 = 500104;

	private readonly FP trigger_Percentage4;

	private readonly FP cd_4;

	private const int hitDamageId_4 = 500104;

	private const int perkId_8 = 500108;

	private readonly FP cd_8;

	private readonly FP fixedCd_8;

	private readonly int buffTag_8;

	private readonly Dictionary<int, int> buffIdDic_8;

	private const int perkId_9 = 500109;

	private readonly FP cd_9;

	private readonly FP fixedCd_9;

	private readonly int buffTag_9;

	private readonly Dictionary<int, int> buffIdDic_9;

	private const int perkId_10 = 500110;

	private readonly FP cd_10;

	private readonly int maxTriggerCount;

	private readonly Dictionary<int, FP> dicPower_10;

	private const int perkId_11 = 500111;

	private readonly FP diffuseInterval_11;

	private readonly FP cd_11;

	private readonly Dictionary<int, int> attrIdDic_11;

	private const int perkId_12 = 500112;

	private readonly FP cd_12;

	private readonly FP dis_12;

	private readonly Dictionary<FP, int> atrriIdDic_12;

	private const int perkId_13 = 500113;

	private readonly Dictionary<int, int> attriIdDic_13;

	private const int perkId_14 = 500114;

	private readonly FP cd_14;

	private static readonly int fireMarkTag;

	private readonly Dictionary<int, int> dicCD_14;

	private readonly Dictionary<int, int> dicTriggerPercent_14;

	private readonly Dictionary<int, int> buffDic_14;

	private readonly Dictionary<int, int> attriIdDic_14;

	private const int perkId_15 = 500115;

	private readonly FP cd_15;

	private readonly Dictionary<int, int> buffIdDic_15;

	private readonly Dictionary<int, int> buffIdDic_15_self;

	private const int hitDamageId_15 = 500115;

	private const int perkId_1p = 500116;

	private readonly FP cd_1p;

	private readonly FP diffuseInterval_1p;

	private readonly int triggerCount;

	private const int hitDamageId_1p = 500115;

	private const int perkId_2p = 500117;

	private readonly FP cd_2p;

	private readonly FP one_percent;

	private readonly int numMax;

	private readonly int hitId_2p;

	private readonly int hitId_2pTag;

	private const int perkId_3p = 500118;

	private readonly FP range_3p;

	private const int attrId_3p = 50;

	private GameObject _prefab_FireRing;

	private List<int> _perkEffectIdList;

	private Dictionary<string, GameObject> _fxPrefabDic;

	private string _fireRingPrefabName;

	private Dictionary<long, FP> _perk8TriggerDic;

	private FP _perk9TriggerTime;

	private Dictionary<long, int> _perk10TriggerDic;

	private int _perk1pTriggerCount;

	private List<long> _perk2pTriggers;

	private bool _perk1pTrigger;

	private FP percetAjust_2p;

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

	private unsafe void OnDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnDiffuseEvent(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void PlayFireRing(int hitDamageId, TSVector2 pos = default(TSVector2))
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAA*/;
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

	private GameObject GetFireRingPrefab(bool iFollow)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
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
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		}
	}

	private AreaEffectEntity InitAreaEntity(GameObject prefab)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			_ = (sbyte)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void InitAttackComponent(AreaEffectEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (sbyte)unchecked((ulong)checked((long)/*Error near IL_0003: Stack underflow*/));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void InitDiffuseComponent(AreaEffectEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (sbyte)(byte)/*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void InitFollowComponent(AreaEffectEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (sbyte)(ushort)/*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public Theme_FireRing()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/> 7)
			{
				throw (nint)/*Error near IL_0005: Stack underflow*/;
			}
			_ = /*Error near IL_0038: Stack underflow*/+ /*Error near IL_0038: Stack underflow*/;
			_ = 3.755372818533897E-269;
			/*Error near IL_0041: stloc 3 (out-of-bounds)*/;
			/*Error near IL_0042: Unknown opcode: 0xFE99*/;
		}
	}

	unsafe static Theme_FireRing()
	{
		_ = ((ushort[])/*Error near IL_0002: Stack underflow*/)[*(byte*)(nint)/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Unknown opcode: 0xF0*/;
	}
}
