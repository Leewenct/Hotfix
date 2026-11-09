using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

public class MonsterSummonInfo : LogicComponent, ILogicComponentUpdate, ILogicComponent
{
	[CompilerGenerated]
	private sealed class _003CWaitForDestroySelf_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonsterSummonInfo _003C_003E4__this;

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
		public _003CWaitForDestroySelf_003Ed__42(int _003C_003E1__state)
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
			//IL_0054: Expected I4, but got Unknown
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

	private bool _isDestroy;

	private unsafe MonsterAdventureActor _actor
	{
		get
		{
			_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB1*/;
		}
	}

	public AdventureActor SummonActor
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

	public long SummonActorId
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0x77*/;
			}
		}
	}

	public SummonCfg SummonCfg
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

	public SummonType SummonType
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

	public bool IsCoexisted
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

	public bool HaveLeftTime
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

	public FP LeftTime
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

	public bool UseSummonHit
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

	public override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public override void OnDeactive()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void OnActorDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (short)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	internal void ParseSummonCfg(SummonCfg cfgData, ActorSpawnInfo actorSpawnInfo)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			_ = (nuint)unchecked((long)/*Error near IL_0009: ldarg 175 (out-of-bounds)*/);
		}
		SummonAttrType summonAttrType = (SummonAttrType)/*Error near IL_000d: ldarg 205 (out-of-bounds)*/;
	}

	private void CalcRougeAttr(int templeteId, int levelDifficultLv, int percent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (short)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void AddLeftTime(FP addTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void ResetLeftTime()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void DestroySelf()
	{
		// ILSpy could not decompile this member: Error decompiling @060007C3 MonsterSummonInfo.DestroySelf: Index was outside the bounds of the array.
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @060007C3 MonsterSummonInfo.DestroySelf
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException() in offset 5
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 523
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	[IteratorStateMachine(typeof(_003CWaitForDestroySelf_003Ed__42))]
	private IEnumerator WaitForDestroySelf()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0008: Stack underflow*/ >= /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public MonsterSummonInfo()
	{
		/*Error: Invalid field token*/;
	}
}
