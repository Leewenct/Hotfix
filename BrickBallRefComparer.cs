using System.Collections.Generic;

public sealed class BrickBallRefComparer : IEqualityComparer<Brick_BallBase>
{
	public static readonly BrickBallRefComparer Instance;

	public unsafe bool Equals(Brick_BallBase x, Brick_BallBase y)
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xBE*/;
	}

	public int GetHashCode(Brick_BallBase obj)
	{
		/*Error: Invalid field token*/;
	}

	static BrickBallRefComparer()
	{
		/*Error: Invalid metadata token*/;
	}
}
