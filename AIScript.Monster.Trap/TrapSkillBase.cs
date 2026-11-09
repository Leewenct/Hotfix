using System.Collections.Generic;

namespace AIScript.Monster.Trap;

public class TrapSkillBase : SkillSimpleBase
{
	private TrapAdventureActor trapActor;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid branch target*/;
		}
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (false)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void OnTrapActive(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF8*/;
	}

	public void FilterActor(List<DeterministicCollider> result)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public unsafe bool FilterMonsterByTag(AdventureActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void OnTrapActive(AdventureTrapActive evt)
	{
	}

	public TrapSkillBase()
	{
		/*Error: Invalid field token*/;
	}
}
