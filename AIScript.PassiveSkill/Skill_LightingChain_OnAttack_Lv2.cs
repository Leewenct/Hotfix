using AIScript.Utils;
using TrueSync;

namespace AIScript.PassiveSkill;

public class Skill_LightingChain_OnAttack_Lv2 : SkillAdvancedBase
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

	private static readonly int _targetTag;

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

	public Skill_LightingChain_OnAttack_Lv2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected F4, but got I4
		((float[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[8] = 66f;
		_ = 6;
		/*Error near IL_0006: Unknown opcode: 0xF0*/;
	}

	unsafe static Skill_LightingChain_OnAttack_Lv2()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xE2*/;
	}
}
