using System;
using System.Collections.Generic;
using Nova.Hotfix;
using TrueSync;
using UnityEngine;

namespace AIScript.DynamicLevel;

public class TowerDefenseLevelController : AdventureLevelController
{
	private new AdventureModuleLevelLoadParams levelLoadParams;

	private TowerDefenseFloor floorData;

	private new GameObject configPrefab;

	private TowerDefensePrefabData prefabData;

	private TowerDefenseMapData mapData;

	private TowerDefenseGameplayBase gameplay;

	private bool enableMainCameraPhysicsRaycaster;

	private List<int> selRoles;

	private int itemID;

	private bool pinMainCamera;

	private Vector3 pinnedCameraPosition;

	private Quaternion pinnedCameraRotation;

	public override void Load(AdventureModuleLevelLoadParams param = null, Action callback = null)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected override void LevelLoadComplete(string sceneName)
	{
		//Discarded unreachable code: IL_0305
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1690321695;
		}
	}

	private TowerDefenseGameplayBase CreateGameplayInstance(string path)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public override void LevelStart(Action callback = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xA7*/;
		}
	}

	public override void UpdateLogic(FP logicDeltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1679810853;
		}
	}

	public override bool HasTimelinePerformance()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		}
	}

	public unsafe override void PlayTimelinePerformance(Action callback = null, bool needLimitPlayTimes = true)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0003: Stack underflow*/ >= (int)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error near IL_0003: Invalid field token*/;
		}
		/*Error near IL_001a: Unknown opcode: 0xB0*/;
	}

	private void SetMainCameraBrainEnabled(bool enabled)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		}
	}

	public override bool IsLevelComplete()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		}
	}

	public unsafe override void LevelEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		*(float*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0f;
		/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public TowerDefenseLevelController()
	{
		/*Error: Invalid field token*/;
	}
}
