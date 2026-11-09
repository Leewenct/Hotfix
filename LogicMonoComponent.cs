using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class LogicMonoComponent : MonoBehaviour, ILogicComponent
{
	public LogicEntity Entity
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

	public bool ActiveSelf
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}
	}

	public virtual void OnActive()
	{
	}

	public virtual void OnDeactive()
	{
	}

	public void Init()
	{
		/*Error: Invalid field token*/;
	}

	protected virtual void OnInit()
	{
	}

	public void Shutdown()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(ushort)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: ldarga 100 (out-of-bounds)*/;
		_ = 127;
		/*Error near IL_000a: Unknown opcode: 0xEA*/;
	}

	protected virtual void OnShutdown()
	{
	}

	public void SetEntity(ILogicEntity entity)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	protected LogicMonoComponent()
	{
		/*Error: Invalid field token*/;
	}
}
