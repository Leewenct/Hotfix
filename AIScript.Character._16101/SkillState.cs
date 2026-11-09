using AdventureBehaviour;

namespace AIScript.Character._16101;

public class SkillState : IState
{
	public ActionKey actionKey;

	public SkillPhaseFeatureFlag skillPhaseFeatureFlag;

	public bool CanCast;

	public int specialSkill;

	public bool isInterruptAttack;

	public bool ingoreCDAndEnergy;

	private bool isRushJoinDodge;

	public SkillState(AdventureActor actor, PlayerSkillCd skillManager, AimTarget aimTarget)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) ^ 0;
		/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
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
			_ = ~(nint)1029962244;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	public override void Enter()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) % 0;
		/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public override void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) % 0;
		/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public override void Exit()
	{
		/*Error: Read out of bounds.*/;
	}
}
