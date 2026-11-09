using System.Collections.Generic;
using AIScript.Monster.Template;
using TrueSync;

namespace AIScript.Monster._10005JiaMianYeZhu;

public class Parallel : AIScript.Monster.Template.Parallel
{
	private const HotfixEnum.questCompleteCondClient achievementType_1 = HotfixEnum.questCompleteCondClient.JiaMianYeZhu_001;

	private static readonly List<int> checkSkillId_1;

	private const HotfixEnum.questCompleteCondClient achievementType_2 = HotfixEnum.questCompleteCondClient.JiaMianYeZhu_002;

	private static readonly int checkHitTag_2;

	private const HotfixEnum.questCompleteCondClient achievementType_3 = HotfixEnum.questCompleteCondClient.JiaMianYeZhu_003;

	private static readonly List<int> checkSkillId_3;

	private static readonly FP checkTime_3;

	private static readonly int checkHitTag_3;

	private const int needHitTimes_3 = 3;

	private const HotfixEnum.questCompleteCondClient achievementType_4 = HotfixEnum.questCompleteCondClient.JiaMianYeZhu_004;

	private bool _achievementTypeFinish_1;

	private bool _achievementTypeFinish_2;

	private bool _canFinishAchievementType_2;

	private bool _achievementTypeFinish_3;

	private FP _checkStartTime_3;

	private int _hitTimes_3;

	private bool _achievementTypeFinish_4;

	private bool _canFinishAchievementType_4;

	public override void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
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

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnCastSkillEnd(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
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

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			throw 0;
		}
	}

	public Parallel()
	{
		/*Error: Invalid field token*/;
	}

	unsafe static Parallel()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAE*/;
	}
}
