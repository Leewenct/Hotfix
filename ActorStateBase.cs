using System;
using System.Collections;
using TrueSync;
using UnityEngine;

public class ActorStateBase
{
	public virtual void OnEnable()
	{
	}

	public virtual void OnDisable()
	{
	}

	public virtual void OnPause()
	{
	}

	public virtual void OnResume()
	{
	}

	public virtual void OnDeterministicCollisionEnter(DeterministicCollider other)
	{
	}

	public virtual void OnDeterministicCollisionStay(DeterministicCollider other)
	{
	}

	public virtual void OnDeterministicCollisionExit(DeterministicCollider other)
	{
	}

	public virtual void OnMovementInput(bool movementHasInput, TSVector2 movementInputVector, TSVector2 movementInputDirection)
	{
	}

	public virtual void OnAnimationStateTransformation(string messageName, Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public virtual void OnAnimationStateMachineTransformation(string messageName, Animator animator, int stateMachinePathHash)
	{
	}
}
public class ActorStateBase<T> : ActorStateBase, IBehaviourState<GameObject>, ICoroutineOwner where T : ActorFSM
{
	protected T _fsm;

	protected AdventureActor _actor;

	protected AIAdapter _ai;

	public virtual int GetStateID()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public void SetFSM(BehaviourFSM<GameObject> fsm)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/* ((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		/*Error near IL_0008: Unknown opcode: 0xFD*/;
	}

	public void SetAI(string aiPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
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
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		}
	}

	public void ResetAI(string aiPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
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
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		}
	}

	public void SetAISpecialEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	public void ForceStartAI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	public override void OnPause()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	public override void OnResume()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCD*/;
		}
	}

	public virtual void OnEnter(IBehaviourState<GameObject> preStatus, Action onComplete = null, Action onLeave = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected I4, but got Unknown
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
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		}
	}

	public virtual void OnReset(Action onComplete = null, Action onLeave = null)
	{
	}

	public virtual void OnLeave(IBehaviourState<GameObject> nextState)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
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
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		}
	}

	public virtual void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected CoroutineNode StartLogicCoroutine(IEnumerator routine, bool runImmediately = false)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void StopLogicCoroutine(CoroutineNode coroutine)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public bool IsCoroutineAlive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
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

	public unsafe bool IsCoroutineRunning()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		if ((int)/*Error near IL_0007: ldloca 0 (out-of-bounds)*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = -1;
		/*Error: End of method reached without returning.*/;
	}

	public unsafe FP GetCoroutineDeltaTime()
	{
		//IL_0002: Expected F8, but got I4
		//IL_0007: Invalid comparison between Unknown and Obj
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		if ((object)/*Error near IL_000c: Stack underflow*/ != "敻◞攀\ued7b\ud8f3嘁ꘁ퐀慻㟞攀\uf17b嫳ᘁ\ue301㜀⽻◞砀\ude7b\u1df3䘁혁였楻ⓞ栀\uf37bퟳ혁\ud801䜀彻⛞")
		{
			/*Error: Invalid branch target*/;
		}
		/*Error: End of method reached without returning.*/;
	}

	public ActorStateBase()
	{
		/*Error: Invalid field token*/;
	}
}
