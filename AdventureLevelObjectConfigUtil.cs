using System.Runtime.CompilerServices;
using Pathfinding;
using UnityEngine;

public class AdventureLevelObjectConfigUtil : MonoBehaviour
{
	[SerializeField]
	public AdventureLevelObjectConfig levelObjectConfig;

	protected float dynamicLoad_SceneObjLoadDistance;

	protected float dynamicLoad_MonsterLoadDistance;

	public NavmeshAdd[] navmeshAdds;

	public NavmeshCut[] navmeshCuts;

	protected AdventureLevelObjPoolMgr poolMgr;

	protected Texture2D[] lightingmaps;

	public bool isEnableLogic
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	private unsafe void OnEnable()
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	private unsafe void OnDisable()
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public void InitConfigs(string sceneName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void PreloadConfigs(Vector2 entityPosition)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void Config2GameObject()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected void Config2GameObject(AdventureLevelObjectConfig.SceneObjDataConfig config, Transform parent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 214 (out-of-bounds)*/;
		}
		if ((int)/*Error near IL_0008: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
	}

	protected void HandleConfigGameObject(GameObject go, AdventureLevelObjectConfig.SceneObjDataConfig config, Transform parent)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public unsafe void EnableLogic()
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xE4*/;
	}

	public unsafe void DisableLogic()
	{
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Unknown opcode: 0xE4*/;
	}

	public void UpdateLogic(Vector2 entityPosition)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void RevertData2GameObject()
	{
		/*Error: Invalid field token*/;
	}

	public void ClearChild()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void UpdateTransform(Matrix4x4 transMatrix, Vector3 relativeRotation)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void UpdateLightingmapSetting(Texture2D[] maps)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 207 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public AdventureLevelObjectConfigUtil()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
