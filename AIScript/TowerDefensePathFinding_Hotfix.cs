using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AIScript;

public class TowerDefensePathFinding_Hotfix
{
	public struct Point
	{
		public int x;

		public int y;

		public Point(int x, int y)
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public class Node
	{
		private int gcost;

		public int weight;

		public Point Position
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public Node Parent
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public unsafe int GCost
		{
			get
			{
				//IL_0003: Unknown result type (might be due to invalid IL or missing references)
				if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
				{
					/*Error: Invalid branch target*/;
				}
				*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
				_ = /*Error near IL_0004: Stack underflow*/>> (int)/*Error near IL_0004: Stack underflow*/;
				/*OpCode not supported: DebugBreak*/;
				/*Error near IL_0005: ldarg 2 (out-of-bounds)*/;
				if (!float.IsFinite(7))
				{
					throw new ArithmeticException();
				}
				/*Error near IL_0008: Unknown opcode: 0xF2*/;
			}
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public int HCost
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public int FCost
		{
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0003: Unknown result type (might be due to invalid IL or missing references)
				if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
				{
					/*Error: Invalid branch target*/;
				}
				_003F val = /*Error near IL_0004: Stack underflow*/>> checked(/*Error near IL_0003: Stack underflow*/ + /*Error near IL_0003: Stack underflow*/);
				/*OpCode not supported: DebugBreak*/;
				if (val <= /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_000b: ldloc 0 (out-of-bounds)*/;
				switch ((int)/*Error near IL_000c: ldloc 1 (out-of-bounds)*/)
				{
				default:
					/*Error: End of method reached without returning.*/;
				}
			}
		}

		public bool IsWalkable
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public Node(int x, int y)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid calli metadata token*/;
			}
		}
	}

	private Node[,] grid;

	private int gridWidth;

	private int gridHeight;

	private static Point[] Directions;

	public TowerDefensePathFinding_Hotfix(int width, int height)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (ushort)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void InitializeGrid()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1678964595;
		}
	}

	public void SetWeight(int x, int y, int weight)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public void SetObstacle(int x, int y, bool isObstacle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private bool IsInGrid(int x, int y)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public List<Point> FindPath(int sx, int sy, int ex, int ey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public List<Point> FindPath(Point start, Point end)
	{
		//Discarded unreachable code: IL_0199
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ <= (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			((int[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (int)/*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xCC*/;
		}
		_ = /*Error near IL_0032: Stack underflow*/% /*Error near IL_0032: Stack underflow*/;
		/*Error near IL_0032: Unknown opcode: 0xCB*/;
	}

	private unsafe List<Node> GetNeighbors(Node node)
	{
		//IL_0002: Expected F8, but got I4
		((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		Point[] array = (Point[])/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}

	private int CalculateDistance(Point a, Point b)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
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
		}
	}

	private unsafe List<Point> ReconstructPath(Node endNode)
	{
		//IL_0002: Expected F4, but got I4
		((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		Node node = (Node)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}

	static TowerDefensePathFinding_Hotfix()
	{
		/*Error: Unknown opcode: 0xEF*/;
	}
}
