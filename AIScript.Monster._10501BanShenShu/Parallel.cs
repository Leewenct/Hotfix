using System;
using System.Collections.Generic;
using AIScript.Monster.Template;

namespace AIScript.Monster._10501BanShenShu;

public class Parallel : AIScript.Monster.Template.Parallel
{
	private const HotfixEnum.questCompleteCondClient achievementType_1 = HotfixEnum.questCompleteCondClient.BanShenShu_001;

	private const int killTeammateIndex_1 = 4;

	private const HotfixEnum.questCompleteCondClient achievementType_2 = HotfixEnum.questCompleteCondClient.BanShenShu_002;

	private const int notKillTeammateIndex_2 = 4;

	private const HotfixEnum.questCompleteCondClient achievementType_3 = HotfixEnum.questCompleteCondClient.BanShenShu_003;

	private readonly List<int> checkTeammateIndexList_3;

	private const HotfixEnum.questCompleteCondClient achievementType_4 = HotfixEnum.questCompleteCondClient.BanShenShu_004;

	private bool _achievementTypeFinish_1;

	private bool _achievementTypeFinish_2;

	private bool _canFinishAchievementType_2;

	private bool _achievementTypeFinish_3;

	private int _teammateCount_3;

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
		//Discarded unreachable code: IL_0086
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
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

	private unsafe void OnActorSpawn(IEvent evt)
	{
		//Discarded unreachable code: IL_002d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 2;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnActorDied(IEvent evt)
	{
		//Discarded unreachable code: IL_00fa
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Invalid metadata token*/;
		}
		/*Error near IL_0014: Unknown opcode: 0xEA*/;
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

	public unsafe Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
