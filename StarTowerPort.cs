using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StarTowerPort : LogicMonoComponent
{
	public enum PortType
	{
		SpawnPoint,
		Teleporter
	}

	public enum PortState
	{
		Default,
		Destroyed,
		Opened
	}

	[Serializable]
	public struct FixedRoguelikePortInfo
	{
		[SerializeField]
		public HotfixEnum.fixedRoguelikePortDir direction;

		[SerializeField]
		[ReadOnly]
		public PortType portType;

		[SerializeField]
		[ReadOnly]
		public PortState state;

		public FixedRoguelikePortInfo(HotfixEnum.fixedRoguelikePortDir portDir, PortType portType, PortState portState)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			}
			_ = -(nint)1765734916;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	[SerializeField]
	protected FixedRoguelikePortInfo portInfo;

	public GameObject target;

	protected const string RUINED_MODEL_PATH = "Assets/AssetBundles/Environment/Roguelike_2/Perfab/Roguelike_2_Lift_DoorStop.prefab";

	public bool isSelected
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

	public unsafe void Select()
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xBF*/;
	}

	public void OutPort_InitInfo(int nextRoomType, bool isFinalLevel = false, bool sceneDoMir = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public void OutPort_Close()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	private void UpdatePortDropShow(int nextRoomType, bool isFinalLevel = false, bool sceneDoMir = false)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void SetActive_Teleporter(bool active)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public AdventureLevelTeleporter GetTeleporter()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected unsafe void OnTriggeTeleporter(AdventureLevelTeleporter.NextLevelData nextLevelData)
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}

	public PlayerSpawnPointGizmo SetActive_SpawnPoint()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public bool UpdateStatus(HotfixEnum.fixedRoguelikePortDir direction)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/));
			/*Error near IL_0009: stloc 0 (out-of-bounds)*/;
			/*Error near IL_000a: Unknown opcode: 0xB0*/;
		}
	}

	public override void OnActive()
	{
	}

	public override void OnDeactive()
	{
	}

	public StarTowerPort()
	{
		/*Error: Invalid field token*/;
	}
}
