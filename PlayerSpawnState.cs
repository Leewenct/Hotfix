using System;
using UnityEngine;

public class PlayerSpawnState : ActorSpawnState
{
	public override void OnEnter(IBehaviourState<GameObject> preStatus, Action onComplete = null, Action onLeave = null)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	public override void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public PlayerSpawnState()
	{
		/*Error: Invalid field token*/;
	}
}
