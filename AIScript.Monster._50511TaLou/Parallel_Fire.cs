using AIScript.Monster.Template;
using TrueSync;

namespace AIScript.Monster._50511TaLou;

public class Parallel_Fire : Parallel
{
	private static readonly FP HpPercentStage2;

	private static readonly FP HpPercentStage3;

	private static readonly int Stage3SkillId;

	private bool ChangeStage2;

	private bool ChangeStage3;

	private const HotfixEnum.questCompleteCondClient achievementType_1 = HotfixEnum.questCompleteCondClient.HuoTaLou_001;

	private const HotfixEnum.questCompleteCondClient achievementType_2 = HotfixEnum.questCompleteCondClient.HuoTaLou_002;

	private const string logicTag_Hit_2 = "Achievement";

	private const string logicTag_HitPosition_2 = "HitPosition";

	private bool _achievementTypeFinish_1;

	private bool _canFinishAchievementType_1;

	private bool _achievementTypeFinish_2;

	public override void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected override void OnInitState()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			throw 0;
		}
	}

	private unsafe void OnHpChange(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)(*unchecked((int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	protected override void OnSwitchState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0L;
			/*Error near IL_0003: Unknown opcode: 0xE1*/;
		}
	}

	private void InitAchievementData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void OnReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnTriggerPerfect(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	private unsafe void OnDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private bool SetAchievementState(HotfixEnum.questCompleteCondClient achievementType)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public Parallel_Fire()
	{
		/*Error: Invalid field token*/;
	}

	static Parallel_Fire()
	{
		/*Error: Unknown opcode: 0xF8*/;
	}
}
