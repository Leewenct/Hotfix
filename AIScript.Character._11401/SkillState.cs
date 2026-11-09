using AdventureBehaviour;

namespace AIScript.Character._11401;

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
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (ushort)0;
			_ = -1;
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
			_ = ~(nint)1575680516;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	public override void Enter()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCE*/;
		}
	}

	public override void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCF*/;
		}
	}

	public override void Exit()
	{
		/*Error: Read out of bounds.*/;
	}
}
