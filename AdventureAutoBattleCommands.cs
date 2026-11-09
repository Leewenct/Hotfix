using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

public class AdventureAutoBattleCommands
{
	public enum AutoBattleCommandType
	{
		Standby,
		Attack,
		Skill,
		SkillUltimate,
		Dodge,
		CastSkill_1,
		CastSkill_2,
		CastUltimate_1,
		CastUltimate_2
	}

	public class AutoBattleCommandBase
	{
		private AdventurePlayerController playerController;

		protected PlayerAdventureActor actor;

		protected PlayerSkillCd skillMgr;

		protected int actorID;

		public float holdDuration;

		public virtual bool IsValid
		{
			get
			{
				/*Error: Unknown opcode: 0xC0*/;
			}
		}

		public AutoBattleCommandBase(int actorID)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		public AutoBattleCommandBase(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = (ushort)0;
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}

		public virtual bool Execute(Action callback)
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	public class AutoBattleCommand_Standby : AutoBattleCommandBase
	{
		public AutoBattleCommand_Standby(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		}

		public override bool Execute(Action callback)
		{
			/*Error: Unknown opcode: 0xE9*/;
		}
	}

	public class AutoBattleCommand_SkillBase : AutoBattleCommandBase
	{
		[CompilerGenerated]
		private sealed class _003CHoldCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AutoBattleCommand_SkillBase _003C_003E4__this;

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
			public _003CHoldCoroutine_003Ed__12(int _003C_003E1__state)
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
				//IL_0065: Expected I4, but got Unknown
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

		protected Action callback;

		protected int skillId;

		protected SkillPhaseFeatureFlag flag;

		protected ActionKey key;

		protected string holdingKey;

		private CoroutineNode holdCoroutine;

		public override bool IsValid
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Expected I4, but got Unknown
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
		}

		public AutoBattleCommand_SkillBase(int actorID)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				if (3315001771210620635L == 0L)
				{
					/*Error: Invalid branch target*/;
				}
				_ = /*Error near IL_000e: Stack underflow*/>> /*Error near IL_000d: Stack underflow*/* val;
				/*Error near IL_000e: Unknown opcode: 0xE1*/;
			}
		}

		public AutoBattleCommand_SkillBase(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				if (3315001771210620635L == 0L)
				{
					/*Error: Invalid branch target*/;
				}
				_ = /*Error near IL_000e: Stack underflow*/>> /*Error near IL_000d: Stack underflow*/* val;
				/*Error near IL_000e: Unknown opcode: 0xE1*/;
			}
		}

		public override bool Execute(Action callback)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
				/*Error near IL_0008: Invalid metadata token*/;
			}
		}

		protected void CreateSkillFinish(bool success)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
				/*Error near IL_0002: Unknown opcode: 0xE3*/;
			}
		}

		[IteratorStateMachine(typeof(_003CHoldCoroutine_003Ed__12))]
		protected IEnumerator HoldCoroutine()
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0006: Unknown opcode: 0xCD*/;
		}

		protected void Failed()
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

		protected unsafe virtual void OnCastSkillEnd(IEvent ievent)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected F8, but got I4
			((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	public class AutoBattleCommand_Attack : AutoBattleCommand_SkillBase
	{
		public AutoBattleCommand_Attack(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/;
				/*Error near IL_000d: Invalid metadata token*/;
			}
		}
	}

	public class AutoBattleCommand_Skill : AutoBattleCommand_SkillBase
	{
		public AutoBattleCommand_Skill(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/;
				_ = (nint)1792014852;
				/*Error near IL_000d: Invalid field token*/;
			}
		}
	}

	public class AutoBattleCommand_SkillUltimate : AutoBattleCommand_SkillBase
	{
		public AutoBattleCommand_SkillUltimate(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/ * unchecked((nuint)(-2077474815));
				/*Error near IL_000d: Invalid metadata token*/;
			}
		}
	}

	public class AutoBattleCommand_Dodge : AutoBattleCommand_SkillBase
	{
		public AutoBattleCommand_Dodge(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/ * unchecked((nuint)(-2077483007));
				/*Error near IL_000d: Invalid metadata token*/;
			}
		}

		protected override void OnCastSkillEnd(IEvent ievent)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		}
	}

	public class AutoBattleCommand_CastSkill_Support1 : AutoBattleCommand_SkillBase
	{
		public override bool IsValid
		{
			get
			{
				/*Error: Unknown opcode: 0xC0*/;
			}
		}

		public AutoBattleCommand_CastSkill_Support1(int actorID)
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public class AutoBattleCommand_CastSkill_Support2 : AutoBattleCommand_SkillBase
	{
		public override bool IsValid
		{
			get
			{
				/*Error: Unknown opcode: 0xC0*/;
			}
		}

		public AutoBattleCommand_CastSkill_Support2(int actorID)
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public class AutoBattleCommand_Ultimate_Support1 : AutoBattleCommand_SkillBase
	{
		public override bool IsValid
		{
			get
			{
				/*Error: Unknown opcode: 0xC0*/;
			}
		}

		public AutoBattleCommand_Ultimate_Support1(int actorID)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/ * unchecked((nuint)(-2060708863));
				/*Error near IL_000d: Read out of bounds.*/;
			}
		}
	}

	public class AutoBattleCommand_Ultimate_Support2 : AutoBattleCommand_SkillBase
	{
		public override bool IsValid
		{
			get
			{
				/*Error: Unknown opcode: 0xC0*/;
			}
		}

		public AutoBattleCommand_Ultimate_Support2(int actorID)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/ * unchecked((nuint)(-2060708351));
				/*Error near IL_000d: Read out of bounds.*/;
			}
		}
	}
}
