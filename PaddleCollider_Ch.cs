using System;
using System.Runtime.CompilerServices;

public class PaddleCollider_Ch : LogicEntity
{
	public DeterministicCollider dtcollider
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/== 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)/*Error near IL_0008: Stack underflow*/;
			_ = 0;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	protected override void OnActive()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I, but got Unknown
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		_003F val = /*Error near IL_0003: Stack underflow*// /*Error near IL_0003: Stack underflow*/;
		((IntPtr[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (IntPtr)(/*Error near IL_0006: Stack underflow*/ - val);
		/*Error near IL_0007: Invalid branch target*/;
	}

	protected override void OnDeactive()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		_003F val = /*Error near IL_0003: Stack underflow*// /*Error near IL_0003: Stack underflow*/;
		_ = ((object[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/ - val];
		/*Error near IL_0007: Invalid branch target*/;
	}

	protected override void OnShutdown()
	{
		/*Error: Invalid field token*/;
	}

	private void InitCollider()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) > 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		/*Error near IL_001e: Unknown opcode: 0xCD*/;
	}

	protected override void OnLogicUpdate()
	{
	}

	public PaddleCollider_Ch()
	{
		/*Error: Invalid field token*/;
	}
}
