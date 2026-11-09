using AdventureBehaviour;

namespace AIScript.Character._99901;

public class SkillState : IState
{
	public ActionKey actionKey;

	public SkillPhaseFeatureFlag skillPhaseFeatureFlag;

	public bool CanCast;

	public int specialSkill;

	public bool isInterruptAttack;

	public bool ingoreCDAndEnergy;

	private bool isRushJoinDodge;

	public unsafe SkillState(AdventureActor actor, PlayerSkillCd skillManager, AimTarget aimTarget)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = *(uint*)null;
			/*Error near IL_0004: Unknown opcode: 0xED*/;
		}
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
			_ = ~(nint)1010694660;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	public unsafe override void Enter()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (uint)(*(byte*)null);
			/*Error near IL_0004: Unknown opcode: 0xED*/;
		}
	}

	public unsafe override void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = (uint)(*(short*)null);
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public override void Exit()
	{
		/*Error: Read out of bounds.*/;
	}
}
