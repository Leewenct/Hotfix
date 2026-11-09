using System.Collections.Generic;
using TrueSync;

namespace AIScript.DynamicLevel;

public class TutorialLevelProcess_SupportOperation : TutorialLevelProcessBase
{
	private readonly int buffId_Room;

	private readonly Dictionary<int, string> operationTipsDic;

	private readonly Dictionary<int, FP> waitTimeDic;

	private readonly int tutorialCardId_SupportSkill;

	private readonly int buffId_SupportSkill;

	private readonly string monsterSpawnWave_SupportSkill;

	private readonly int tutorialCardId_SupportUltraSkill;

	private readonly int buffId_SupportUltraSkill;

	private readonly string monsterSpawnWave_SupportUltraSkill_1;

	private readonly string monsterSpawnWave_SupportUltraSkill_2;

	private readonly int monsterCount_TriggerSecondWave;

	public override void OnLevelStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 2400906463u + 1680036392u;
		}
	}

	public override void OnTriggerNextTask(int taskId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1680036867;
		}
	}

	protected override void OnRoomWaveMonsterCleared(AdventureLevelRoomWaveMonsterClearedEvent waveClearEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b->IL000b: Incompatible stack heights: 1 vs 0
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = -68;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_000c: Stack underflow*/ >> unchecked((int)/*Error near IL_000c: Stack underflow*/));
		}
	}

	public unsafe override void OnTaskFinish(int taskId, bool isLastTask = false)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 7;
		_ = 4;
		/*Error near IL_0003: Invalid field token*/;
	}

	public override void OnLevelEnd()
	{
		/*Error: Invalid field token*/;
	}

	public unsafe TutorialLevelProcess_SupportOperation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = *(ushort*)8;
		/*Error near IL_0003: Invalid metadata token*/;
	}
}
