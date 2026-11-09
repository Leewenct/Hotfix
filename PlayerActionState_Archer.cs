using System;
using TrueSync;
using UnityEngine;

public class PlayerActionState_Archer : PlayerActionState
{
	public override void OnEnter(IBehaviourState<GameObject> preStatus, Action onComplete = null, Action onLeave = null)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	public override void OnLeave(IBehaviourState<GameObject> nextState)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public override void OnMovementInput(bool movementHasInput, TSVector2 movementInputVector, TSVector2 movementInputDirection)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	public PlayerActionState_Archer()
	{
		/*Error: Invalid field token*/;
	}
}
