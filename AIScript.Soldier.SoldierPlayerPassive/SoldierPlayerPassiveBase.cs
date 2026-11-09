namespace AIScript.Soldier.SoldierPlayerPassive;

public class SoldierPlayerPassiveBase : AIBase
{
	public void OnEnable()
	{
		/*Error: Invalid field token*/;
	}

	public void OnDisable()
	{
		/*Error: Invalid field token*/;
	}

	protected virtual void OnPlayerPassiveEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected virtual void OnPlayerPassiveDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe void OnBattleStart(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(int)(*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	protected virtual void OnPlayerPassiveBattleStart()
	{
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	protected virtual void OnOurSoldierCastSkill(SoldierActor actor, AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	public SoldierPlayerPassiveBase()
	{
		/*Error: Invalid field token*/;
	}
}
