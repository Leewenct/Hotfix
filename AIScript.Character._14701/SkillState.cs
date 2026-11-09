using System;

namespace AIScript.Character._14701;

public class SkillState : IState
{
	public ActionKey actionKey;

	public SkillPhaseFeatureFlag skillPhaseFeatureFlag;

	public bool CanCast;

	public int specialSkill;

	public bool isInterruptAttack;

	public bool isRushJoinDodge;

	public bool ingoreCDAndEnergy;

	public override void Enter()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		((IntPtr[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = (IntPtr)0;
		/*Error near IL_0003: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public override void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		/*Error near IL_0003: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public void SetSkill(ActionKey actionKey, SkillPhaseFeatureFlag skillPhaseFeatureFlag, int specialSkill, bool isInterruptAttack, bool ingoreCDAndEnergy = false, bool isRushJoinDodge = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = ~(nint)1197537796;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	public SkillState()
	{
		/*Error: Read out of bounds.*/;
	}
}
