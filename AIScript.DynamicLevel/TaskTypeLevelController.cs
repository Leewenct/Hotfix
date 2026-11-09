using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.DynamicLevel;

public class TaskTypeLevelController : AdventureLevelController
{
	private class TaskTarget
	{
		[CompilerGenerated]
		private sealed class _003CProgessLogic_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaskTarget _003C_003E4__this;

			private FP _003Cprogress_003E5__2;

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
			public _003CProgessLogic_003Ed__45(int _003C_003E1__state)
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
				//IL_0097: Expected I4, but got Unknown
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

		private const int DefaultTotalProgess = 1;

		private string _param1;

		private string _param2;

		private string _param3;

		private string _param4;

		private readonly List<string> _param5;

		private Action<TaskTarget> _onFinish;

		private Action<TaskTarget> _onProcessUpdate;

		private FP _progess;

		private FP _totalProgess;

		private CoroutineNode _progessCor;

		public HotfixEnum.LevelQuestTargetType TargetType
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			private set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public int TaskId
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			private set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public int TaskTargetId
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			private set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public bool Success
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			private set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public FP CurrentProcess
		{
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public FP TotaltProcess
		{
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public void Init(int taskId, int taskTargetId, Action<TaskTarget> onFinish, Action<TaskTarget> onProcessUpdate)
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
			_ = -(nint)(-1348448250);
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}

		private void InitConfig()
		{
			/*Error: Unknown opcode: 0xFD*/;
		}

		private void InitTotalProgess()
		{
			// ILSpy could not decompile this member: Error decompiling @06014BF8 AIScript.DynamicLevel.TaskTypeLevelController.TaskTarget.InitTotalProgess: Invalid token. (Parameter 'token')
			// Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// Error decompiling @06014BF8 AIScript.DynamicLevel.TaskTypeLevelController.TaskTarget.InitTotalProgess
			// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
			//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
			//    at System.Reflection.Throw.InvalidToken() in offset 15
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
			//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1275
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
			// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
			// 
		}

		public bool CheckSuccessed()
		{
			//Discarded unreachable code: IL_0036
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnPlayerEnergyRecoverMax(PlayerAdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnPlayerCastSkill(PlayerAdventureActor actor, SkillEventInfo skillEventInfo)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnReduceSkillSection(PlayerAdventureActor actor, int skillId, HotfixEnum.skillSlotType skillSlotType)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnPlayerPlayCombo(PlayerAdventureActor actor, string comboTag)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnPlayerCastSkillEnd(PlayerAdventureActor actor, SkillEventInfo skillEventInfo)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnPlayerCauseDamage(PlayerAdventureActor actor, MonsterAdventureActor monster, int damageId, IList<int> damageTag)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnBreakMonsterToughness(PlayerAdventureActor actor, MonsterAdventureActor monster)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnPlayerKillMonster(PlayerAdventureActor actor, MonsterAdventureActor monster, IList<int> damageTag)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnMonsterDied(MonsterAdventureActor monster)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		public void OnReceiveInteractiveEvent(string eventId)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		[IteratorStateMachine(typeof(_003CProgessLogic_003Ed__45))]
		private IEnumerator ProgessLogic()
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0006: Unknown opcode: 0xCD*/;
		}

		private void UpdateProgess(FP progess)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBD*/;
			}
		}

		private void Finish(bool success)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1708305445;
			}
		}

		public void Clear()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			}
		}

		public TaskTarget()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				if (val <= val)
				{
					/*Error: Invalid branch target*/;
				}
				_ = /*Error near IL_0008: Stack underflow*/+ /*Error near IL_0008: Stack underflow*/;
				/*Error near IL_0008: Invalid metadata token*/;
			}
		}
	}

	protected new AdventureModuleLevelLoadParams levelLoadParams;

	private readonly Queue<int> _taskQueue;

	private int _currentTaskId;

	private readonly List<TaskTarget> _currentTaskTargets;

	private Queue<TaskTarget> _taskPool;

	public override void Load(AdventureModuleLevelLoadParams param = null, Action callback = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	protected override void LevelLoadComplete(string sceneName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a->IL000a: Incompatible stack heights: 1 vs 0
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = /*Error near IL_000a: Stack underflow*/% /*Error near IL_000a: Stack underflow*/;
		}
		/*Error near IL_000a: Unknown opcode: 0xC5*/;
	}

	public override void LevelStart(Action callback = null)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe void OnActorEnergyChange(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xED*/;
	}

	private unsafe void OnActorCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnActorPlayCombo(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((short[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnActorCastSkillEnd(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnActorReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnMonsterToughnessStateChange(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnActorDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnReceiveInteractiveEvent(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnActorProactiveReduceSkillSection(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected Obj, but got I4
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	public unsafe override void LevelEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		*(float*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0f;
		/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void OnActorEnergyChange(AdventureActorEnergyChangeEvent energyChangeEvent)
	{
	}

	protected virtual void OnActorCastSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	protected virtual void OnActorPlayCombo(AdventureActorPlayComboEvent playComboEvent)
	{
	}

	protected virtual void OnActorCastEndSkill(AdventureActorCastSkillEndEvent castSkillEndEvent)
	{
	}

	protected virtual void OnActorReceiveDamage(AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnMonsterToughnessStateChange(MonsterToughnessStateChangeEvent toughnessStateChangeEvent)
	{
	}

	protected virtual void OnActorDied(AdventureActorDiedEvent diedEvent)
	{
	}

	protected virtual void OnReceiveInteractiveEvent(AdventureInteractiveIDTrigger interactiveIDTriggerEvent)
	{
	}

	protected void InitTask(IList<int> taskIds, bool triggerFirstTask = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 212 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	protected void TriggerNextTask()
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

	private void InitTaskTarget()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected I4, but got Unknown
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
		}
	}

	protected void RestartCurrentTask()
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

	private void OnTaskTargetProcessUpdate(TaskTarget taskTarget)
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

	private void OnTaskTargetFinish(TaskTarget taskTarget)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected I4, but got Unknown
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
		}
	}

	protected virtual void OnTriggerNextTask(int taskId)
	{
	}

	protected virtual void OnTaskTargetSuccess(int taskId, int taskTargetId, bool isLasTaskTarget = false)
	{
	}

	protected virtual void OnTaskTargetFailed(int taskId, int taskTargetId)
	{
	}

	protected virtual void OnTaskFinish(int taskId, bool isLastTask = false)
	{
	}

	private TaskTarget GenerateTaskTarget(int questId, int questTargetId, Action<TaskTarget> onFinish = null, Action<TaskTarget> onProcessUpdate = null)
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

	private void RecycleTaskTarget(TaskTarget taskTarget)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEF*/;
		}
	}

	public TaskTypeLevelController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
