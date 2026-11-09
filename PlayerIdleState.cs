using System;
using UnityEngine;

public class PlayerIdleState : ActorIdleState
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

	public PlayerIdleState()
	{
		/*Error: Invalid field token*/;
	}
}
