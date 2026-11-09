using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.DynamicLevel;

public class TutorialLevelProcessBase
{
	[CompilerGenerated]
	private sealed class _003CWaitTime_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FP time;

		public Action onFinish;

		private FP _003CwaitTime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CWaitTime_003Ed__33(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected I4, but got Unknown
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
			case 20:
				/*Error: Invalid branch target*/;
			case 21:
				/*Error: Invalid branch target*/;
			case 22:
				/*Error: Invalid branch target*/;
			case 23:
				/*Error: Invalid branch target*/;
			case 24:
				/*Error: Invalid branch target*/;
			case 25:
				/*Error: Invalid branch target*/;
			case 26:
				/*Error: Invalid branch target*/;
			case 27:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	protected Action _triggerNextTask;

	protected PlayerAdventureActor _actor;

	protected int _subProcessIndex;

	private List<CoroutineNode> _waitTimeCorList;

	private bool _triggerNextTaskWithTutorialCard;

	private int _currentTutorialCardId;

	private const int buffId_ImmunityDead = 911210100;

	public void Init(Action triggerNextTask)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public virtual void OnLevelStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (false)
			{
			}
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected void TriggerNextTask(int tutorialCardId = 0, bool isLevelStart = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected void StartWaitTime(FP time, Action onFinish = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
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
		}
	}

	protected void StopWaitTime(CoroutineNode waitTimeCor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	protected void EnableButtonControl(string buttonName, bool isEnable)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void AddRoomBuff(int buffId)
	{
		//Discarded unreachable code: IL_0010
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void UpdateOperationTips(string tipsKey)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void OpenTutorialCard(int tutorialCardId, bool isLevelStart = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if ((sbyte)(ulong)/*Error near IL_0007: Stack underflow*/ == 0)
			{
			}
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	protected void ShowTutorialButtonHint(string buttonName, bool isShow)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void TriggerGuide(int guideId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected bool TriggerPerkSelect(List<int> perkIdList)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 230 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public virtual void OnUpdateLogic(FP deltaTime)
	{
	}

	private void OnTutorialCardClose(IEvent _)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
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
		}
	}

	protected virtual void OnTutorialCardClose(int tutorialCardId)
	{
	}

	private unsafe void OnGuideEnd(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected virtual void OnGuideEnd(int guideId)
	{
	}

	private unsafe void RoomWaveMonsterCleared(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*/+ *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	protected virtual void OnRoomWaveMonsterCleared(AdventureLevelRoomWaveMonsterClearedEvent waveClearEvent)
	{
	}

	public virtual void OnTriggerNextTask(int taskId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	public virtual void OnTaskTargetSuccess(int taskId, int taskTargetId, bool isLasTaskTarget = false)
	{
	}

	public virtual void OnTaskFinish(int taskId, bool isLastTask = false)
	{
	}

	public virtual void OnLevelEnd()
	{
		//Discarded unreachable code: IL_007f
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void ActiveMonsterSpawnWave(string waveName)
	{
		//Discarded unreachable code: IL_001e
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected CoroutineNode StartLogicCoroutine(IEnumerator routine, bool runImmediately = false)
	{
		/*Error: Invalid metadata token*/;
	}

	protected void StopLogicCoroutine(CoroutineNode coroutine)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		_ = 3.6395676E-26f;
		/*Error: End of method reached without returning.*/;
	}

	[IteratorStateMachine(typeof(_003CWaitTime_003Ed__33))]
	protected IEnumerator WaitTime(FP time, Action onFinish = null)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
