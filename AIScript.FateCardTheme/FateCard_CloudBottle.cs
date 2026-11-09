using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AdventureBehaviour;
using TrueSync;
using UnityEngine;

namespace AIScript.FateCardTheme;

public class FateCard_CloudBottle : BaseFateCardTheme
{
	protected enum CircleHitType
	{
		Inner,
		Center,
		Outer
	}

	protected enum TriggerSoltType
	{
		None,
		Normal,
		Dodge,
		Skill,
		UltraSkill
	}

	[CompilerGenerated]
	private sealed class _003CCloudBottleExplosion_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FateCard_CloudBottle _003C_003E4__this;

		public TSVector2 position;

		public FP positionY;

		public AdventureActor actor;

		public TriggerSoltType soltType;

		public int bulletPerkId;

		private int _003CtotalTimes_003E5__2;

		private int _003Ctimes_003E5__3;

		private FP _003Cinterval_003E5__4;

		private bool _003Crandom_003E5__5;

		private AdventureFXPlayer _003CfxPlayer_003E5__6;

		private int _003CuniqueAttackId_003E5__7;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CCloudBottleExplosion_003Ed__37(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected I4, but got Unknown
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
			case 33:
				/*Error: Invalid branch target*/;
			case 34:
				/*Error: Invalid branch target*/;
			case 35:
				/*Error: Invalid branch target*/;
			case 36:
				/*Error: Invalid branch target*/;
			case 37:
				/*Error: Invalid branch target*/;
			case 38:
				/*Error: Invalid branch target*/;
			case 39:
				/*Error: Invalid branch target*/;
			case 40:
				/*Error: Invalid branch target*/;
			case 41:
				/*Error: Invalid branch target*/;
			case 42:
				/*Error: Invalid branch target*/;
			case 43:
				/*Error: Invalid branch target*/;
			case 44:
				/*Error: Invalid branch target*/;
			case 45:
				/*Error: Invalid branch target*/;
			case 46:
				/*Error: Invalid branch target*/;
			case 47:
				/*Error: Invalid branch target*/;
			case 48:
				/*Error: Invalid branch target*/;
			case 49:
				/*Error: Invalid branch target*/;
			case 50:
				/*Error: Invalid branch target*/;
			case 51:
				/*Error: Invalid branch target*/;
			case 52:
				/*Error: Invalid branch target*/;
			case 53:
				/*Error: Invalid branch target*/;
			case 54:
				/*Error: Invalid branch target*/;
			case 55:
				/*Error: Invalid branch target*/;
			case 56:
				/*Error: Invalid branch target*/;
			case 57:
				/*Error: Invalid branch target*/;
			case 58:
				/*Error: Invalid branch target*/;
			case 59:
				/*Error: Invalid branch target*/;
			case 60:
				/*Error: Invalid branch target*/;
			case 61:
				/*Error: Invalid branch target*/;
			case 62:
				/*Error: Invalid branch target*/;
			case 63:
				/*Error: Invalid branch target*/;
			case 64:
				/*Error: Invalid branch target*/;
			case 65:
				/*Error: Invalid branch target*/;
			case 66:
				/*Error: Invalid branch target*/;
			case 67:
				/*Error: Invalid branch target*/;
			case 68:
				/*Error: Invalid branch target*/;
			case 69:
				/*Error: Invalid branch target*/;
			case 70:
				/*Error: Invalid branch target*/;
			case 71:
				/*Error: Invalid branch target*/;
			case 72:
				/*Error: Invalid branch target*/;
			case 73:
				/*Error: Invalid branch target*/;
			case 74:
				/*Error: Invalid branch target*/;
			case 75:
				/*Error: Invalid branch target*/;
			case 76:
				/*Error: Invalid branch target*/;
			case 77:
				/*Error: Invalid branch target*/;
			case 78:
				/*Error: Invalid branch target*/;
			case 79:
				/*Error: Invalid branch target*/;
			case 80:
				/*Error: Invalid branch target*/;
			case 81:
				/*Error: Invalid branch target*/;
			case 82:
				/*Error: Invalid branch target*/;
			case 83:
				/*Error: Invalid branch target*/;
			case 84:
				/*Error: Invalid branch target*/;
			case 85:
				/*Error: Invalid branch target*/;
			case 86:
				/*Error: Invalid branch target*/;
			case 87:
				/*Error: Invalid branch target*/;
			case 88:
				/*Error: Invalid branch target*/;
			case 89:
				/*Error: Invalid branch target*/;
			case 90:
				/*Error: Invalid branch target*/;
			case 91:
				/*Error: Invalid branch target*/;
			case 92:
				/*Error: Invalid branch target*/;
			case 93:
				/*Error: Invalid branch target*/;
			case 94:
				/*Error: Invalid branch target*/;
			case 95:
				/*Error: Invalid branch target*/;
			case 96:
				/*Error: Invalid branch target*/;
			case 97:
				/*Error: Invalid branch target*/;
			case 98:
				/*Error: Invalid branch target*/;
			case 99:
				/*Error: Invalid branch target*/;
			case 100:
				/*Error: Invalid branch target*/;
			case 101:
				/*Error: Invalid branch target*/;
			case 102:
				/*Error: Invalid branch target*/;
			case 103:
				/*Error: Invalid branch target*/;
			case 104:
				/*Error: Invalid branch target*/;
			case 105:
				/*Error: Invalid branch target*/;
			case 106:
				/*Error: Invalid branch target*/;
			case 107:
				/*Error: Invalid branch target*/;
			case 108:
				/*Error: Invalid branch target*/;
			case 109:
				/*Error: Invalid branch target*/;
			case 110:
				/*Error: Invalid branch target*/;
			case 111:
				/*Error: Invalid branch target*/;
			case 112:
				/*Error: Invalid branch target*/;
			case 113:
				/*Error: Invalid branch target*/;
			case 114:
				/*Error: Invalid branch target*/;
			case 115:
				/*Error: Invalid branch target*/;
			case 116:
				/*Error: Invalid branch target*/;
			case 117:
				/*Error: Invalid branch target*/;
			case 118:
				/*Error: Invalid branch target*/;
			case 119:
				/*Error: Invalid branch target*/;
			case 120:
				/*Error: Invalid branch target*/;
			case 121:
				/*Error: Invalid branch target*/;
			case 122:
				/*Error: Invalid branch target*/;
			case 123:
				/*Error: Invalid branch target*/;
			case 124:
				/*Error: Invalid branch target*/;
			case 125:
				/*Error: Invalid branch target*/;
			case 126:
				/*Error: Invalid branch target*/;
			case 127:
				/*Error: Invalid branch target*/;
			case 128:
				/*Error: Invalid branch target*/;
			case 129:
				/*Error: Invalid branch target*/;
			case 130:
				/*Error: Invalid branch target*/;
			case 131:
				/*Error: Invalid branch target*/;
			case 132:
				/*Error: Invalid branch target*/;
			case 133:
				/*Error: Invalid branch target*/;
			case 134:
				/*Error: Invalid branch target*/;
			case 135:
				/*Error: Invalid branch target*/;
			case 136:
				/*Error: Invalid branch target*/;
			case 137:
				/*Error: Invalid branch target*/;
			case 138:
				/*Error: Invalid branch target*/;
			case 139:
				/*Error: Invalid branch target*/;
			case 140:
				/*Error: Invalid branch target*/;
			case 141:
				/*Error: Invalid branch target*/;
			case 142:
				/*Error: Invalid branch target*/;
			case 143:
				/*Error: Invalid branch target*/;
			case 144:
				/*Error: Invalid branch target*/;
			case 145:
				/*Error: Invalid branch target*/;
			case 146:
				/*Error: Invalid branch target*/;
			case 147:
				/*Error: Invalid branch target*/;
			case 148:
				/*Error: Invalid branch target*/;
			case 149:
				/*Error: Invalid branch target*/;
			case 150:
				/*Error: Invalid branch target*/;
			case 151:
				/*Error: Invalid branch target*/;
			case 152:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	private readonly FP searchTargetRadius;

	private const string bulletPath_CloudBottle = "FateCard_CloudBottle_base";

	private readonly FP cd;

	private const string fxPath_CloudBottle = "water_cloudbottle_center_1";

	private readonly List<FP> explosionTimesRatioList;

	private readonly FP interval_Explosion;

	private const int hitDamageId_InnerCircle = 986191;

	private const int hitDamageId_CenterCircle = 986191;

	private const int hitDamageId_OuterCircle = 986191;

	private const string fxPath_InnerCircle = "water_cloudbottle_a";

	private readonly FP radius_InnerCircle;

	private static readonly int damageTag_InnerCircle;

	private const string fxPath_CenterCircle = "water_cloudbottle_b";

	private readonly FP radius_CenterCircle;

	private const string damageTag_CenterCircle = "CloudBottle_b";

	private const string fxPath_OuterCircle = "water_cloudbottle_c";

	private readonly FP radius_OuterCircle;

	private const string damageTag_OuterCircle = "CloudBottle_c";

	private const string fxPath_Hitted = "";

	private readonly FP fxDelayTime_AfterExplosion;

	private const string bulletPath_11 = "FateCard_CloudBottle_11";

	private const int minShootCount_11 = 3;

	private const int maxShootCount_11 = 5;

	private readonly FP searchTargetRadius_11;

	private const int addExplosionTimes_Task1 = 3;

	private const string BulletTag_CloudBottle = "CloudBottleBullet";

	private List<FP> _curExplosionTimesRatioList;

	private FP _totalExplosionTimesRatio;

	private Dictionary<string, GameObject> _fxPrefabDic;

	private CommomAreaHitConfig _areaHitConfig;

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
			/*Error near IL_0008: ldarga 87 (out-of-bounds)*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	protected bool ShootCloudBottle(TriggerSoltType slotType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)0u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnBulletFinish(AdventureBulletFinishEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = ((ushort[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/];
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
		_ = /*Error near IL_002a: Stack underflow*/* 1;
		/*Error near IL_002a: Unknown opcode: 0xB0*/;
	}

	[IteratorStateMachine(typeof(_003CCloudBottleExplosion_003Ed__37))]
	protected IEnumerator CloudBottleExplosion(AdventureActor actor, TSVector2 position, FP positionY, TriggerSoltType soltType = TriggerSoltType.Normal, int bulletPerkId = 0)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void CircleAreaHit(AdventureActor actor, TSVector2 position, FP positionY, CircleHitType circleHitType, TriggerSoltType soltType, int uniqueAttackId, int bulletPerkId = 0)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	private void CircleAreaHit(AdventureActor actor, TSVector2 position, FP positionY, string fxPath, FP radius, int hitDamageId, int uniqueAttackId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected I4, but got Unknown
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
		case 33:
			/*Error: Invalid branch target*/;
		}
	}

	protected CircleHitType GetNextCircleAreaHitType(int index, bool random = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 212 (out-of-bounds)*/;
			/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xF5*/;
		}
	}

	private GameObject GetCloudBottleFx(string fxPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
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
		}
	}

	private FP GetLeftRatioByIndex(int index)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private unsafe void OnAfterSingleCloudBottleExplosion(int times, AdventureActor actor, TSVector2 position, FP positionY, int uniqueAttackId)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_000c: Stack underflow*/ != (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ /*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Invalid branch target*/;
		}
	}

	public FateCard_CloudBottle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 3099216021507151061L;
			_ = (nuint)((byte[])(-2.9346061182941414E+54))[/*Error near IL_0013: ldarg 3 (out-of-bounds)*/];
			/*Error near IL_0016: Unknown opcode: 0xF9*/;
		}
	}

	unsafe static FateCard_CloudBottle()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0003: Stack underflow*/ <= (int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
		if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xF0*/;
	}
}
