using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

[AddComponentMenu("Game/Adventure/Trigger/Trap")]
[RequireComponent(typeof(TrueSyncTransform))]
public class AdventureTrap : LogicEntity, IDeterministicCollisionListener
{
	[Min(0f)]
	public int damageValue;

	[Space]
	public bool moveable;

	public Transform[] waypoints;

	public FP moveSpeed;

	public Collider collider;

	public DeterministicCollider dtCollider
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

	public TrueSyncWaypointMove move
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

	private void Awake()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected override void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
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
		}
	}

	public unsafe void OnDeterministicCollisionStay(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public void OnDeterministicCollisionEnter(DeterministicCollider other)
	{
	}

	public void OnDeterministicCollisionExit(DeterministicCollider other)
	{
	}

	protected override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	protected override void OnDeactive()
	{
	}

	public AdventureTrap()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
