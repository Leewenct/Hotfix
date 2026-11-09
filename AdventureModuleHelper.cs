using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Nova.Hotfix;
using UnityEngine;
using UnityEngine.Playables;

public static class AdventureModuleHelper
{
	private static readonly List<long> _playerIds = new List<long>();

	private static readonly List<long> _monsterIds = new List<long>();

	private static readonly List<long> _trapIds = new List<long>();

	private static readonly List<long> _dynamicActorIds = new List<long>();

	private static AdventureTimeControlHandler _guideTimeControlHandler;

	public static bool showHPBar = true;

	public static bool showDMGNum = true;

	public static bool showDMG = true;

	public static bool showEffect = true;

	private static int _lastPanelId;

	public static int currentPanelid;

	public static long playerUid
	{
		get
		{
			_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			_ = 6;
			/*Error near IL_0002: Read out of bounds.*/;
		}
		set
		{
			PlayerContext.PlayerUid = value;
		}
	}

	public static int lastPanelId
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
			//IL_0002: Expected Obj, but got I4
			/*Error near IL_0001: Not a type handle*/;
		}
	}

	public static void SetSemiAutoBattleMode(bool enable)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetAutoCastUltimateSkill(bool enable)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if (!enable)
		{
			/*Error: Invalid branch target*/;
		}
	}

	public static List<Lua2CSharpInfo_SummonMonsterInfo> GetSummonMonsterInfos()
	{
		//Discarded unreachable code: IL_00da
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetSummonMonsters(List<Lua2CSharpInfo_SummonMonsterInfo> summonMonsterInfos)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)summonMonsterInfos < 8)
		{
		}
		/*Error near IL_0009: Invalid branch target*/;
	}

	public static void ResetActorAttributes(Lua2CSharpInfo_ActorAttribute[] attributes)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xFA*/;
		}
	}

	public static int GetPlayerActorStatus(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static long GetPlayerActorSpecialStatusTime(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static string GetPlayerActorLocalDataJson(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetPlayerActorAmmoType(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int[] GetPlayerActorAmmoCount(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static void ResetActorSkillInfo(MapField<int, RepeatedField<Lua2CSharpInfo_ResetSkillInfo>> skillInfos)
	{
		//Discarded unreachable code: IL_0007, IL_0050, IL_009d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (float)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static List<SkillInfo> GetActorSkillInfos(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static void ResetBuff(MapField<int, RepeatedField<Lua2CSharpInfo_ResetBuffInfo>> buffInfo)
	{
		//Discarded unreachable code: IL_0007, IL_0056
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public static List<BuffEntity> GetEntityBuffList(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ResetShield(int actorId, List<Lua2CSharpInfo_ReseShieldInfo> ShieldInfo)
	{
		//Discarded unreachable code: IL_0018
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static List<Lua2CSharpInfo_ReseShieldInfo> GetEntityShieldList(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static List<Lua2CSharpInfo_ReseShieldInfo> GetEntityShieldListForGM(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetRglTheme(int[] themes)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetFateCardThemes(Lua2CSharpInfo_FateCardThemeInfo[] fateCardThemes)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		/*Error near IL_0009: Invalid branch target*/;
	}

	public static void SetFateCardInfos(Lua2CSharpInfo_FateCardInfo[] fateCardInfos)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		/*Error near IL_0007: Invalid field token*/;
	}

	public static void UpdateFateCardInfos(Lua2CSharpInfo_FateCardInfo[] fateCardInfos)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		/*Error near IL_0007: Not a type handle*/;
	}

	public static void ChangeThemePerkIds(Lua2CSharpInfo_TPPerkInfo[] infos)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		_ = 7;
		/*Error near IL_0009: Invalid branch target*/;
	}

	public static void ChangePersonalPerkIds(Lua2CSharpInfo_TPPerkInfo[] infos, int actorId, bool change = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 216 (out-of-bounds)*/;
			_ = null;
			/*Error near IL_0004: Unknown opcode: 0xAA*/;
		}
	}

	public static void SetDiscInfo(Lua2CSharpInfo_DiscInfo[] discInfos)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		_ = 8;
		/*Error near IL_0009: Invalid branch target*/;
	}

	public static void SetNoteInfo(Lua2CSharpInfo_NoteInfo[] noteInfos)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = noteInfos % 8;
		/*Error near IL_0009: Invalid branch target*/;
	}

	public unsafe static void SetUnFinishedAchievementInfo(List<int> achievementInfos)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)8);
		/*Error near IL_0009: Invalid branch target*/;
	}

	public static void SetActorAttribute(int actorId, Lua2CSharpInfo_CharAttribute actorInfo)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetActorStatus(Lua2CSharpInfo_ActorStatus[] actorStatusInfos)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)actorStatusInfos < 8)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error: End of method reached without returning.*/;
	}

	public static void SetBuildLevel(int level)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if (level == 0)
		{
			/*Error: Invalid branch target*/;
		}
	}

	public static void SetActorAmmoInfos(Lua2CSharpInfo_ActorAmmoInfo[] actorAmmoInfos)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = actorAmmoInfos & 8;
		/*Error near IL_0009: Invalid branch target*/;
	}

	public static int SetActorEffect(int actorDataId, int effectId, int takeEffectLimit, long initCD, bool shareCD = true, bool shareTimes = true)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void RemoveActorEffect(int actorDataId, int effectUniqueId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static List<AdventureEffect> GetEffectList(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ResetBTalentAndStoneHeart()
	{
	}

	public static void SelectSupply(int effectId, bool revive)
	{
		// ILSpy could not decompile this member: Error decompiling @06001933 AdventureModuleHelper.SelectSupply: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06001933 AdventureModuleHelper.SelectSupply
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1237
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	public static long GetEntityHp(long entityId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 1;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public static int GetActorSkillCD(long id, int skillId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetActorSkillEnergy(long id, int skillId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetActorSkillSectionAmount(long id, int skillId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool CheckSkillAvailable(long id, int nSkillId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ForceSyncSkillBtnToLua(long id)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static List<long> GetCurrentGroupPlayers()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = 0;
		/*Error near IL_0004: Unknown opcode: 0xE8*/;
	}

	public static long GetCurrentActivePlayer()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static List<long> GetCurrentMonsters()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = 1;
		/*Error near IL_0004: Unknown opcode: 0xE8*/;
	}

	public unsafe static List<long> GetCurrentTraps()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = null;
		/*Error near IL_0004: Unknown opcode: 0xE8*/;
	}

	public unsafe static List<long> GetCurrentDynamicActors()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = -1;
		/*Error near IL_0004: Unknown opcode: 0xE8*/;
	}

	public static int GetCharacterId(long playerId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetHudDamageSourceGroup(long fromEntityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static long GetCharacterDamage(int actorDataId, bool isStage)
	{
		/*Error: Invalid metadata token*/;
	}

	public unsafe static long GetCharacterTotalDamage(int actorDataId)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		*(IntPtr*)actorDataId = (IntPtr)8;
		/*Error near IL_0009: Invalid branch target*/;
	}

	public static void ClearCharacterDamageRecord(bool isStage)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		/*Error near IL_0007: Unknown opcode: 0xEF*/;
	}

	public static long GetPlayerEntityId(int dataID)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static float GetPlayerAttributeValue(int dataID, HotfixEnum.playerAttributeType attributeType)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetPlayerAttributeValue(int dataID, HotfixEnum.playerAttributeType attributeType, int value, bool isIntFloat)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetEntityId(long monsterId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static long GetMonsterToughness(long monsterId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static long GetMonsterToughnessMax(long monsterId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetCurrentActorBindSkillId(long id, int actionKey)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static ActorInfo GetEntityInfo(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static ActorHealthInfo GetEntityHealthInfo(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static ActorElementInfo GetEntityElementInfo(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static ActorShield GetEntityShieldInfo(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static AmmoInfo GetEntityAmmoInfo(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static MonsterToughnessInfo GetEntityToughnessInfo(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static List<int> GetEntityEffectList(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static List<int> GetEntityEffectUniqueIdList(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int AddEntityEffectById(long entityId, int effectId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void RemoveEntityEffectById(long entityId, int effectId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void AddEntityBuffById(long entityId, int buffId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void RemoveEntityBuffById(long entityId, int buffId, bool reduceNum)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static PlayerSkillCd GetPlayerSkillCd(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static long GetEntityMaxHp(long entityId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 1;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public static bool GetEntityHaveBuffTimeReduce(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void GetEntityShieldValue(long entityId, out long shiledValue, out long shieldMax)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Read out of bounds.*/;
		}
	}

	public static bool GetEntityAlive(long entityId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 1;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public static int GetEntityAmmoMax(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetEntityAmmoCount(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetEntityBulletType(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static JointDrillBoss GetJointDrillBossData(long bossId, bool changeTeam, bool saveEnergy, bool saveResilience)
	{
		//Discarded unreachable code: IL_0068
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetJointDrillBossData(long bossId, JointDrillBoss data)
	{
		//Discarded unreachable code: IL_00a4
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void GetJointDrillBossEnergy(long bossId, out int mEnergy, out int cEnergy)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public static void SetRoguelikeChestData(Lua2CSharpInfo_RoguelikeChestInfo[] chests)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void Lua2CSharp_RoguelikeOpenTeleporter()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void Lua2CSharp_ChangeVisionAttackRange(bool enabled)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void EnterMainlineMap(int id, int[] team, int[] openedChest)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterBattleTestComboClipMap(int id, int[] team, int[] openedChest)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterProloguelMap(int id)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterProloguelBattleMap(int id, int[] team, int[] openedChest, bool isThreeP, Vector3 rPoint, List<string> btns, int boxID)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterDailyInstanceMap(int id, int[] team)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterEquipmentInstanceMap(int id, int[] team)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterInfinityTowerFloor(int id, int[] team, bool isContinue)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public unsafe static void InfinityTowerFloorEffects(int[] roomEffects)
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public static void EnterVampireFloor(int id, int[] team, bool isFirstHalf, int[] specialEnemySet, int[] treasureSet, bool isHalfBattle, VampireDropData[] dropData, bool isRestart = false)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public unsafe static void VampireFloorEffects(int[] roomEffects)
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public static void EnterScoreBossFloor(int id, int[] team)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterSkillInstanceMap(int id, int[] team)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterDynamic(int id, int[] team, int levelType, string[] levelParams)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterTowerDefenseLevel(int floorID, string[] levelParams)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterBrickBreakerLevel(int floorID, string[] levelParams)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void TowerDefense_SetTimeScale(int value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((double[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static void EnterAutoBattleClearPlayer()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void EnterAutoBattleBalance(int id, int[] team, float mainPlayerHPPre, int teamIndex)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterActivityLevelsInstance(int id, int[] team, string[] levelParams)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void EnterActivityStoryLevelsInstance(int id, int[] team)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void RefreshRoomEffects(List<int> roomEffects)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void FixedRoguelikeRoomEffects(List<int> effects)
	{
		/*Error: Invalid field token*/;
	}

	public static void EnterRogueBossMap(int id, int[] team, int bosslvId, int chestId, int isWeekBoss)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	public static void EnterTravelerDuel(int id, int floorId, int[] team, int[] affixes)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static void RoguelikeEnterNextFloor()
	{
		/*Error: Invalid metadata token*/;
	}

	public unsafe static void LevelStateChanged(bool isLevelFinish, float fadeTime = 0f, bool isFailOrAbandon = false)
	{
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = -1.1938129001812103E+38;
		/*Error near IL_000a: Unknown opcode: 0xEF*/;
	}

	public static void SetHudFollowTarget(long entityId, GameObject gameObject, Vector3 offset, bool head)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetBossIndicatorTarget(long entityId, GameObject gameObject, Vector3 offset)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool IsPlayerGroup(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetHudValue(GameObject gameObject, long entityId, int id, long val, bool isHeal, HitDamage hitDamage, long formEntityId, bool isCrit, bool isDot, int fromElementType, int hudColorIndex)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void RefreshHudValue(GameObject gameObject, long val, int hudColorIndex)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetHudStringValue(GameObject gameObject, long entityId, int id, string val, int valType, bool useVariant)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetHudToughnessDamageValue(GameObject gameObject, long entityId, int id, string val, bool useVariant, bool isChange)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static float GetHudOffsetWidth(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static float GetHudOffsetHeight(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static float GetEntityColliderHeight(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static float GetEntityMonsterBarHeight(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static float GetEntityColliderWidth(long entityId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void PlaySettlementPerform(string scenePath, string outfitSoundStateName, int[] actorIds, Action<bool> callBack)
	{
		/*Error: Unknown opcode: 0xEE*/;
	}

	public static void PlayTeamUpgradeFX()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void LeaveAdventure()
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public unsafe static GameObject SpawnPrefabInstance(GameObject prefab, string poolName, GameObject parent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(int*)checked((int)/*Error near IL_0007: Stack underflow*/);
		_ = 8;
		/*Error near IL_000b: Unknown opcode: 0xE3*/;
	}

	public static void DespawnPrefabInstance(GameObject instance, string poolName)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public static void PauseLogic()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ResumeLogic()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ExitSelectTeam()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void OpenActiveTeleporter()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void OpenTreasureAndNpcNew(List<int[]> prizeList, bool showNpc)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static List<Transform> GetLevelTeleporters()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool CheckTimelineClipFinish(PlayableDirector director, string clipName)
	{
		//Discarded unreachable code: IL_0030, IL_0055
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static void SetMiniMapFeatureActive(bool active)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and Obj
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if ((object)/*Error near IL_0001: ldloca 214 (out-of-bounds)*/ != null)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	public static void SetMapCameraActive(bool active)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and Obj
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if ((object)/*Error near IL_0001: ldloca 214 (out-of-bounds)*/ != null)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	public static RenderTexture GetMiniMapRenderTexture()
	{
		/*Error: Invalid metadata token*/;
	}

	public static RenderTexture GetMapRenderTexture()
	{
		/*Error: Invalid metadata token*/;
	}

	public static void SetDirectorState(string directorPath, bool isPause)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)0u;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public static void PausePerformTimeline()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ResumePerformTimeline()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void StopPerformTimeline()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void PausePlayableDirector(bool isPause)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void StopPlayableDirector()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool GetFirstSlotPlayer(out int dataId, out long playerId)
	{
		// ILSpy could not decompile this member: Error decompiling @060019A1 AdventureModuleHelper.GetFirstSlotPlayer: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @060019A1 AdventureModuleHelper.GetFirstSlotPlayer
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeCall(OpCode opCode) in ILReader.cs:line 1760
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 879
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	public static bool GetSecondSlotPlayer(out int dataId, out long playerId)
	{
		// ILSpy could not decompile this member: Error decompiling @060019A2 AdventureModuleHelper.GetSecondSlotPlayer: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @060019A2 AdventureModuleHelper.GetSecondSlotPlayer
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeCall(OpCode opCode) in ILReader.cs:line 1760
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 879
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	public static void SetGuideLogicTimeScale(int val)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public static void EnterViewSceneLevel(int levelType, int id, int[] teamIDs, bool isViewSceneMode = true, int starTowerFloorSetID = 0, int prefabID = 0, string prefabExtension = "", int playType = 0, bool sceneDoMir = false)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public static List<AdventureModuleController.BattleSample> GetBattleSamples(string fileName)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void EnterStarTowerTestMap(Lua2CSharpInfo_FixedRoguelike info)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void EnterStarTowerMap(int difficulty, bool battleEnd, bool isFinal, int[] DropInfo, int NextStageType)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetDamageRecordId(string id)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int RandomStarTowerMap(Lua2CSharpInfo_FixedRoguelike info, out int floorID, out string extension, out int scenePrefabID)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public static void LogStarTowerMap(int curSavedMapCount, int mapType, long mapId, bool bEnter, bool bReenter)
	{
	}

	public static void SpawnNPC(int npcDataID, int npcSkinID)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetProloguelBattleMsg(List<string> btns)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static void UpdateUIPanlelId(int PanelId)
	{
		//IL_0005: Expected I4, but got F4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		float num = *(long*)(int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/);
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)num;
		/*Error near IL_0005: stloc 141 (out-of-bounds)*/;
		_ = /*Error near IL_0009: Stack underflow*/>> (int)checked((sbyte)/*Error near IL_0008: Stack underflow*/);
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public static ActorInfo GetSoldierActorInfo(int dataId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static ActorHealthInfo GetSoldierHealthInfo(int dataId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void Lua2CSharp_GMOrder_OpenFrameShow(bool show)
	{
	}

	public static void Lua2CSharp_GMOrder_SetGameFrame(int renderFrame)
	{
	}

	public static void Lua2CSharp_GMOrder_JumpoverCurLevel()
	{
	}

	public static void Lua2CSharp_GMOrder_SetMonsterSkill(int monsterID, int skillID)
	{
	}

	public static void Lua2CSharp_GMOrder_ChangeMonsterAIState(int monsterID, bool startOrStop)
	{
	}

	public static void Lua2CSharp_GMOrder_MonsterPlaySkill(int monsterID, int skillID, int loopTimes)
	{
	}

	public static void Lua2CSharp_GMOrder_SpawnMonster(int monsterID, int spawnNum)
	{
	}

	public static void Lua2CSharp_GMOrder_SetIndicatorMode(int value1, int value2, int value3, int value4)
	{
	}

	public static void Lua2CSharp_SwichTarget()
	{
	}

	public static void Lua2CSharp_GMOrder_SetTimeScale(int value)
	{
	}

	public static void Lua2CSharp_GMOrder_KillCurChar()
	{
	}

	public static void Lua2CSharp_GMOrder_SetCurCharResidualHp()
	{
	}

	public static void Lua2CSharp_GMOrder_AddCurCharAttack()
	{
	}

	public static void Lua2CSharp_GMOrder_KillCurMonsters()
	{
	}

	public static void Lua2CSharp_GMOrder_KillMonstersByActorId(int actorId)
	{
	}

	public static void Lua2CSharp_GMOrder_KillMonstersById(int id)
	{
	}

	public static void Lua2CSharp_GMOrder_SkipLevel()
	{
	}

	public static void Lua2CSharp_GMOrder_ChangeAllCharDef(bool active)
	{
	}

	public static void Lua2CSharp_GMOrder_UltimateIgnoreCDAndEnergy(bool active)
	{
	}

	public static void Lua2CSharp_GMOrder_SetEntityMoveSpeedPercent(long entityId, int moveSpeedPercent)
	{
	}

	public static void Lua2CSharp_GMOrder_FastCD(bool active, long entityId)
	{
	}

	public static void Lua2CSharp_GMOrder_Revive()
	{
	}

	public static void Lua2CSharp_GMOrder_ChangeAttribute(long entityId, int firstSubType, int secondSubType, float value)
	{
	}

	public static string Lua2CSharp_GMOrder_StarTowerConfigExtension()
	{
		/*Error: Stack underflow*/;
		_ = 8;
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public static int Lua2CSharp_GMOrder_StarTowerGameplayType()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public static int Lua2CSharp_GMOrder_StarTowerScenePrefabId()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public static int Lua2CSharp_GMOrder_StarTowerFloorSetRoomType()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public static int GMOrder_GetMonsterLevel(long Id)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public static int GMOrder_ConvertAttributeTypeAndElementTypeToKey(HotfixEnum.effectAttributeType attributeType, HotfixEnum.elementType elementType)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public static int GMOrder_ConvertAttributeTypeAndDamageTypeToKey(HotfixEnum.effectAttributeType attributeType, HotfixEnum.damageType damageType)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public static float GMOrder_GetAttributeValueWithElementOrDamageType(long entityId, HotfixEnum.effectAttributeType attributeType, HotfixEnum.elementType elementType, HotfixEnum.damageType damageType)
	{
		_ = ((short[])/*Error near IL_0002: Stack underflow*/)[((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]];
		/*Error near IL_0002: Read out of bounds.*/;
	}
}
