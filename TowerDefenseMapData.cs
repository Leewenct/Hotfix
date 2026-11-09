using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower Defense Map Data", menuName = "游戏/关卡/塔防地图数据")]
public class TowerDefenseMapData : ScriptableObject
{
	[Serializable]
	public struct RouteGridInfo
	{
		public int gridID;

		public RouteAction action;

		[ReadOnly]
		public List<int> path2Grid;

		public static RouteGridInfo Null
		{
			get
			{
				/*Error: Unknown opcode: 0xE7*/;
			}
		}

		public bool IsNull
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_000a: Stack underflow*/ <= checked(/*Error near IL_0009: Stack underflow*/ + ((nuint)/*Error near IL_0001: Stack underflow*/ & 0xE9508274u)))
				{
					/*Error: Invalid branch target*/;
				}
				/*Error: End of method reached without returning.*/;
			}
		}

		public int GetNextGridIndex(int curGridID)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected I4, but got Unknown
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
			}
		}

		public bool ContainsGrid(int gridIndex)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected I4, but got Unknown
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
			}
		}

		public bool Reachable()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I4, but got Unknown
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
	}

	[Serializable]
	public struct TowerDefenseRoute
	{
		public int id;

		[SerializeField]
		public List<RouteGridInfo> routePoints;

		public static TowerDefenseRoute Null
		{
			get
			{
				/*Error: Unknown opcode: 0xE7*/;
			}
		}

		public bool IsNUll
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_000a: Stack underflow*/ <= checked(/*Error near IL_0009: Stack underflow*/ + ((nuint)/*Error near IL_0001: Stack underflow*/ & 0xE9508271u)))
				{
					/*Error: Invalid branch target*/;
				}
				/*Error: End of method reached without returning.*/;
			}
		}

		public int GetNextGridIndex(int curGridID, int reachedPointIndex, out int curReachedPointIndex)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/!= 0)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (uint)/*Error near IL_0007: Stack underflow*/;
				/*Error near IL_0007: starg 4 (out-of-bounds)*/;
			}
			_ = /*Error near IL_000a: Stack underflow*/* /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xB1*/;
		}

		public int GetReachedPointIndex(int gridID, int reachedPointIndex)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected I4, but got Unknown
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

		public bool Reachable2End()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected I4, but got Unknown
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
	}

	[Serializable]
	public struct RouteAction
	{
		public int action;

		public string param;

		public static RouteAction Null
		{
			get
			{
				/*Error: Unknown opcode: 0xE7*/;
			}
		}

		public bool IsNull
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_000a: Stack underflow*/ <= checked(/*Error near IL_0009: Stack underflow*/ + ((nuint)/*Error near IL_0001: Stack underflow*/ & 0xE9508273u)))
				{
					/*Error: Invalid branch target*/;
				}
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	[Serializable]
	public struct TowerGrid
	{
		public int gridWalkableType;

		public int gridDeployType;

		public int gridAttribute;

		public int x;

		public int y;

		public int index;

		[HideInInspector]
		public Vector2 position;

		[HideInInspector]
		public float left;

		[HideInInspector]
		public float right;

		[HideInInspector]
		public float up;

		[HideInInspector]
		public float down;

		public static TowerGrid Null
		{
			get
			{
				/*Error: Unknown opcode: 0xE7*/;
			}
		}

		public bool IsNull
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_000a: Stack underflow*/ <= checked(/*Error near IL_0009: Stack underflow*/ + ((nuint)/*Error near IL_0001: Stack underflow*/ & 0xE9508278u)))
				{
					/*Error: Invalid branch target*/;
				}
				/*Error: End of method reached without returning.*/;
			}
		}

		public unsafe void SetPosition(int sizeX, int sizeY, Vector2 scale, Vector2 center)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Expected I8, but got Unknown
			*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0002: Unknown opcode: 0xED*/;
		}

		public bool IsPointInGrid(Vector2 p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
			}
		}
	}

	public Vector2 gridScale;

	public Vector3 center;

	public int sizeX;

	public int sizeY;

	[ReadOnly]
	[SerializeField]
	public List<TowerGrid> towerGrids;

	[ReadOnly]
	public List<TowerDefenseRoute> routes;

	private TowerDefensePathFinding pathFinder;

	public TowerGrid GetGrid(int id)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public TowerGrid GetGrid(int x, int y)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public TowerGrid GetGrid(Vector3 worldPosition)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public TowerDefenseRoute GetRoute(int routeID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
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
		}
	}

	public RouteAction GetRouteAction(int routeID, int gridID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
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
		}
	}

	public RouteAction GetRouteAction(int routeID, int gridID, int reachedPointIndex)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
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
		}
	}

	public void InitPathFinding()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1690424691;
		}
	}

	public void CalculateRoutesPaths()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public bool SetObstacle(int index, bool isObstacle = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*OpCode not supported: DebugBreak*/;
		checked
		{
			_ = /*Error near IL_000b: Stack underflow*/+ /*Error near IL_000b: Stack underflow*/;
			/*Error near IL_000b: Unknown opcode: 0xEC*/;
		}
	}

	private void SetObstacle(int x, int y, bool isObstacle = true)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void SetWeight(int index, int weight = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
	}

	public void SetWeight(int x, int y, int weight)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	private List<int> FindPath(int startIndex, int endIndex)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		checked
		{
			List<TowerDefensePathFinding.Point> list = default;
			_ = /*Error near IL_000b: Stack underflow*/+ list;
			/*Error near IL_000b: Invalid metadata token*/;
		}
	}

	public TowerGrid GetNextGrid(int rID, int curIndex, int reachedPointIndex, out int curReachedPointIndex)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	public int GetReachedPointIndex(int routeID, int gridID, int reachedPointIndex)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
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
		}
	}

	public int Length2End(int routeID, int gridIndex, int reachedPointIndex)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected I4, but got Unknown
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
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		}
	}

	public bool GridIsMustArrive(int routeID, int gridIndex)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public TowerDefenseMapData()
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
