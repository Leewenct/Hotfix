using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

public class AreaEffect_Component : LogicMonoComponent, ILogicComponentUpdate, ILogicComponent
{
	[Space]
	public bool checkTargetWithTag;

	public string checkTag;

	protected AreaEffectEntity _context;

	protected AdventureActor _owner;

	[SerializeField]
	[HideInInspector]
	protected int _checkTagHashCode;

	public bool RunningLogic
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

	public bool FinishAreaEffect
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

	protected virtual bool ShowCheckTag
	{
		get
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	public unsafe void Setup()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F8, but got I
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)(nint)/*Error near IL_0008: Stack underflow*/ = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		if (/*Error near IL_000a: Stack underflow*/ != /*Error near IL_000a: Stack underflow*/)
		{
		}
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	protected virtual void OnSetup()
	{
	}

	public void StartLogic()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected virtual void OnStartLogic()
	{
	}

	public void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected virtual void OnEarlyWarningUpdate(FP logicDeltaTime)
	{
	}

	protected virtual void OnLogicUpdate(FP logicDeltaTime)
	{
	}

	public override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)((float[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void OnDeterministicCollisionEnter(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected virtual void OnDeterministicCollisionEnter(LogicEntity entity)
	{
	}

	public void OnDeterministicCollisionStay(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected virtual void OnDeterministicCollisionStay(LogicEntity entity)
	{
	}

	public void OnDeterministicCollisionExit(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected virtual void OnDeterministicCollisionExit(LogicEntity entity)
	{
	}

	public virtual void OnAreaScaleChange()
	{
	}

	private void OnCheckTagChange()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_000a: Stack underflow*/ < (int)checked((sbyte)(ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public AreaEffect_Component()
	{
		/*Error: Invalid field token*/;
	}
}
