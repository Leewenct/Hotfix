using AIScript.Utils;
using TrueSync;

namespace AIScript.PassiveSkill;

public class Skill_LightingChain_OnBeAttack : SkillAdvancedBase
{
	private readonly int _hitDamageId;

	private readonly string _hitFxPath;

	private readonly int _hitDamageId_for_secend;

	private readonly string _hitFxPath_for_secend;

	private readonly FP _doubleHitInterval;

	private readonly FP _linkHitInterval;

	private readonly FP _linkCheckRange;

	private readonly int _maxLinkTime;

	private readonly FP _maxCoolingTime;

	private readonly FP _executeRate;

	private Skill_LightingChain _lightingChain;

	protected override void OnSkillEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected override void OnSkillDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe void OnDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	public Skill_LightingChain_OnBeAttack()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (sbyte)8;
			/*Error near IL_0003: Unknown opcode: 0xFD*/;
		}
	}
}
