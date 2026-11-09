using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._13201;

public class SkillScript_Skill_Support : SkillAdvancedBase
{
	private const string actionTag = "132_Support_Skill";

	private const int perkId_23 = 513223;

	private const string eventName_Shoot_P23 = "132_P23_Shoot";

	private const string bulletPath_P23 = "Bullet_132_Support_P23";

	private readonly TSVector shootOffset_P23;

	private const int perkId_28 = 513228;

	private const string eventName_Shoot_P28 = "132_P28_Shoot";

	private readonly List<string> bulletPathList_P28;

	private readonly FP searchRadius_P28;

	private readonly TSVector shootOffset_P28;

	private List<LogicEntity> _targets_P28;

	protected override void OnSkillEnable()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public unsafe void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xAA*/;
	}

	private void OnCustomEvent(string eventName)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void OnFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
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
		}
	}

	private void OnInterrupt()
	{
		/*Error: Read out of bounds.*/;
	}

	protected override void OnSkillDisable()
	{
		/*Error: Invalid field token*/;
	}

	private void OnSearchTargetFinish_P28(List<LogicEntity> targets)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 212 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public SkillScript_Skill_Support()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}
}
