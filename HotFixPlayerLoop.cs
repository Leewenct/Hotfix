using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.PlayerLoop;

public static class HotFixPlayerLoop
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private struct PostScriptUpdateTag
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private struct PostLateUpdateTag
	{
	}

	public static void Inject()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		PlayerLoopSystem currentPlayerLoop = PlayerLoop.GetCurrentPlayerLoop();
		PlayerLoopSystem[] subSystemList = currentPlayerLoop.subSystemList;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < subSystemList.Length; i++)
		{
			Type type = subSystemList[i].type;
			if (type == typeof(Update))
			{
				flag = true;
				List<PlayerLoopSystem> list = new List<PlayerLoopSystem>(subSystemList[i].subSystemList);
				RemoveInjectedByFullName(list, typeof(PostScriptUpdateTag).FullName);
				int num = list.FindIndex((PlayerLoopSystem s) =>
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					return s.type == typeof(ScriptRunBehaviourUpdate);
				});
				if (num < 0)
				{
					NovaLogger.Error("\uf3bbĒǶë筤\ude69;筐\uf3ebŘƗÜ笧\ude4c,筯\uf3efƏĂÇ篆\ude61:筥\uf3f1ēǶæ찇\ude20趫챥醰卉务姵짐厁c箣\uf3efęĖë策\ude2e\u0010筣\uf3f1Śćë笥\ude75-筂\uf3e4ĚĖí箖\ude6f6筲×깰悗晕敶Ā");
					continue;
				}
				list.Insert(num + 1, new PlayerLoopSystem
				{
					type = typeof(PostScriptUpdateTag),
					updateDelegate = OnPostScriptUpdate
				});
				subSystemList[i].subSystemList = list.ToArray();
			}
			else if (type == typeof(PostLateUpdate))
			{
				flag2 = true;
				List<PlayerLoopSystem> list2 = new List<PlayerLoopSystem>(subSystemList[i].subSystemList);
				RemoveInjectedByFullName(list2, typeof(PostLateUpdateTag).FullName);
				list2.Insert(0, new PlayerLoopSystem
				{
					type = typeof(PostLateUpdateTag),
					updateDelegate = OnPostLateUpdate
				});
				subSystemList[i].subSystemList = list2.ToArray();
			}
		}
		if (!flag || !flag2)
		{
			NovaLogger.Error("\uf3bbĒǶë筤\ude69;筐\uf3ebŘƗÜ笧\ude4c,筯\uf3efƏĂÇ篆\ude61:筥\uf3f1ēǶæ찇\ude20趫챥殰屉审姭唤厪辸碌Ѯ⒀篕" + string.Format("\uf3a7ŕćÛ笖\ude74&笺\uf39fǞăô篂\ude20\u0013筯\uf3f2ĝǄØ筇\ude65\u0016筰\uf3e3ŘŇÜ箣\ude208笱썘ʏ", flag, flag2));
		}
		else
		{
			PlayerLoop.SetPlayerLoop(currentPlayerLoop);
		}
	}

	private static void RemoveInjectedByFullName(List<PlayerLoopSystem> systems, string markerTypeFullName)
	{
		systems.RemoveAll((PlayerLoopSystem s) =>
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			return s.type != null && s.type.FullName == markerTypeFullName;
		});
	}

	public static void Uninject()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private static void OnPostScriptUpdate()
	{
		AdventureModuleController instance = ModuleController<AdventureModuleController>.Instance;
		if ((Object)(object)instance != (Object)null && ((Behaviour)instance).isActiveAndEnabled)
		{
			InvokeSafely(instance.DriveUpdate);
		}
		AdventurePlayerController instance2 = SceneSingleton<AdventurePlayerController>.Instance;
		if ((Object)(object)instance2 != (Object)null && ((Behaviour)instance2).isActiveAndEnabled)
		{
			InvokeSafely(instance2.DriveUpdate);
		}
		AdventureFXManager instance3 = SceneSingleton<AdventureFXManager>.Instance;
		if ((Object)(object)instance3 != (Object)null && ((Behaviour)instance3).isActiveAndEnabled)
		{
			InvokeSafely(instance3.DriveUpdate);
		}
		AdventurePlayerCameraUpdateControl instance4 = SceneSingleton<AdventurePlayerCameraUpdateControl>.Instance;
		if ((Object)(object)instance4 != (Object)null && ((Behaviour)instance4).isActiveAndEnabled)
		{
			InvokeSafely(instance4.DriveCameraUpdate);
		}
	}

	private static void OnPostLateUpdate()
	{
		PlayerAdventureActor.DriveActiveInstancesLateUpdate();
		AdventurePlayerController instance = SceneSingleton<AdventurePlayerController>.Instance;
		if ((Object)(object)instance != (Object)null && ((Behaviour)instance).isActiveAndEnabled)
		{
			InvokeSafely(instance.DriveLateUpdate);
		}
		AdventureHUDController instance2 = SceneSingleton<AdventureHUDController>.Instance;
		if ((Object)(object)instance2 != (Object)null && ((Behaviour)instance2).isActiveAndEnabled)
		{
			InvokeSafely(instance2.DriveLateUpdate);
		}
		AdventureIndicatorController instance3 = SceneSingleton<AdventureIndicatorController>.Instance;
		if ((Object)(object)instance3 != (Object)null && ((Behaviour)instance3).isActiveAndEnabled)
		{
			InvokeSafely(instance3.DriveLateUpdate);
		}
		AdventureFXManager instance4 = SceneSingleton<AdventureFXManager>.Instance;
		if ((Object)(object)instance4 != (Object)null && ((Behaviour)instance4).isActiveAndEnabled)
		{
			InvokeSafely(instance4.DriveLateUpdate);
		}
	}

	private static void InvokeSafely(Action action)
	{
		try
		{
			action();
		}
		catch (Exception ex)
		{
			Debug.LogException(ex);
		}
	}
}
