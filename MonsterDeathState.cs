using System;
using UnityEngine;

public class MonsterDeathState : ActorDeathState
{
	public override void OnEnter(IBehaviourState<GameObject> preStatus, Action onComplete = null, Action onLeave = null)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected override void FinishDied()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public MonsterDeathState()
	{
		/*Error: Invalid field token*/;
	}
}
