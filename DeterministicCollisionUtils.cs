using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using TrueSync.Physics2D;

public static class DeterministicCollisionUtils
{
	internal class DeterministicRaycastHitComparer : IComparer<DeterministicRaycastHit>
	{
		public int Compare(DeterministicRaycastHit x, DeterministicRaycastHit y)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected I4, but got Unknown
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
			}
		}
	}

	internal static readonly DistanceInput _internalDistanceInput;

	internal static bool IsColliderFilter(DeterministicCollider collider, int layerMask)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	internal unsafe static bool TestOverlap(Shape shapeA, Shape shapeB, ref Transform xfA, ref Transform xfB, bool refreshShapeAProxy = true, bool refreshShapeBProxy = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xCF*/;
	}

	internal unsafe static void CreateLineShape(PolygonShape shape, TSVector2 start, TSVector2 end)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = (nuint)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: ldloca 236 (out-of-bounds)*/;
		_ = 0;
		/*Error near IL_0006: Unknown opcode: 0xA8*/;
	}

	internal unsafe static void CreateRectangleShape(PolygonShape shape, FP hx, FP hy)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = (nuint)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: ldloca 236 (out-of-bounds)*/;
		_ = 0;
		/*Error near IL_0006: Unknown opcode: 0xA8*/;
	}

	internal unsafe static void CreateCircleShape(PolygonShape shape, FP radius, int numberOfEdges)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = (nuint)/*Error near IL_0003: Stack underflow*/;
		_ = /*Error near IL_0003: ldloca 236 (out-of-bounds)*/| (ushort)0;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	internal unsafe static void CreateFanShape(PolygonShape shape, FP radians, int sides, FP radius)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		((int[])(nuint)/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: ldloca 236 (out-of-bounds)*/ | (ushort)0] = (int)radians;
		_ = /*Error near IL_000c: Stack underflow*/>> checked((int)/*Error near IL_000b: Stack underflow*/);
		/*Error near IL_000c: Invalid branch target*/;
	}

	public static bool TestSimpleOverLap_Rect2Circle(TSVector2 rectPos, FP rectRot, FP rectWidth, FP rectLength, TSVector2 circlePos, FP circleRaidus)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	public static bool TestSimpleOverLap_Circle2Circle(TSVector2 circlePosA, FP radiusA, FP innerRadiusA, TSVector2 circlePosB, FP radiusB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I4
		if (/*Error near IL_0006: Stack underflow*/ == checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (int)checked((ushort)/*Error near IL_0007: Stack underflow*/);
		_ = (sbyte)6;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	public static bool TestSimpleOverLap_Fan2Circle(TSVector2 fanPos, FP fanRot, FP fanAngle, FP fanRadius, FP fanInnerRadius, TSVector2 circlePos, FP circleRaidus)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	static DeterministicCollisionUtils()
	{
		/*Error: Invalid metadata token*/;
	}
}
