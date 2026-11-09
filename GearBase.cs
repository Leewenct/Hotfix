using System.Runtime.CompilerServices;

public class GearBase : LogicEntity
{
	protected DeterministicCollider dtCollider;

	public bool IsBaked
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	protected override void OnInit()
	{
		/*Error near IL_0001: Unknown opcode: 0xEA*/;
	}

	protected override void OnActive()
	{
	}

	protected override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((double[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnShutdown()
	{
	}

	public GearBase()
	{
		/*Error: Invalid field token*/;
	}
}
