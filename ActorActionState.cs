using System;
using UnityEngine;

public class ActorActionState : ActorStateBase<ActorPrimeFSM>
{
	public override int GetStateID()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public override void OnEnter(IBehaviourState<GameObject> preStatus, Action onComplete = null, Action onLeave = null)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	public ActorActionState()
	{
		/*Error: Invalid field token*/;
	}
}
