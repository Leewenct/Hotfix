using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using Pathfinding;
using TrueSync;
using UnityEngine;

public class DormActor : DormEntity
{
	public enum DormActoBehaviour
	{
		Idle,
		Move,
		EnterFsm
	}

	public enum DormActorState
	{
		None,
		Control,
		Rome,
		Noticed,
		Hover,
		Interactive,
		Hide
	}

	public enum ActorBehaviourMode
	{
		Default,
		BeControlled
	}

	public enum DormMode
	{
		Default,
		View,
		Edit,
		Visitor,
		SwitchActor
	}

	[CompilerGenerated]
	private sealed class _003CPlayFacialExpressionCoroutine_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public DormActor _003C_003E4__this;

		public SDFacialExpression id;

		public float duration;

		public Action onComplete;

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
		public _003CPlayFacialExpressionCoroutine_003Ed__79(int _003C_003E1__state)
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
			//IL_00af: Expected I4, but got Unknown
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
			case 28:
				/*Error: Invalid branch target*/;
			case 29:
				/*Error: Invalid branch target*/;
			case 30:
				/*Error: Invalid branch target*/;
			case 31:
				/*Error: Invalid branch target*/;
			case 32:
				/*Error: Invalid branch target*/;
			case 33:
				/*Error: Invalid branch target*/;
			case 34:
				/*Error: Invalid branch target*/;
			case 35:
				/*Error: Invalid branch target*/;
			case 36:
				/*Error: Invalid branch target*/;
			case 37:
				/*Error: Invalid branch target*/;
			case 38:
				/*Error: Invalid branch target*/;
			case 39:
				/*Error: Invalid branch target*/;
			case 40:
				/*Error: Invalid branch target*/;
			case 41:
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

	[CompilerGenerated]
	private sealed class _003CRandomBlinkCoroutine_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DormActor _003C_003E4__this;

		private float _003ChalfBlinkDuration_003E5__2;

		private float _003Ct_003E5__3;

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
		public _003CRandomBlinkCoroutine_003Ed__85(int _003C_003E1__state)
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
			//IL_018d: Expected I4, but got Unknown
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
			case 28:
				/*Error: Invalid branch target*/;
			case 29:
				/*Error: Invalid branch target*/;
			case 30:
				/*Error: Invalid branch target*/;
			case 31:
				/*Error: Invalid branch target*/;
			case 32:
				/*Error: Invalid branch target*/;
			case 33:
				/*Error: Invalid branch target*/;
			case 34:
				/*Error: Invalid branch target*/;
			case 35:
				/*Error: Invalid branch target*/;
			case 36:
				/*Error: Invalid branch target*/;
			case 37:
				/*Error: Invalid branch target*/;
			case 38:
				/*Error: Invalid branch target*/;
			case 39:
				/*Error: Invalid branch target*/;
			case 40:
				/*Error: Invalid branch target*/;
			case 41:
				/*Error: Invalid branch target*/;
			case 42:
				/*Error: Invalid branch target*/;
			case 43:
				/*Error: Invalid branch target*/;
			case 44:
				/*Error: Invalid branch target*/;
			case 45:
				/*Error: Invalid branch target*/;
			case 46:
				/*Error: Invalid branch target*/;
			case 47:
				/*Error: Invalid branch target*/;
			case 48:
				/*Error: Invalid branch target*/;
			case 49:
				/*Error: Invalid branch target*/;
			case 50:
				/*Error: Invalid branch target*/;
			case 51:
				/*Error: Invalid branch target*/;
			case 52:
				/*Error: Invalid branch target*/;
			case 53:
				/*Error: Invalid branch target*/;
			case 54:
				/*Error: Invalid branch target*/;
			case 55:
				/*Error: Invalid branch target*/;
			case 56:
				/*Error: Invalid branch target*/;
			case 57:
				/*Error: Invalid branch target*/;
			case 58:
				/*Error: Invalid branch target*/;
			case 59:
				/*Error: Invalid branch target*/;
			case 60:
				/*Error: Invalid branch target*/;
			case 61:
				/*Error: Invalid branch target*/;
			case 62:
				/*Error: Invalid branch target*/;
			case 63:
				/*Error: Invalid branch target*/;
			case 64:
				/*Error: Invalid branch target*/;
			case 65:
				/*Error: Invalid branch target*/;
			case 66:
				/*Error: Invalid branch target*/;
			case 67:
				/*Error: Invalid branch target*/;
			case 68:
				/*Error: Invalid branch target*/;
			case 69:
				/*Error: Invalid branch target*/;
			case 70:
				/*Error: Invalid branch target*/;
			case 71:
				/*Error: Invalid branch target*/;
			case 72:
				/*Error: Invalid branch target*/;
			case 73:
				/*Error: Invalid branch target*/;
			case 74:
				/*Error: Invalid branch target*/;
			case 75:
				/*Error: Invalid branch target*/;
			case 76:
				/*Error: Invalid branch target*/;
			case 77:
				/*Error: Invalid branch target*/;
			case 78:
				/*Error: Invalid branch target*/;
			case 79:
				/*Error: Invalid branch target*/;
			case 80:
				/*Error: Invalid branch target*/;
			case 81:
				/*Error: Invalid branch target*/;
			case 82:
				/*Error: Invalid branch target*/;
			case 83:
				/*Error: Invalid branch target*/;
			case 84:
				/*Error: Invalid branch target*/;
			case 85:
				/*Error: Invalid branch target*/;
			case 86:
				/*Error: Invalid branch target*/;
			case 87:
				/*Error: Invalid branch target*/;
			case 88:
				/*Error: Invalid branch target*/;
			case 89:
				/*Error: Invalid branch target*/;
			case 90:
				/*Error: Invalid branch target*/;
			case 91:
				/*Error: Invalid branch target*/;
			case 92:
				/*Error: Invalid branch target*/;
			case 93:
				/*Error: Invalid branch target*/;
			case 94:
				/*Error: Invalid branch target*/;
			case 95:
				/*Error: Invalid branch target*/;
			case 96:
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

	private bool _spawnBehaviourPending;

	private int _logicStopRC;

	private static readonly int RunSpdAnimParameterHash;

	private float _animGait;

	private Vector3 _animPrevPos;

	private bool _animPrevPosValid;

	private float _animSpdSmoothed;

	private string _interruptWwiseEventName;

	private static readonly Collider[] s_playAnimSpaceOverlapBuffer;

	private static readonly int kPlayAnimSpaceCheckMask;

	private const float PLAY_ANIM_SPACE_GIZMO_DURATION = 2f;

	private Coroutine _playFacialExpCoroutine;

	private Coroutine _randomBlinkCoroutine;

	protected ActorBehaviourMode _behaviourMode;

	private AdventureFXPlayer curBubbleEmoji;

	private AdventureFXPlayer curEmojiFX;

	private float _furnitureInteractCooldownUntil;

	private DormFurObj _reservedInteractFur;

	private DormFurObjInteractivePoint _reservedInteractPoint;

	protected Coroutine corWaitForNextBehaviour;

	protected Coroutine corInteractiveBehaviour;

	protected Coroutine corInteractiveWait;

	private bool _roamArrived;

	private bool _roamRepick;

	private Action _onInteractiveComplete;

	private Vector3 _curInteractFurniturePos;

	private bool _hasCurInteractFurniturePos;

	private bool _leaveFurniturePending;

	private Vector3 _leaveFurnitureFromPos;

	private DormActorMoveAgent moveAgent;

	private bool blockMoveBehaviour;

	private Seeker seeker;

	private bool _heldByInteractIcon;

	private bool _pendingReleaseAfterInteraction;

	private bool _noticeFaceCamera;

	protected DormMode dormMode;

	protected DormActorStateMgr stateMgr;

	public DormRole RoleData
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public DormRoleSkin SkinData
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public int RoleId
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public int SkinId
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public unsafe bool IsLogicStopped
	{
		get
		{
			//IL_0002: Invalid comparison between Unknown and I
			nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if ((nint)/*Error near IL_0004: Stack underflow*/ >= (nint)num)
			{
				/*Error: Invalid branch target*/;
			}
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0005: Stack underflow*/);
			/*Error near IL_0005: Unknown opcode: 0xE9*/;
		}
	}

	public CapsuleCollider collider
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

	public DormCommonInteractionAnimationLibrary animLibrary
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isPlayingFacialExpression
	{
		get
		{
			checked
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0002: Invalid branch target*/;
			}
		}
	}

	public bool isRandomBlinkEnabled
	{
		get
		{
			//IL_0002: Invalid comparison between Unknown and I
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Invalid comparison between Unknown and I4
			nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if ((nint)/*Error near IL_0007: Stack underflow*/ == (nint)num)
			{
				/*Error: Invalid branch target*/;
			}
			if ((int)/*Error near IL_000a: Stack underflow*/ <= (int)(ushort)(/*Error near IL_0008: Stack underflow*/ & /*Error near IL_0008: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error: End of method reached without returning.*/;
		}
	}

	public unsafe bool IsFurnitureInteractOnCooldown
	{
		get
		{
			_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
			return (byte)(int)/*OpCode not supported: Nop*/ != 0;
		}
	}

	protected virtual float walkSpeed
	{
		get
		{
			_ = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xE5*/;
		}
	}

	protected virtual float runSpeed
	{
		get
		{
			_ = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xC0*/;
		}
	}

	protected virtual bool blockOtherActorsHard
	{
		get
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	protected virtual float rvoPriority
	{
		get
		{
			//IL_0001: Invalid comparison between Unknown and I4
			if ((int)/*Error near IL_0006: Stack underflow*/ >= (int)((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/])
			{
				/*Error: Invalid branch target*/;
			}
			/*Error: End of method reached without returning.*/;
		}
	}

	public bool IsMoving
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected I4, but got Unknown
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
			}
		}
	}

	private DormActorFSM_Noticed NoticedFSM
	{
		get
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
	}

	public bool IsNoticeFaceCamera
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public bool IsHeldByInteractIcon
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public bool IsHoldingInPlace
	{
		get
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
	}

	public bool ShouldReleaseHoldNow
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I4, but got Unknown
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
			}
		}
	}

	public unsafe bool CanBeNoticedByPlayer
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0003: Stack underflow*/+ *unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}
	}

	public bool IsNoticedByPlayerBusy
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xCA*/;
			}
		}
	}

	public unsafe DormActorState FSMState
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid field token*/;
		}
	}

	public bool IsInteractionUninterruptible
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void Awake()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid branch target*/;
		}
	}

	protected override void OnEnable()
	{
		/*Error: Invalid field token*/;
	}

	protected override void OnDisable()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void LoadData(DormRole roleData, DormRoleSkin skinData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
		}
		_ = -(-1739829242);
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
	}

	public unsafe void Spawn()
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public bool ConsumeSpawnBehaviourPending()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
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
		}
	}

	protected virtual void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
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
		}
	}

	protected virtual void LateUpdate()
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

	public void OnStartDrag()
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	public void OnDrag(TSVector2 position, FP positionY)
	{
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCE*/;
	}

	public void OnStopDrag()
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	public void StopLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	public void ResumeLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	public void ResetLogicStopped()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
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

	public void RestoreVisibleAndLogic()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected override void InitializeComponents()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ushort)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	protected override void ReleaseComponents()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Not a type handle*/;
	}

	protected override void InitializeVisual()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void StopAction()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
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

	public void ResumeAction()
	{
		/*Error: Invalid field token*/;
	}

	protected override void InitializeAnimation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: ldloc 154 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void ReleaseAnimation()
	{
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public void PlayIdle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	public void PlayWalk()
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

	public void PlayRun()
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

	public void UpdateMoveAnimSpeed()
	{
		/*Error: Unknown opcode: 0xC4*/;
	}

	public unsafe void ResetMoveAnimSpeedSampling()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public void PlayIdleShowAnim(Action onComplete = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 4;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public unsafe void StopIdleShowAnim()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		_ = /*Error near IL_0004: Stack underflow*/- /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xE4*/;
	}

	public void PlayCatchAnim(Action onComplete = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 4;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public unsafe void StopCatchAnim()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		_ = /*Error near IL_0004: Stack underflow*/- /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xE4*/;
	}

	public void PlayAnimByName(string aniName, float crossFadeTime = 0f)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = ((object[])0)[/*Error near IL_0002: ldloc 2 (out-of-bounds)*/];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnInterruptTimelineAnimation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I4, but got Unknown
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
		}
	}

	private bool CheckPlayAnimSpaceEnough(GameObject timelinePrefab)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			Collider val = default;
			_ = ((object[])0)[(object)val];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private bool FilterSpaceCheckHits(int hitCount)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private unsafe void DrawPlayAnimSpaceCheckGizmo(Transform anchor, bool isCapsule, Vector3 p0, Vector3 p1, float radius, Vector3 boxCenter, Vector3 boxHalfExtents, bool spaceEnough)
	{
		//Discarded unreachable code: IL_0020, IL_0038
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		if (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public void PlayFacialExpression(SDFacialExpression id, float duration, float delay = 0f, Action onComplete = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 0;
		/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[val];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	[IteratorStateMachine(typeof(_003CPlayFacialExpressionCoroutine_003Ed__79))]
	private IEnumerator PlayFacialExpressionCoroutine(SDFacialExpression id, float duration, float delay, Action onComplete)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void StartRandomBlink()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 0;
		/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[val];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void StopRandomBlink()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I4, but got Unknown
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

	[IteratorStateMachine(typeof(_003CRandomBlinkCoroutine_003Ed__85))]
	private IEnumerator RandomBlinkCoroutine()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0008: Stack underflow*/ < /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public AdventureFXPlayer PlayBubbleEmoji(string path)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public AdventureFXPlayer PlayEmojiFX(string path)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	internal AdventureFXPlayer PlayFX(string path)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	internal AdventureFXPlayer PlayFX(GameObject prefab)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (AdventureFXPlayer)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
	}

	public void BeginFurnitureInteractCooldown()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xE3*/;
		}
	}

	public void ReserveFurnitureInteractPoint(DormFurObj fur, DormFurObjInteractivePoint point)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public bool TryConsumeFurnitureInteractReservation(DormFurObj fur, out DormFurObjInteractivePoint point)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public void ReleaseFurnitureInteractReservation()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void SelectBehaviour()
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	public void StopInteractiveWithObject()
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	public virtual void InterWithObjeComplete()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xA9*/;
		}
	}

	protected void MarkLeaveFurniturePending()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
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

	public bool ConsumeLeaveFurniturePending(out Vector3 furniturePos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = 2;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	public unsafe void DiscardLeaveFurniturePending()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void InvokeInteractiveCompleteCallback()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
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

	public void DiscardInteractiveCompleteCallback()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void DoInteractiveWithObject(DormInteractiveContext ctx, Action callback = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_000e: Stack underflow*/>> (int)checked(unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/)) + 2025674875L);
		/*Error near IL_000e: Unknown opcode: 0xA8*/;
	}

	public void PlayInteractiveBehaviour(Action callback = null)
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	public void StopInteractiveBehaviour()
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

	protected virtual void InitializeMoveAgent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ushort)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xEF*/;
		}
	}

	private unsafe float GetSpreadRvoPriority()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (byte)/*Error near IL_0003: Stack underflow*/;
			_ = 4;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void InitializeRVOController()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected virtual void ReleaseMoveAgent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	public bool CheckPositionWalkable(Vector3 position)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void SetAvoidanceSimulationEnabled(bool enable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 217 (out-of-bounds)*/;
			_ = null;
			/*Error near IL_0004: ldloc 2 (out-of-bounds)*/;
			_ = 3;
			/*Error near IL_0006: Not a type handle*/;
		}
	}

	public void UpdateStationaryAvoidance()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBE*/;
		}
	}

	public void DisableMovment()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void EnableMovment()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public unsafe void MoveTo(Vector3 pos, Action callback = null, Action onStuck = null)
	{
		_ = (ushort)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	public void ForwardMove(Vector2 moveDirection, bool bWalk = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
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
		}
	}

	public bool TryGetRandomWalkablePointInScene(out Vector3 result, float minDistanceFromSelf = 0f, int maxAttempts = 16)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xC0*/;
		}
	}

	public bool TryGetNearestWalkablePoint(Vector3 position, out Vector3 result)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public unsafe float GetFacingYaw()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I, but got I8
		//IL_000b: Expected native int or pointer, but got F8
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		*(IntPtr*)(nint)(-501814144) = (nint)checked((long)/*Error near IL_0008: ldarg 1 (out-of-bounds)*/);
		_ = ~0L;
		/*Error near IL_000e: Unknown opcode: 0xE5*/;
	}

	public void SyncRotation(float yawDegrees)
	{
		/*Error: Unknown opcode: 0xF7*/;
	}

	public unsafe void SyncMovementLocation(TSVector2 position, FP positionY)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I8, but got F8
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
		}
		*(long*)(-1911100288) = long.MinValue;
		/*Error near IL_0012: Unknown opcode: 0xCF*/;
	}

	public void RelocateOntoNavmesh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
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
		}
	}

	public void StopMove()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private void BlockMoveBehaviour()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public void ResumeMoveBehaviour()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public void HoldByInteractIcon()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public void HoldByInteractIconFaceCamera()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private void EnterNoticedForViewSelect()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0x78*/;
		}
	}

	public void ReleaseInteractIconHold()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
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
		}
	}

	public void ReleaseToRome()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public void ClearInteractIconHoldState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public unsafe void NoticeByPlayer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/+ *unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void CancelNoticeByPlayer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
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
		}
	}

	protected virtual void RegisterFSM()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected void RegisterFSM(DormActorState state)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected void SwitchState(DormActorState state, object data = null)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xF6*/;
	}

	public void ResetStateForElevatorReentry()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void LeaveInteractiveToNone()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual void ResetToSpawnState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (sbyte)0;
			_ = 4;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void SuspendForPerform()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void RequestMoveAwayFrom(Vector3 avoidFromPos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	public void SwitchDormMode(DormMode dormMode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid field token*/;
		}
	}

	protected virtual void EnterModeDefault()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void EnterModeView()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void EnterModeVisitor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void EnterModeEdit()
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	protected virtual void EnterModeSwitchActor()
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	public DormActor()
	{
		/*Error: Invalid field token*/;
	}

	unsafe static DormActor()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Not a type handle*/;
	}
}
