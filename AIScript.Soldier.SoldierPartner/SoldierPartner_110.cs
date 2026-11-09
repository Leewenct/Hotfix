using System.Collections.Generic;
using TrueSync;

namespace AIScript.Soldier.SoldierPartner;

public class SoldierPartner_110 : SoldierPartnerBase
{
	private const int BuffId = 260111011;

	private static readonly FP ExtraRate;

	private static readonly FP EnergyBoostedRate;

	private const int MaxCastCount = 3;

	private const string Fx_Coin = "FX/Soldier/fx_soldier_base_coin_get";

	private static readonly FP Fx_Coin_Scale;

	private const HotfixEnum.ChessPartnerType partnerType = HotfixEnum.ChessPartnerType.LianHeZhongYe;

	private SoldierLevelController _levelCtrl;

	private List<SoldierActor> _actorBuffer;

	private List<(SoldierActor actor, FP delta)> _ratePatched;

	public int harvestCount;

	private int _castCount;

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
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected override void OnPartnerBattleStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
		}
	}

	protected override void OnOurSoldierCastSkill(SoldierActor actor, AdventureActorCastSkillEvent castSkillEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected I4, but got Unknown
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
		}
	}

	public unsafe SoldierPartner_110()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((ushort[])/*Error near IL_0004: Stack underflow*/)[*(*(byte**)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	static SoldierPartner_110()
	{
		/*Error: Unknown opcode: 0xF8*/;
	}
}
