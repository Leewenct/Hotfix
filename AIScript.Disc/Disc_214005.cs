using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Disc;

public class Disc_214005 : DiscScriptBase
{
	[CompilerGenerated]
	private sealed class _003CDiscLogic_1_5_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerAdventureActor actor;

		private FP _003Ctime_003E5__2;

		private FP _003Cinterval_003E5__3;

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
		public _003CDiscLogic_1_5_003Ed__31(int _003C_003E1__state)
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
			//IL_00ae: Expected I4, but got Unknown
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

	private const int discId = 214005;

	private static readonly List<int> skillIds_1;

	private static readonly List<int> buffIdList_1_1_1;

	private const int buffId_1_1_2 = 4005009;

	private static readonly List<int> parameterIdList_1_1_1;

	private static readonly List<int> parameterIdList_1_1_2;

	private const int buffId_1_2 = 4005005;

	private const int buffId_1_3 = 4005006;

	private const int parameterId_1_4 = 4005001;

	private const int buffId_1_4 = 4005007;

	private const int parameterId_1_5 = 4005002;

	private const int buffId_1_5 = 4005008;

	private static readonly List<int> skillIds_2;

	private const int buffId_2 = 4005100;

	private const int parameterId_2 = 4005005;

	private static readonly List<int> skillIds_3;

	private const int additionalAttrId_3 = 4005200;

	private int _discSkillLevel_1;

	private int _discSkillStage_1;

	private int _discSkillLevel_2;

	private int _discSkillLevel_3;

	private int _hitCount_1_4;

	private Dictionary<long, CoroutineNode> _discLogicCorDic_1_5;

	private FP _lastTriggerTime_2;

	protected override void OnDiscEnable()
	{
		//Discarded unreachable code: IL_0095
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 1u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnCastSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xAC*/;
		}
		/*Error near IL_007e: Unknown opcode: 0xE2*/;
	}

	protected override void OnCastEndSkill(AdventureActorCastSkillEndEvent castSkillEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ > (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: Unknown opcode: 0xAC*/;
	}

	protected unsafe override void OnBeforePlayerActorHit(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageBeforeHitEvent damageEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_0007: Stack underflow*/;
	}

	protected unsafe override void OnPlayerActorDamaged(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageEvent damageEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_0007: Stack underflow*/;
	}

	protected unsafe override void OnMainPlayerActorReceiveDamage(AdventureActor damageSource, PlayerAdventureActor mainActor, AdventureActorReceiveDamageEvent damageEvent)
	{
		//Discarded unreachable code: IL_005d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_0007: Stack underflow*/;
	}

	protected override void OnActorEnter(AdventurePlayerEnterEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1680148762;
		}
	}

	[IteratorStateMachine(typeof(_003CDiscLogic_1_5_003Ed__31))]
	private unsafe IEnumerator DiscLogic_1_5(PlayerAdventureActor actor)
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0005: ldloc 0 (out-of-bounds)*/);
		/*Error near IL_0007: Read out of bounds.*/;
	}

	protected unsafe override void OnActorLeave(AdventurePlayerLeaveEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			*(_003F*)(nint)/*Error near IL_000a: Stack underflow*/ = /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xBE*/;
		}
		if (checked(/*Error near IL_0014: Stack underflow*/ - /*Error near IL_0014: Stack underflow*/) == 0)
		{
			/*Error near IL_0017: Invalid metadata token*/;
		}
		/*Error near IL_0032: Unknown opcode: 0xF7*/;
	}

	private bool CheckActorIsWE(PlayerAdventureActor actor, bool checkAssit = false, bool isAssist = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	protected override void OnDiscDisable()
	{
		//Discarded unreachable code: IL_0026
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected I, but got I8
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 2u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public Disc_214005()
	{
		/*Error: Invalid field token*/;
	}

	unsafe static Disc_214005()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAE*/;
	}
}
