using UnityEngine;

namespace AIScript.Booter;

internal static class HotfixBootSceneManagers
{
	private const string MgrNodeName = "AdventureModuleLevelMgrNode";

	private const string PoolNodeName = "Pool";

	private const string PreloadNodeName = "PreloadNode";

	internal static void Setup()
	{
		GameObject orCreateMgrNode = GetOrCreateMgrNode();
		GameObjectExtensions.AddOrGetComponent<AdventureFXManager>(orCreateMgrNode);
		GameObjectExtensions.AddOrGetComponent<AdventureLevelObjPoolMgr>(GetOrCreateChild(orCreateMgrNode, "崽ð\uf4eel"));
		GameObjectExtensions.AddOrGetComponent<AdventureModulePreloadAssetsMrg>(GetOrCreateChild(orCreateMgrNode, "\uf3cfƜŖã篶\ude61'筎\uf3e3輪笥"));
	}

	private static GameObject GetOrCreateMgrNode()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		GameObject val = GameObject.Find("\uf3c0ęŧÜ篦\ude746筲\uf3e4œǶÛ筗\ude6c&筌\uf3e4ƝŖã篔\ude671筎\uf3e3輪笥");
		if ((Object)(object)val != (Object)null)
		{
			return val;
		}
		val = new GameObject("\uf3c0ęŧÜ篦\ude746筲\uf3e4œǶÛ筗\ude6c&筌\uf3e4ƝŖã篔\ude671筎\uf3e3輪笥");
		Object.DontDestroyOnLoad((Object)(object)val);
		return val;
	}

	private static GameObject GetOrCreateChild(GameObject parent, string childName)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Transform val = parent.transform.Find(childName);
		if ((Object)(object)val != (Object)null)
		{
			return ((Component)val).gameObject;
		}
		GameObject val2 = new GameObject(childName);
		val2.transform.SetParent(parent.transform, false);
		return val2;
	}
}
