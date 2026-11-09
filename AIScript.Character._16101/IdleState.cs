namespace AIScript.Character._16101;

public class IdleState : IState
{
	public override void Enter()
	{
		/*Error: Read out of bounds.*/;
	}

	public override void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) % 0;
		/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public IdleState()
	{
		/*Error: Read out of bounds.*/;
	}
}
