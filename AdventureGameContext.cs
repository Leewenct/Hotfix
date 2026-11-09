using System.Runtime.CompilerServices;

public static class AdventureGameContext
{
	private static AdventureModuleLevelLoadParams _levelLoadParam;

	private static bool _isIgnoreTimelinePerformanceLimit;

	public static AdventureModuleLevelLoadParams LevelLoadParam
	{
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		set
		{
			_levelLoadParam = value;
			AdventureGlobalState.IsStarTowerPrologue = value?.isStarTowerPrologue ?? false;
		}
	}

	public static AdventureAutoBattleConfig AutoBattleConfig
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		set;
	}

	public static GameTeamConfig TeamConfig
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		set;
	}

	public static bool IsTestBattle
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		set;
	}

	public static bool IsIgnoreTimelinePerformanceLimit
	{
		get
		{
			((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			return (byte)/*Error near IL_0007: Stack underflow*/ != 0;
		}
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	static AdventureGameContext()
	{
		/*Error: Invalid metadata token*/;
	}
}
