using System;
using UnityEngine;

namespace AIScript.DynamicLevel;

public class TowerCharacterDeathState : ActorDeathState
{
	public override void OnEnter(IBehaviourState<GameObject> preStatus, Action onComplete = null, Action onLeave = null)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	protected override void FinishDied()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public TowerCharacterDeathState()
	{
		/*Error: Invalid field token*/;
	}
}
