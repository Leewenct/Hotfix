namespace AIScript.Soldier.SoldierPartner;

public class SoldierPartnerBase : AIBase
{
	public int partnerLv;

	public void OnEnable()
	{
		/*Error: Invalid field token*/;
	}

	public void OnDisable()
	{
		/*Error: Invalid field token*/;
	}

	protected virtual void OnPartnerEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected virtual void OnPartnerDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected virtual void OnPartnerBattleStart()
	{
	}

	protected bool IsSummoned(SoldierActor actor, out SoldierActor summoner)
	{
		//Discarded unreachable code: IL_003f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	protected virtual void OnCastSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	protected virtual void OnOurSoldierCastSkill(SoldierActor actor, AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	protected virtual void OnReceiveDamage(AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnRemoveBuff(IEvent evt)
	{
	}

	private unsafe void OnBattleStart(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(int)(*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnReceiveDamageEvt(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	public SoldierPartnerBase()
	{
		/*Error: Invalid field token*/;
	}
}
