using System.Collections.Generic;
using TrueSync;
using UnityEngine;

namespace AIScript.FateCardTheme;

public class FateCard_FireWave : BaseFateCardTheme
{
	private const int hitDamageId = 986131;

	private readonly FP cd;

	private readonly FP circleRadius;

	private const string triggerFxPath = "fire_trigger_s";

	private readonly FP speed;

	private const string path_FireWaveBullet = "FateCard_fireWave";

	private readonly int fireWaveDamageTag;

	private const string path_FireWaveBullet_Proa = "FateCard_fireWave_A";

	private static readonly int fireMarkTag;

	private readonly FP range_14;

	private const string path_Bullet14 = "FateCard_fireWave_14";

	private const int hitDamageId_14 = 986133;

	private readonly int triggerPercent_14;

	private readonly int num_14;

	private const string path_Bulle_ProC = "FateCard_fireWave_14_A";

	private Dictionary<string, GameObject> _fireWavePrefabDic;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected override void OnTrigger()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: ldloc 87 (out-of-bounds)*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	private void ShootFireWave(int hitDamageId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)0u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected unsafe override void OnHitPre(AdventureActorReceiveDamageBeforeSettlementEvent _evt)
	{
		checked
		{
			_ = (byte)unchecked((uint)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/));
			_ = 4;
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private void OnActorRefreshBuff(IEvent evt)
	{
	}

	private GameObject getFireBulletPrefab(string curPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
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
		}
	}

	public FateCard_FireWave()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	unsafe static FateCard_FireWave()
	{
		_ = ((ushort[])/*Error near IL_0002: Stack underflow*/)[*(byte*)(nint)/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Unknown opcode: 0xF0*/;
	}
}
