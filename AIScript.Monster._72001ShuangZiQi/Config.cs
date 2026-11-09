using System;
using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster._72001ShuangZiQi;

public static class Config
{
	public static int cellSize;

	public static TSVector2 centerOffset;

	public static TSVector2 cellOffset;

	public static int mapSize;

	public static int cellCount;

	public static TSVector2 redBossPos;

	public static TSVector2 greenBossPos;

	public static Dictionary<int, GridColor> dicGridColor_1_2_AllWhite;

	public static Dictionary<int, GridColor> dicGridColor_1_2_Common;

	public static Dictionary<int, GridColor> dicGridColor_3_GreenBoss;

	public static Dictionary<int, GridColor> dicGridColor_3_RedBoss;

	public static int buffTag_red;

	public static int buffTag_green;

	public static Dictionary<int, List<int>> buffId_red;

	public static Dictionary<int, List<int>> buffId_green;

	public static Dictionary<int, List<int>> buffMaxCount;

	public static Dictionary<int, List<FP>> interval;

	public static int buffId_red_icon;

	public static int buffId_green_icon;

	public static string FX_W2G;

	public static string FX_W2R;

	public static string FX_R2W;

	public static string FX_R2G;

	public static string FX_G2W;

	public static string FX_G2R;

	public static string FX_Player_Red;

	public static string FX_Player_Green;

	public static Dictionary<int, List<TSVector2>> RedSoldierPositionList;

	public static Dictionary<int, List<TSVector2>> GreenSoldierPositionList;

	public static List<TSVector2> SoldierPositionListP3_1;

	public static List<TSVector2> SoldierPositionListP3_2;

	public static List<int> rowList;

	public static List<int> JumpTime_ez_List;

	public static List<int> JumpTime_hd_List;

	public static FP spawnScale;

	public static FP jumpScale;

	public static FP maxScale;

	public static Dictionary<int, List<TSVector2>> RedArtilleryPositionList;

	public static Dictionary<int, List<TSVector2>> GreenArtilleryPositionList;

	public static int BulletAmountBase_ez;

	public static int BulletAmountBase_hd;

	public static int ShootAmountBase;

	public static FP ShootAngle_ez;

	public static FP ShootAngle_hd;

	public static FP ArtilleryShootDurationBase;

	public static int ArtilleryShootCountBase;

	public static TSVector2 GeneralPosition_Red;

	public static TSVector2 GeneralPosition_Green;

	public static List<TSVector2> GeneralPosition_Red_P3;

	public static List<TSVector2> GeneralPosition_Green_P3;

	public static int SoldierAmount;

	public static FP SoldierIntervalTime_ez;

	public static FP SoldierIntervalTime_hd;

	public static FP GeneralAttackIntervalTime_P3;

	public static int GeneralAttackTime_P3;

	public static List<FP> UltraSkillTotalTime;

	public static List<int> UltraSkillAttackTimes;

	public static int BallCount_ez;

	public static int BallCount_hd;

	public static List<TSVector2> BallPosition_P3_1;

	public static List<TSVector2> BallPosition_P3_2;

	public static FP AttackTotalTime;

	public static List<int> BanList;

	public static Dictionary<int, List<TSVector2>> RedArtillery1PositionList;

	public static Dictionary<int, List<TSVector2>> GreenArtillery1PositionList;

	public static Dictionary<int, List<TSVector2>> RedArtillery1PositionList_P3;

	public static Dictionary<int, List<TSVector2>> GreenArtillery1PositionList_P3;

	public static FP Artillery1AttackInterval;

	public static FP Artillery1AttackInterval_P2;

	public static int Artillery1BossExtraAttackCount;

	public static Dictionary<int, List<TSVector2>> KnightsPositionList;

	public static FP General1AttackInterval;

	public static FP General1AttackInterval_P3;

	public static Dictionary<int, List<TSVector2>> RedLv6BallPositionList;

	public static Dictionary<int, List<TSVector2>> GreenLv6BallPositionList;

	public static int soldierAtkEvt;

	public static int generalAtkEvt;

	public static int artilleryAtkEvt;

	public static int carrierAtkEvt;

	public static int artillery1AtkEvt;

	public static int artillery1ExtraAtkEvt;

	public static int artillery1BulletHitEvt;

	public static int general1AtkEvt;

	public static int soldierSpawnEvt;

	public static int bollSpawnEvt;

	public static int ranseEvt;

	public static string Skill_Solider_Finish;

	public static string Skill_General_Finish;

	public static string Skill_Artillery_Finish;

	public static string Skill_Carrier_Finish;

	public static string Skill_RanSe_Finish;

	public static string Skill_GanRao_Finish;

	public static string Skill_Show_Finish;

	public static string Skill_Artillery2_Finish;

	public static string Skill_General3_Finish;

	public static TSVector2 GetCurIndexByPos(TSVector2 playerPOS)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static TSVector2 GetCellPosByIndex(int index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ != checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token for ldtoken instruction.*/;
	}

	public static TSVector2 GetCellPosByIndex(int x, int y)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ != /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/+ /*Error near IL_0007: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0009: Unknown opcode: 0xF1*/;
		}
	}

	public static TSVector2 GetCellPosByIndex(TSVector2 index)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static bool IsOutOfRange(int x, int y)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public static bool IsOutOfRange(TSVector2 index)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static int GetCellIndexByPos(TSVector2 playerPOS)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBF*/;
		}
	}

	public static int GetCellIndexByIndex(int x, int y)
	{
		((IntPtr[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (nint)((sbyte[])/*Error near IL_0002: Stack underflow*/)[checked((nuint)/*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public static int GetCellIndexByIndex(TSVector2 index)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	static Config()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}
}
