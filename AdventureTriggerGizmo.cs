using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class AdventureTriggerGizmo : LogicEntity
{
	private int _triggerRC;

	private int _triggerFC;

	public int x
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

	public int y
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

	public unsafe virtual string triggerName
	{
		get
		{
			_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB1*/;
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xEE*/;
	}

	public virtual void Initialize()
	{
	}

	public virtual void Initialize(int x, int y)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public virtual void Release()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	protected unsafe virtual void OnTriggerEnter(Collider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xCC*/;
	}

	protected unsafe virtual void OnTriggerStay(Collider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xCC*/;
	}

	protected unsafe virtual void OnTriggerExit(Collider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xCC*/;
	}

	protected virtual void TriggerEnter(GameObject playerAgent)
	{
	}

	protected virtual void TriggerStay(GameObject playerAgent)
	{
	}

	protected virtual void TriggerExit(GameObject playerAgent)
	{
	}

	protected AdventureTriggerGizmo()
	{
		/*Error: Invalid field token*/;
	}
}
