using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Game/Adventure/Gizmo/Interactable Event Trigger")]
public class AdventureInteractableEventTriggerGizmo : AdventureTriggerGizmo
{
	public int attributeId;

	protected bool _triggered;

	protected Action _onComplete;

	public bool isActived
	{
		get
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	public int activedCount
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

	public override void Initialize()
	{
	}

	public override void Initialize(int x, int y)
	{
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCE*/;
	}

	protected override void TriggerStay(GameObject playerAgent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
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
		}
	}

	protected unsafe override void TriggerExit(GameObject playerAgent)
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public bool Active(bool uniqueness = true, Action onComplete = null, GameObject owner = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = (nint)(object)this;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected unsafe void OnComplete()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB2*/;
	}

	protected override void OnActive()
	{
	}

	protected override void OnDeactive()
	{
	}

	public AdventureInteractableEventTriggerGizmo()
	{
		/*Error: Invalid field token*/;
	}
}
