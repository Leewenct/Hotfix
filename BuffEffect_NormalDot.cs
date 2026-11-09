public class BuffEffect_NormalDot : BuffEffect_DotBase
{
	protected unsafe override void Enter()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0L;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void Execute()
	{
		/*Error: Invalid field token*/;
	}

	protected unsafe override void Exit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		*(double*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0.0;
		/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public BuffEffect_NormalDot()
	{
		/*Error: Invalid field token*/;
	}
}
