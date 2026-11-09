using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using Coffee.UIEffects;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

public static class NovaAPI
{
	private static readonly Dictionary<string, int> RecorderKeys = new Dictionary<string, int>();

	public static string ApplicationDataPath
	{
		get
		{
			_ = (short)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	public static string StreamingAssetsPath
	{
		get
		{
			_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	public static Dictionary<string, string[]> dictL2DFallbackOrder
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
			/*Error: Invalid field token*/;
		}
	}

	public static string TOKEN
	{
		get
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
		set
		{
			if ((Object)(object)MonoSingleton<HttpNetworkManager>.Instance != (Object)null)
			{
				MonoSingleton<HttpNetworkManager>.Instance.TOKEN = value;
			}
		}
	}

	public static ServerListInfo ServerListInfo
	{
		get
		{
			if (!((Object)(object)MonoSingleton<HttpNetworkManager>.Instance == (Object)null))
			{
				return MonoSingleton<HttpNetworkManager>.Instance.serverInfo;
			}
			return null;
		}
	}

	public static float GetGlobalTimeScale()
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	public static float GetLogicTimeScale()
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	public static float GetLogicTime()
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	public static float GetLogicUnscaledTime()
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	public static float GetLogicDeltaTime()
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	public static float GetLogicUnscaledDeltaTime()
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	public static string GetNotificationSettings()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/>> (int)/*Error: Stack underflow*/;
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public static bool IsInputEnabled()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void InputEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void InputDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetTouchScreenSupport(bool val)
	{
		CrossPlatformInputManager.SetTouchScreenSupport(val);
	}

	public static void SetNormalSupport(bool val)
	{
		CrossPlatformInputManager.SetNormalSupport(val);
	}

	public static void RegisterVirtualJoystick(string x, string y, GameObject go)
	{
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCE*/;
	}

	public static void RegisterVirtualButton(string buttonName, GameObject go)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public static void RegisterRealButton(string buttonName, float holdThreshold)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public static void RegisterRealAxisButton(string buttonName, float holdThreshold, float pressThreshold)
	{
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCE*/;
	}

	public static void RegisterRealMouseButton(string buttonName, float holdThreshold)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public static void UnRegisterVirtualJoystick(string x, string y)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public static void UnRegisterVirtualButton(string buttonName)
	{
		/*Error: Invalid field token*/;
	}

	public static void UnRegisterRealButton(string buttonName)
	{
		/*Error: Invalid field token*/;
	}

	public static void UnRegisterRealAxisButton(string buttonName)
	{
		/*Error: Invalid field token*/;
	}

	public static void UnRegisterRealMouseButton(string buttonName)
	{
		/*Error: Invalid field token*/;
	}

	public static void SetRealButtonActive(string name, bool active)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public static void AddRecorderKey(string key, int val)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
		}
		if ((int)/*Error near IL_0007: Stack underflow*/ >= (int)((short[])/*Error near IL_0005: Stack underflow*/)[-1])
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: ldarg 2 (out-of-bounds)*/;
		_ = 8;
		/*Error near IL_000b: Unknown opcode: 0x78*/;
	}

	public static bool GetRecorderKey(string key, out int val)
	{
		/*Error: Invalid field token*/;
	}

	public static void SetRecorderFloorId(int floorId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetRecorderExcludeIds(List<int> excludeIds)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void StopRecord()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetBuglyPlayerUid(string uid)
	{
		if ((Object)(object)MonoSingleton<GameBuglyManager>.Instance != (Object)null)
		{
			MonoSingleton<GameBuglyManager>.Instance.SetPlayerUid(uid);
		}
	}

	public unsafe static void SendLogsToFeishu(string name, Action onSuccessCallback, Action<string> onErrorCallback)
	{
		_ = checked((uint)(*unchecked((int*)(nint)/*Error near IL_0001: Stack underflow*/))) >> (int)onSuccessCallback;
		/*Error near IL_0004: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0007: Not a type handle*/;
	}

	public static AchievementManager.AchievementDataDic GetAchievementData()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool IsDirtyWordsInit()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void InitDirtyWords()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ShutdownDirtyWords()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool IsDirtyString(string inputString)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public static bool IsChannelString(string inputString)
	{
		/*Error: Invalid field token*/;
	}

	public static bool IsBinFormatEnabled()
	{
		return GameDataController.binFormatEnabled;
	}

	public static void LoadAllDataTable(string languageType)
	{
		GameDataController instance = Singleton<GameDataController>.Instance;
		if (instance != null)
		{
			instance.Load(languageType);
		}
	}

	public static void UnLoadAllDataTable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static string LoadTextData(string filepath)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static string LoadTableData(string filepath)
	{
		GameDataController instance = Singleton<GameDataController>.Instance;
		if (instance == null)
		{
			return null;
		}
		return instance.LoadTableData(filepath);
	}

	public static void LoadCommonBinData(string filepath, LuaTable tab)
	{
		GameDataController instance = Singleton<GameDataController>.Instance;
		if (instance != null)
		{
			instance.LoadCommonBinData(filepath, tab);
		}
	}

	public static string GetCurrentModuleName()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void EnterModule(string moduleName, bool clearHistory, int loadingType = 3, Action callback = null)
	{
		if ((Object)(object)MonoSingleton<GameController>.Instance != (Object)null)
		{
			MonoSingleton<GameController>.Instance.EnterModule(moduleName, clearHistory, loadingType, callback);
		}
	}

	public static void ExitCurrentModule()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void GetLoadParam(out AdventureModuleLevelLoadParams.BootConfigLoadType loadType, out string mapId, out string id, out int floor, out List<int> actors, out List<FixedRoguelikeRoomData> fixedRoguelikeRoomData, out int[] affixes, out int[] breakCounts, out int[] levels, out int stageId, out List<OutfiInfo> outfitList, out bool isVampireFirstHalf, out List<NoteInfo> noteList, out List<int> skins)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public static int GetDynamicLevelTypeBootConfig()
	{
		/*Error: Invalid metadata token*/;
	}

	public static string[] GetDynamicLevelParamsBootConfig()
	{
		/*Error: Invalid metadata token*/;
	}

	public static HotfixEnum.elementType GetAutoBattleBalanceEET()
	{
		/*Error: Invalid metadata token*/;
	}

	public static List<ABTeam> GetAutoBattleBalanceConfigTeam()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ExitGame()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetEntryLevelFade(bool isFade)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool GetEntryLevelFade()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static string GetClientChannel()
	{
		return ClientConfig.ChannelName;
	}

	[Obsolete]
	public static string GetClientChannelName()
	{
		/*Error: Invalid metadata token*/;
	}

	public static string GetServerLoginName()
	{
		return ClientConfig.CurrentVendorEnvData.serverLoginName;
	}

	public static string GetServerChannelName()
	{
		/*Error: Invalid metadata token*/;
	}

	public static byte[] LoadLuaBytes(ref string filepath)
	{
		if (!((Object)(object)MonoSingleton<LuaManager>.Instance == (Object)null))
		{
			return MonoSingleton<LuaManager>.Instance.LoadBytes(ref filepath);
		}
		return null;
	}

	public static bool IsMobilePlatform()
	{
		return Application.isMobilePlatform;
	}

	public static void OpenURL(string url)
	{
		/*Error: Invalid field token*/;
	}

	public static bool IsRuntimeWindowsPlayer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/^ /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public static bool IsEditorPlatform()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		if ((int)Application.platform != 7)
		{
			return (int)Application.platform == 0;
		}
		return true;
	}

	public static string GetDeviceId()
	{
		string text = "";
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			for (int i = 0; i < allNetworkInterfaces.Length; i++)
			{
				byte[] addressBytes = allNetworkInterfaces[i].GetPhysicalAddress().GetAddressBytes();
				string text2 = null;
				for (int j = 0; j < addressBytes.Length; j++)
				{
					text2 = string.Concat(text2 + string.Format("\uf395辨箣", addressBytes[j].ToString("坘ʏ")));
					if (j != addressBytes.Length - 1)
					{
						text2 = string.Concat(text2 + "宭");
					}
				}
				text += text2;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
			text = "嶓\u00b8\uf42el";
		}
		return text;
	}

	public static string GetClientVersion()
	{
		return MonoSingleton<ClientManager>.Instance.GetPublicVersion((string)null);
	}

	public static string GetResVersion()
	{
		/*Error: Invalid metadata token*/;
	}

	public static bool IsReviewServerEnv()
	{
		return ClientConfig.IsReviewServerEnv;
	}

	public static bool DispatchEventWithData(string type, object sender, object data)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static void PlayGachaOpenDoor(GameObject go, int rare, int type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static void PlayGachaDisc(GameObject go, int type, int rare, bool sup)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static void PlayCustomVideo(GameObject go, string[] path, bool[] loop, bool[] canJump, int[] closeIdx, int[] reopenIdx, bool[] showEft)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static void PlayVideo(GameObject goPlayerVideo, string[] videoFileNameOrder, string[] soundTrackNameOrder, string[] srtFileNameOrder, bool bDebugLog = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetL2DAnimFallbackRules(string sJson)
	{
		NovaCoreAPI.SetL2DAnimFallbackRules(sJson);
	}

	public unsafe static float PlayL2DCGAnim(Transform tr)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xAC*/;
	}

	public static void BindL2dColorController(GameObject goController, GameObject goL2d)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void UnBindL2dColorController(GameObject goController)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetL2DTimeState(bool isUnscledTime)
	{
		/*Error: Invalid field token*/;
	}

	public static int GetMaskTextureSize()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xAB*/;
	}

	public static void SetMaskTextureSize(int size)
	{
		/*Error: Invalid field token*/;
	}

	public static int GetMaskFilterMode()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xEB*/;
	}

	public static void SetMaskFilterMode(int mode)
	{
		/*Error: Invalid field token*/;
	}

	public static int GetMaskMaxRenderTextureCount()
	{
		//IL_0004: Invalid comparison between Unknown and I4
		if (((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)((short[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/])
		{
			/*Error: Invalid branch target*/;
		}
		/*Error: End of method reached without returning.*/;
	}

	public static void SetMaskMaxRenderTextureCount(int count)
	{
		/*Error: Invalid field token*/;
	}

	public static int GetMaskRenderTextureCount()
	{
		_ = (double)(int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public static int GetMaskTotalUsedCount()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Not a type handle*/;
	}

	public static void DisposeMaskTexture()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xAC*/;
	}

	public static string CompressString(string str)
	{
		_ = 3;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	public unsafe static string CompressBytes(byte[] bytes)
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public unsafe static byte[] DecompressString(string str)
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public unsafe static string ParseStarTowerData(StarTowerTempData data)
	{
		throw *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
	}

	public static StarTowerTempData DecodeStarTowerData(string jsonStr)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public static string ParseStarTowerDataCompressed(StarTowerTempData data, out int length)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB2*/;
		}
	}

	public static StarTowerTempData DecodeStarTowerDataCompressed(string str)
	{
		//Discarded unreachable code: IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public static long GetJointDrillBossMaxHp(int monsterId, int difficulty)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static JointDrillTempData DecodeJointDrillData(string jsonStr)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public static string ParseJointDrillDataCompressed(JointDrillTempData data, out int length)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB2*/;
		}
	}

	public static JointDrillTempData DecodeJointDrillDataCompressed(string str)
	{
		//Discarded unreachable code: IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public static void ShowGMMonsterAI(long monsterId)
	{
	}

	public static void SetBuildReportInfo(string buildJson, string buildName, BuildCharData[] buildCharData, BuildDiscData[] buildDiscData, int[] secondarySkills, int[][] notes)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void TryUploadFile()
	{
		MonoSingleton<RankFileUploaderManager>.Instance.UploadCachedReport();
	}

	public static void UploadStartowerFile(string token, string reportId)
	{
		/*Error: Invalid metadata token*/;
	}

	public static void DeleteRecFile(string reportId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 214 (out-of-bounds)*/;
		}
		if ((int)/*Error near IL_0008: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
	}

	public static void SetReportUrl(string url)
	{
		MonoSingleton<RankFileUploaderManager>.Instance.SetUrl(url);
		MonoSingleton<RankFileUploaderManager>.Instance.UploadCachedReport();
	}

	public static void UserEventUpload(string strEventName, List<List<string>> parameter)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < parameter.Count; i++)
		{
			List<string> list = parameter[i];
			dictionary.Add(list[0], list[1]);
		}
		MonoSingleton<SDKManager>.Instance.UserEventUpload(strEventName, dictionary);
	}

	public unsafe static void ChangeAnimatorDefaultState(Transform rt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		int num = (int)/*Error near IL_0003: Stack underflow*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static void GuideProloguelSkill()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool IsLQA()
	{
		return Singleton<GameDataController>.Instance.isLQA;
	}

	public static void SetLQA(bool lqa)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if (!lqa)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: Read out of bounds.*/;
	}

	public static void SetScreenSleepTimeout(bool bNeverSleep)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/<< (int)/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xFE2B*/;
	}

	public static long FileGetLastWriteTime(string file)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static bool IsServerMaintained()
	{
		return Booter.serverMaintained;
	}

	public static string GetServerMaintainedInfo()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_ = 355504781;
		/*Error: End of method reached without returning.*/;
	}

	public static void ResetIke()
	{
		if ((Object)(object)MonoSingleton<HttpNetworkManager>.Instance != (Object)null)
		{
			MonoSingleton<HttpNetworkManager>.Instance.ResetIke();
		}
	}

	public static void SetRetryCount()
	{
		if ((Object)(object)MonoSingleton<HttpNetworkManager>.Instance != (Object)null)
		{
			MonoSingleton<HttpNetworkManager>.Instance.SetRetryCount();
		}
	}

	public static void MarkServerTimeStamp(long serverTimeStamp)
	{
		if ((Object)(object)MonoSingleton<HttpNetworkManager>.Instance != (Object)null)
		{
			MonoSingleton<HttpNetworkManager>.Instance.MarkServerTimeStamp(serverTimeStamp);
		}
	}

	public static void SetAeadKey(byte[] pubKey, int function)
	{
		if ((Object)(object)MonoSingleton<HttpNetworkManager>.Instance != (Object)null)
		{
			MonoSingleton<HttpNetworkManager>.Instance.SetAeadKey(pubKey, function);
		}
	}

	public static byte[] GetPubKey()
	{
		if (!((Object)(object)MonoSingleton<HttpNetworkManager>.Instance == (Object)null))
		{
			return MonoSingleton<HttpNetworkManager>.Instance.GetPubKey();
		}
		return null;
	}

	public static HttpNetMsg ParseMessage(byte[] messageData, bool isNextPackage)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void AddSendMsgRequest(short msgId, byte[] msgBody, Action<HttpNetMsg, object> callbackAction, string url)
	{
		if ((Object)(object)MonoSingleton<HttpNetworkManager>.Instance != (Object)null)
		{
			MonoSingleton<HttpNetworkManager>.Instance.AddSendMsgRequest(msgId, msgBody, callbackAction, url);
		}
	}

	public static void RestartNetwork()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ClearCachedCookie()
	{
		/*Error: Invalid metadata token*/;
	}

	public static void CloseLaunchInfo(GameObject gameObject)
	{
		if (!((Object)(object)gameObject == (Object)null))
		{
			LaunchUI component = gameObject.GetComponent<LaunchUI>();
			if (component != null)
			{
				component.CloseLaunchInfo();
			}
		}
	}

	public static void CloseLaunchLoading(GameObject gameObject)
	{
		if (!((Object)(object)gameObject == (Object)null))
		{
			LaunchUI component = gameObject.GetComponent<LaunchUI>();
			if (component != null)
			{
				component.CloseLaunchLoading();
			}
		}
	}

	public static void OpenBooterRepairResourceMode()
	{
		checked
		{
			_ = (byte)/*Error near IL_0001: Stack underflow*/;
			_ = -1;
			/*Error near IL_0002: Unknown opcode: 0x24*/;
		}
	}

	public static string[] GetAvailable_TextLanguage()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/])
		{
			/*Error: Invalid branch target*/;
		}
		/*Error: End of method reached without returning.*/;
	}

	public static string GetDefault_TextLanguage()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/<< (int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public static string GetCur_TextLanguage()
	{
		return MonoSingleton<ClientManager>.Instance.localLanguage;
	}

	public unsafe static void SetCur_TextLanguage(string language)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(float*)8;
		/*Error near IL_0009: Read out of bounds.*/;
	}

	public static string[] GetAvailable_VoLanguage()
	{
		/*Error near IL_0001: Not a type handle*/;
	}

	public static string GetDefault_VoLanguage()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xE2*/;
	}

	public static string GetCur_VoiceLanguage()
	{
		return NovaCoreAPI.GetCur_VoiceLanguage();
	}

	public static void SetCur_VoiceLanguage(string language)
	{
		/*Error: Invalid field token*/;
	}

	public static bool HasDownload_VoLanguage(string language, out long totalSize, out long needDownloadSize)
	{
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCE*/;
	}

	public static bool HasDownload_Any_VoLanguage()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/>> (int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public static void Enable_VoLanguage(string language, bool downloadPackageUseResourceSupplement = true)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public static void Disable_VoLanguage(string language)
	{
		/*Error: Invalid field token*/;
	}

	internal static string GetVoicePackageTagHeader()
	{
		if (!float.IsFinite(((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]))
		{
			throw new ArithmeticException();
		}
		/*Error near IL_0002: Read out of bounds.*/;
	}

	internal static string GetVoicePackageTagFromLanguage(string language)
	{
		/*Error: Invalid field token*/;
	}

	internal static void SetupWwiseVoiceLanguage()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public static void SetComponentEnableByName(GameObject go, string componentName, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetComponentEnable(Component component, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetRaycastTarget(GameObject go, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetColor(GameObject go, float r, float g, float b, float a)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetAlpha(GameObject go, float a)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetParticleColor(GameObject go, Color color)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetAdaptedAreaCustomWidth(int percent)
	{
		/*Error: Invalid field token*/;
	}

	public static int GetAdaptedAreaCustomWidth()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xC4*/;
	}

	public static void SetParentAndNormalized(Transform trTarget, Transform trParent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static float GetViewPointX(GameObject obj)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void SetCanvasSortingOrder(Canvas canvas, int value)
	{
		if (!((Object)(object)canvas == (Object)null))
		{
			canvas.sortingOrder = value;
		}
	}

	public static int GetCanvasSortingOrder(Canvas canvas)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static void SetCanvasSortingName(Canvas canvas, string name)
	{
		if (!((Object)(object)canvas == (Object)null))
		{
			canvas.sortingLayerName = name;
		}
	}

	public static void SetCanvasSortingId(Canvas canvas, int id)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetCanvasOverrideSorting(Canvas canvas, bool enable)
	{
		if (!((Object)(object)canvas == (Object)null))
		{
			canvas.overrideSorting = enable;
		}
	}

	public static void SetCanvasWorldCamera(Canvas canvas, Camera camera)
	{
		if (!((Object)(object)canvas == (Object)null))
		{
			canvas.worldCamera = camera;
		}
	}

	public static void SetCanvasPlaneDistance(Canvas canvas, float value)
	{
		if (!((Object)(object)canvas == (Object)null))
		{
			canvas.planeDistance = value;
		}
	}

	public static void ForceUpdateCanvases()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_ = 0;
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public unsafe static void SetMaskAllDirty(GameObject maskGameObject)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: starg 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static void SetTopGridCanvasSorting(GameObject go, int value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetVariableJoystickMode(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetCanvasGroupAlpha(CanvasGroup canvasGroup, float alpha)
	{
		if (Object.op_Implicit((Object)(object)canvasGroup))
		{
			canvasGroup.alpha = alpha;
		}
	}

	public static float GetCanvasGroupAlpha(CanvasGroup canvasGroup)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetCanvasGroupBlocksRaycasts(CanvasGroup canvasGroup, bool visible)
	{
		if (Object.op_Implicit((Object)(object)canvasGroup))
		{
			canvasGroup.blocksRaycasts = visible;
		}
	}

	public static void SetCanvasGroupInteractable(CanvasGroup canvasGroup, bool visible)
	{
		if (Object.op_Implicit((Object)(object)canvasGroup))
		{
			canvasGroup.interactable = visible;
		}
	}

	public static Tweener SetCanvasGroupDoFade(CanvasGroup canvasGroup, float value, float duration, bool update = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void UIEffectSnapShotCapture(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetButtonInteractable(Button btn, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetNaviButtonAction(NaviButton btn, bool enable)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public static void AddButtonListener(Button btn, UnityAction handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void RemoveButtonListener(Button btn, UnityAction handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetButtonExHoldThreshold(GameObject go, float fThreshold)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void AddUIButtonListener(UIButton btn, UnityAction handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void RemoveUIButtonListener(UIButton btn, UnityAction handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public unsafe static void SetPersonalityRing(GameObject go, float[] fillAmount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = 0;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static bool SetImageSprite(Image image, string assetsPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static void SetImageSpriteAsset(Image image, Sprite sprite)
	{
		if (Object.op_Implicit((Object)(object)image))
		{
			image.sprite = sprite;
		}
	}

	public static void SetImageRaycastTarget(Image image, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetImageNativeSize(Image image)
	{
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).SetNativeSize();
		}
	}

	public static void SetImageColor(Image image, Color color)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = color;
		}
	}

	public static Color GetImageColor(Image image)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static float GetImageSpriteWidth(Image image)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static float GetImageSpriteHeight(Image image)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static Tweener ImageDoFade(Image image, float value, float duration, bool update = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static Tweener ImageDoColor(Image image, Color color, float duration, bool update = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static Tweener ImageDoFillAmount(Image image, float value, float duration, bool update = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetImageFillAmount(Image image, float value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static float GetImageFillAmount(Image image)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static bool SetTextureByPath(RawImage image, string assetsPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static bool SetTexture(RawImage rawImage, Texture texture)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static Texture GetTexture(RawImage rawImage)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetRawImageColor(RawImage rawImage, Color color)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)rawImage))
		{
			((Graphic)rawImage).color = color;
		}
	}

	public static Color GetRawImageColor(RawImage rawImage)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetRawImageMaterial(RawImage rawImage, Material mt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static Tweener DoRawImageColor(RawImage image, Color color, float time)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetSpriteRendererSprite(SpriteRenderer spriteRenderer, Sprite sprite)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetSpriteRendererColor(SpriteRenderer spriteRenderer, Color color)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetSPSortingOrder(SpriteRenderer spriteRenderer, int value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static Tweener SpriteRendererDoColor(SpriteRenderer spriteRenderer, Color color, float duration)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static Tweener SpriteRendererDoFade(SpriteRenderer spriteRenderer, float value, float duration)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetText(Text text, string content)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static string GetText(Text text)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (string)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static void SetTextColor(Text text, Color color)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetTMPText(TMP_Text tmpText, string content)
	{
		NovaCoreAPI.SetTMPText(tmpText, content);
	}

	public static string GetTMPText(TMP_Text tmpText)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (string)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static void SetTMPColor(TMP_Text tmpText, Color color)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)tmpText == (Object)null) && Object.op_Implicit((Object)(object)tmpText))
		{
			((Graphic)tmpText).color = color;
		}
	}

	public static void SetTMPRaycastTarget(TMP_Text tmpText, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetTMPFontSize(TMP_Text tmpText, float size)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void TMPSetAllDirty(TMP_Text tmpText)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetTMPSourceText(TMP_Text tmpText, string content, bool syncTextInputBox = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetTMPWrappingEnable(TMP_Text tmpText, bool enabled)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetText_RubyTMP(RubyTextMeshProUGUI rubyTMP_a, string sContent, RubyTextMeshProUGUI rubyTMP_b)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static string GetText_RubyTMP(RubyTextMeshProUGUI rubyTMP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (string)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public unsafe static Tweener DOText_RubyTMP(RubyTextMeshProUGUI rubyTMP, string sContent, float fDuration)
	{
		//IL_0002: Expected F4, but got I4
		((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	public static void SetTextColor_RubyTMP(RubyTextMeshProUGUI rubyTMP, string sColor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static bool GetRubyPos(RubyTextMeshProUGUI rubyTMP, string sBaseText, string sRubyText, out float fP1, out float fP2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	public static void SetTMP_AutoLineWrap(RubyTextMeshProUGUI rubyTMP, bool bEnableAutoWrap)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static float AvgCalcTMPLastWordPos(RubyTextMeshProUGUI rubyTMP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public static void SetTMPInputFieldText(TMP_InputField tmpInputField, string content)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static string GetTMPInputFieldText(TMP_InputField tmpInputField)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (string)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static TMP_Text GetTMPInputFieldTextComponent(TMP_InputField tmpInputField)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (TMP_Text)(object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static void SetTMPInputFieldInteractable(TMP_InputField tmpInputField, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetTMPInputFieldPlaceholderText(TMP_InputField tmpInputField, string content)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void AddTMPEndEditListener(TMP_InputField tmpInputField, UnityAction<string> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void RemoveTMPEndEditListener(TMP_InputField tmpInputField, UnityAction<string> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetScrollRectVertical(ScrollRect sr, bool vertical)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetScrollHorizontal(ScrollRect sr, bool horizontal)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetVerticalNormalizedPosition(ScrollRect sr, float value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetHorizontalNormalizedPosition(ScrollRect sr, float value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static float GetVerticalNormalizedPosition(ScrollRect sr)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected F4, but got Unknown
		return checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static float GetHorizontalNormalizedPosition(ScrollRect sr)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected F4, but got Unknown
		return checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static void AddScrollRectListener(ScrollRect sr, UnityAction<Vector2> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void RemoveScrollRectListener(ScrollRect sr, UnityAction<Vector2> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void UIScrollRectScrollTo(UIScrollRect sr, int index, bool reverse)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetDropDownValue(Dropdown dd, int value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static int GetDropDownValue(Dropdown dd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static void ClearDropDownOptions(Dropdown dd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void DropDownAddOptions(Dropdown dd, List<string> options)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static string GetCurDDOptionsText(Dropdown dd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (string)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static void SetDDInteractable(Dropdown dd, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static bool GetDDInteractable(Dropdown dd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetDDValueWithoutNotify(Dropdown dd, int value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void AddDropDownListener(Dropdown dd, UnityAction<int> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void RemoveDropDownListener(Dropdown dd, UnityAction<int> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetInputFieldText(InputField inputField, string text)
	{
		if (Object.op_Implicit((Object)(object)inputField))
		{
			inputField.text = text;
		}
	}

	public static string GetInputFieldText(InputField inputField)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetInputFieldPlaceholderText(InputField inputField, string content)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetInputFieldInteractable(InputField inputField, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void AddEndEditListener(InputField inputField, UnityAction<string> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void RemoveEndEditListener(InputField inputField, UnityAction<string> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void AddIPValueChangedListener(InputField inputField, UnityAction<string> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void RemoveIPValueChangedListener(InputField inputField, UnityAction<string> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetToggleInteractable(Toggle toggle, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetToggleIsOn(Toggle toggle, bool isOn)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static bool GetToggleIsOn(Toggle toggle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void AddToggleListener(Toggle toggle, UnityAction<bool> handle)
	{
		if (Object.op_Implicit((Object)(object)toggle))
		{
			((UnityEvent<bool>)(object)toggle.onValueChanged).AddListener(handle);
		}
	}

	public static void RemoveToggleListener(Toggle toggle, UnityAction<bool> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void AddUIToggleListener(UIToggle toggle, UnityAction<bool> handle)
	{
		if (Object.op_Implicit((Object)(object)toggle))
		{
			((UnityEvent<bool>)(object)((Toggle)toggle).onValueChanged).AddListener(handle);
		}
	}

	public static void RemoveUIToggleListener(UIToggle toggle, UnityAction<bool> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetSliderInteractable(Slider slider, bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetSliderValue(Slider slider, float value, bool withoutNotify = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static float GetSliderValue(Slider slider)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetSliderMinValue(Slider slider, float value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void SetSliderMaxValue(Slider slider, float value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void AddSliderListener(Slider slider, UnityAction<float> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void RemoveSliderListener(Slider slider, UnityAction<float> handle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static int LayerMaskGetMask(string name)
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	public static int LayerMaskName2Layer(string name)
	{
		/*Error: Invalid field token*/;
	}

	public static bool PlayFX(bool bEnablePostProcessing, string sPath, float fPlaySpeed, out GameObject goIns)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ushort)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public unsafe static void StopFX(GameObject goIns)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = /*Error near IL_0003: Stack underflow*/* /*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static void SetEnable_Gradient2(GameObject go, bool bShadowMask)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public unsafe static void PlayGradient2Anim(GameObject go, float fStart, float fEnd, float fDuration)
	{
		//IL_0002: Expected I8, but got I4
		((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	public static void SetImageSpriteWithPrefab(Image imgHeadIcon, GameObject prefab)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void UnloadWwiseSoundBank(string sBnkName)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static string[][] ReadDataFromExcel(string xlsxFileFullPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBB*/;
		}
	}

	public unsafe static void WriteDataToExcel(LuaTable writeData, string xlsxFileFullPath, bool bRenameExistedFileByTimeStampSurfix = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = (nuint)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static void SetSkillIndicatorTarget(long entityId, GameObject gameObject, Vector3 offset)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static void DoShakeEffect(GameObject go, float[][] v3Pos, float[][] v3Rot, bool bLoop)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = 1;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static void StopShakeEffect(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = 1;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static void RestartShakeEffect(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = 1;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static void SetUIEffectAndTransition(UIEffectAndTransition eft, int nEftMode, float width, float softness)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static float GetAnimClipLength(Animator anim, string[] clipNames)
	{
		float num = 0f;
		if ((Object)(object)anim != (Object)null && (Object)(object)anim.runtimeAnimatorController != (Object)null)
		{
			AnimationClip[] animationClips = anim.runtimeAnimatorController.animationClips;
			if (animationClips != null && animationClips.Length != 0)
			{
				List<string> list = new List<string>();
				if (clipNames != null && clipNames.Length != 0)
				{
					foreach (string item in clipNames)
					{
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
				foreach (AnimationClip val in animationClips)
				{
					if ((Object)(object)val != (Object)null && list.Count > 0 && list.Contains(((Object)val).name))
					{
						list.Remove(((Object)val).name);
						num += val.length;
					}
				}
			}
		}
		return num;
	}

	public static void CtrlDotweenAnimation(GameObject go, int nStatus)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetAnimatorSpeed(Animator anim, float fSpeed)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void ClearSelectedUI()
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = null;
		_ = 8;
		/*Error near IL_0007: Unknown opcode: 0xF8*/;
	}

	public static void SetSelectedUI(GameObject go)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static GameObject GetSelectedUI()
	{
		/*Error: Invalid metadata token*/;
	}

	public static void SetGamepadUINavigation(Selectable[] selectables, bool isHorizontal = true, bool isLoop = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB0*/;
		}
	}

	public unsafe static void SetRectMaskPadding(GameObject obj, float left, float bottom, float right, float top)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = (nint)(/*Error near IL_000c: Stack underflow*/ >> -2026378239);
		/*Error near IL_000d: Not a type handle*/;
	}

	public unsafe static void SetLayoutGroupPadding(GameObject obj, int left, int right, int top, int bottom)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		LayoutGroup val = (LayoutGroup)(object)(/*Error near IL_0008: Stack underflow*/ | -1.3836745E-34f);
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_000a: Stack underflow*/);
	}

	public static void SetLayoutElementMinHeight(LayoutElement layout, float value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetLayoutElementPreferredWidth(LayoutElement layout, float value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void AddRedDotNode(GameObject obj, string key, string paramJson)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0 >>> 0;
			/*Error near IL_000c: Invalid branch target*/;
		}
	}

	public unsafe static void UnRegisterRedDotNode(GameObject obj)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0x24*/;
	}

	public static void ResetTouchEffect(Transform target, GameObject prefabMain, GameObject prefabSlide)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static void SetupUIParallaxStageCameraControllerForModelView(UIParallaxStageCameraController component, Camera modelProjectionOverrideCamera)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void BindUIParallaxStageCameraControllerModel(UIParallaxStageCameraController component, int index, GameObject model, bool updateImmediately = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void UnbindUIParallaxStageCameraControllerModel(UIParallaxStageCameraController component, int index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static void UnLoadBankByEventName(string eventName)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)eventName == 8L)
		{
			/*Error: Invalid branch target*/;
		}
		_ = -1;
		/*Error: End of method reached without returning.*/;
	}

	public static void AttachPrefabLuaInspector(GameObject obj, string luaCtrlPath, string luaPanelPath, string prefabPath)
	{
	}
}
