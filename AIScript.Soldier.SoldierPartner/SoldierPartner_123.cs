using System.Collections.Generic;
using TrueSync;

namespace AIScript.Soldier.SoldierPartner;

public class SoldierPartner_123 : SoldierPartnerBase
{
	public HotfixEnum.ChessPartnerType partnerTypes;

	private const int buffId_ZhuiLie = 260112311;

	private const int buffId_ZhuiLie2 = 260112312;

	private static readonly FP energyChargePercent_2;

	private const int ENERGY_MIN_LV = 2;

	private SoldierLevelController _levelCtrl;

	private readonly List<SoldierActor> _memberBuffer;

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

	private unsafe void OnActorDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	protected override void OnOurSoldierCastSkill(SoldierActor actor, AdventureActorCastSkillEvent castSkillEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Not a type handle*/;
	}

	public SoldierPartner_123()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = -1870611719059620126L;
			/*Error near IL_000a: Invalid branch target*/;
		}
	}

	static SoldierPartner_123()
	{
		/*Error: Unknown opcode: 0xF8*/;
	}
}
