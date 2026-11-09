using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;
using UnityEngine;

public class MathParkourChunk : MonoBehaviour
{
	private readonly struct GridKey
	{
		public readonly int LaneIndex;

		public readonly int RowIndex;

		public GridKey(int laneIndex, int rowIndex)
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	private sealed class GridSpawnState
	{
		public bool HasCenterObject;

		public bool HasWall;
	}

	private sealed class HiddenObjectUi
	{
		public readonly GameObject Instance;

		public readonly Canvas[] Canvases;

		public readonly int FirstCheckFrame;

		public HiddenObjectUi(GameObject instance, Canvas[] canvases, int firstCheckFrame)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = (ushort)0;
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}
	}

	private const int LaneCount = 5;

	private const int CenterLaneIndex = 2;

	[Header("对象生成")]
	[SerializeField]
	private Transform objectParent;

	[SerializeField]
	[Min(0.01f)]
	private float laneWidth;

	[SerializeField]
	[Min(0.01f)]
	private float rowLength;

	[SerializeField]
	[Min(0.01f)]
	private float chunkLength;

	[Header("对象显示")]
	[SerializeField]
	[Tooltip("对象弯曲后的世界坐标 Y 到达该值后才显示其 World Space UI。设为较小值可保持始终显示。")]
	private float objectVisibleMinWorldY;

	private List<MathParkourAreaConfig> areaConfigs;

	private TSRandom random;

	private readonly List<GameObject> spawnedObjects;

	private readonly List<HiddenObjectUi> hiddenObjectUis;

	private readonly List<MathParkourCombatEntity> combatEntities;

	private long nextEntityId;

	public float ChunkLength
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public long NextEntityId
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public float RowLength
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public IReadOnlyList<MathParkourCombatEntity> CombatEntities
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public void Init(List<MathParkourAreaConfig> areaConfigs, TSRandom random)
	{
		/*Error: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	public void Init(List<MathParkourAreaConfig> areaConfigs, TSRandom random, long entityIdStart)
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
		_ = -(-2032600572);
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
	}

	public void ClearObjects()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void Recycle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 0;
		/*Error near IL_0002: stloc 1 (out-of-bounds)*/;
		((sbyte[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (sbyte)(int)val;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void OnDestroy()
	{
		/*Error: Invalid field token*/;
	}

	private void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I4, but got Unknown
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
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		}
	}

	private void GenerateObjects()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		int num = 0;
		((sbyte[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (sbyte)(int)val;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe MathParkourObject GetSpawnObjectConfig(MathParkourAreaConfig areaConfig)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: stloc 2 (out-of-bounds)*/;
		checked
		{
			_ = (long)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe int PickWeightedObjectId(MathParkourItemGroup groupConfig)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private void SpawnObject(MathParkourObject objectConfig, MathParkourAreaConfig areaConfig, bool isWall)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void TryHideObjectUntilVisible(GameObject instance)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private unsafe void TryAddCombatEntity(GameObject instance, MathParkourObject objectConfig, long entityId, MathParkourAreaConfig areaConfig)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
	}

	private unsafe void TryAddBuffItemEntity(GameObject instance, MathParkourObject objectConfig, long entityId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
	}

	private Vector3 GetGridLocalPosition(int laneIndex, int rowIndex, bool isWall)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0x24*/;
		}
	}

	private bool IsValidLane(int laneIndex)
	{
		_ = 5;
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xAD*/;
	}

	private unsafe int CompareAreaConfig(MathParkourAreaConfig left, MathParkourAreaConfig right)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, val);
		checked
		{
			_ = (long)/*Error near IL_0002: ldloc 2 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public MathParkourChunk()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = -6;
		/*Error near IL_0003: Unknown opcode: 0xCC*/;
	}
}
