using System.Collections.Generic;

namespace AIScript.Character._15801;

public class SummonedController
{
	protected PlayerAdventureActor _actor;

	private List<MonsterAdventureActor> _minionList;

	public SummonedController(PlayerAdventureActor actor)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xBC*/;
	}

	public virtual void OnEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public virtual void Init()
	{
	}

	private unsafe void OnSummonedSpawn(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ~(*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	protected virtual void OnSelfMinionSpawn(MonsterAdventureActor minion)
	{
	}

	private void OnMonsterDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected virtual void OnSelfMinionDied(MonsterAdventureActor minion)
	{
	}

	private void OnMinionCountChange()
	{
		//Discarded unreachable code: IL_003e, IL_0096
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void AddBuffToMinion(int buffId, int buffNum = 1)
	{
		//Discarded unreachable code: IL_0028
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Read out of bounds.*/;
		}
	}

	public void RemoveBuffFromMinion(int buffId, int reduceNum = 0)
	{
		//Discarded unreachable code: IL_0028
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Read out of bounds.*/;
		}
	}

	public virtual void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}
}
