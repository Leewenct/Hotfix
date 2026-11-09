using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Soldier.SoldierPartner;

public class SoldierPartner_126 : SoldierPartnerBase
{
	private enum MoraleKind
	{
		AtkSpd,
		Energy,
		AddHp,
		Def,
		DefPen,
		Default
	}

	private readonly struct Commander
	{
		public readonly int dataId;

		public readonly MoraleKind kind;

		public readonly MoraleKind kind2;

		public Commander(int dataId, MoraleKind kind, MoraleKind kind2 = MoraleKind.Default)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			}
			_ = -(nint)(-2015167996);
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	private readonly struct MoraleCfg
	{
		public readonly int buffAtkSpd;

		public readonly FP energyPercent;

		public readonly int buffHp;

		public readonly int buffDef;

		public readonly int buffDefPen;

		public MoraleCfg(int buffAtkSpd, FP energyPercent, int buffHp, int buffDef, int buffDefPen)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			}
			_ = -(nint)(-2014971388);
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	private readonly struct LevelCfg
	{
		public readonly MoraleCfg morale;

		public readonly MoraleCfg chiefMorale;

		public LevelCfg(MoraleCfg morale, MoraleCfg chiefMorale)
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public HotfixEnum.ChessPartnerType partnerTypes;

	private static readonly Commander[] commanders;

	private readonly LevelCfg[] _levelCfg;

	private const int BUFF_ID_COMMANDER_FX = 260112671;

	private const int BUFF_ID_CHIEF_FX = 260112671;

	private const int SUPPRESS_MIN = 2;

	private const int SUPPRESS_MAX = 3;

	private const int CHIEF_MIN_LV = 2;

	private const string MORALE_FX_PATH = "FX/Soldier/fx_soldier_base_commander";

	private static readonly TSVector2 moraleFxPosition;

	private static readonly FP moraleFxPositionY;

	private static readonly FP moraleFxAngle;

	private const float moraleFxScale = 1f;

	private SoldierLevelController _levelCtrl;

	private readonly List<SoldierActor> _commanderBuffer;

	private readonly List<SoldierActor> _followerBuffer;

	private SoldierActor _pendingEnergyActor;

	private int _pendingEnergyAmount;

	private bool _isApplying;

	protected override void OnPartnerEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (sbyte)0;
		}
	}

	protected override void OnPartnerDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (short)0;
		}
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
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
		}
	}

	protected override void OnOurSoldierCastSkill(SoldierActor actor, AdventureActorCastSkillEvent castSkillEvent)
	{
		//Discarded unreachable code: IL_0097
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected I4, but got Unknown
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
		}
	}

	private unsafe void ApplyCommanderMorale(SoldierActor commander, MoraleKind kind, MoraleKind kind2, MoraleCfg cfg)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF2*/;
	}

	private void ApplyChiefMorale(SoldierActor commander, MoraleCfg cfgper, MoraleCfg cfg)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0037: Expected F8, but got I4
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			checked
			{
				_ = (nuint)/*Error near IL_000a: Stack underflow*/;
				/*Error near IL_000a: Unknown opcode: 0xBE*/;
			}
		}
		((double[])/*Error near IL_0037: Stack underflow*/)[/*Error near IL_0037: Stack underflow*/] = 4.0;
		if (/*Error near IL_0039: Stack underflow*/ > /*Error near IL_0039: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 4;
		/*Error near IL_003a: Unknown opcode: 0xB2*/;
	}

	private void ApplyMorale(SoldierActor target, MoraleKind kind, MoraleCfg cfg, SoldierActor commander)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid field token*/;
		}
	}

	private SoldierActor PickChief(SoldierActor anchor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected I4, but got Unknown
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
		}
	}

	private int CountBattleCommanders(SoldierActor anchor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I4, but got Unknown
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
		}
	}

	private int GetTotalCostSafe(SoldierActor actor)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private static IList<int> GetPartnerTags(int dataId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private bool ShareOtherPartnerTag(IList<int> commanderTags, int followerDataId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private bool IsFollowerCandidate(SoldierActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	private static bool IsCommander(int dataId)
	{
		/*Error: Invalid metadata token*/;
	}

	private static bool TryGetMoraleKind(int dataId, out MoraleKind kind, out MoraleKind kind2)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void AddBuff(SoldierActor target, int buffId, SoldierActor fromActor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private void AddEnergyByPercent(SoldierActor target, FP percent, SoldierActor caster)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private unsafe void PlayMoraleFx()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unsupported input type for neg.
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unsupported input type for neg.
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (checked((nuint)unchecked((int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))) == 0)
		{
			((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)/*Error near IL_0005: Stack underflow*/;
			if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
			{
				do
				{
					((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
				}
				while (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/);
			}
			_ = -checked(/*Error near IL_000b: Stack underflow*/ - /*Error near IL_0008: ldloca 20 (out-of-bounds)*/);
			/*Error near IL_000c: Unknown opcode: 0xFD*/;
		}
		_ = 0 - (Nullable)checked(/*Error near IL_000b: Stack underflow*/ - null);
		/*Error near IL_000c: Unknown opcode: 0xFD*/;
	}

	public unsafe SoldierPartner_126()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I8
		if ((long)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 3458835489978040037L)
		{
			/*Error: Invalid branch target*/;
		}
		*(_003F*)(nint)/*Error near IL_0010: Stack underflow*/ = /*Error near IL_0010: Stack underflow*/;
		/*Error near IL_0010: Unknown opcode: 0xEB*/;
	}

	static SoldierPartner_126()
	{
		/*Error: Unknown opcode: 0xEF*/;
	}
}
