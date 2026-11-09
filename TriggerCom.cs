using System;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

public class TriggerCom : LogicEntity
{
	public string[] GroupTitles;

	public bool defaultActive;

	public TriggerManager.triggerState triggerAfterState;

	public float activeTime;

	private FP activeTimeFP;

	public bool conditionRsAnd;

	public TriggerConditionBase[] triggerConditions;

	private TriggerManager.triggerState state;

	private int triggerCount;

	private FP waitTime;

	[HideInInspector]
	public bool isInterActiveTrigger;

	[Space]
	public TriggerTask triggerTask;

	public int x
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

	public int y
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

	public unsafe string triggerName
	{
		get
		{
			_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB1*/;
		}
	}

	protected unsafe override void OnInit()
	{
		_ = *(short*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected override void OnActive()
	{
		/*Error: Invalid field token*/;
	}

	protected override void OnDeactive()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void InitializeXY(int x, int y)
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
		_ = -(-2110631930);
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
	}

	public void RestState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0x24*/;
		}
	}

	public void Initialize(int x, int y, bool iInteractive = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 212 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
		}
		((IntPtr[])/*Error near IL_0007: Stack underflow*/)[(nint)((IntPtr[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/]] = (IntPtr)x;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	protected override void OnLogicUpdatePaused()
	{
	}

	protected override void OnLogicUpdateResumed()
	{
	}

	protected override void OnLogicUpdate()
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

	public void OnTrigger()
	{
		// ILSpy could not decompile this member: Error decompiling @06001E8E TriggerCom.OnTrigger: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06001E8E TriggerCom.OnTrigger
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1217
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	private void OnCompelte()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) / 0;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private GameObject GetTriggerObj()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void ExcuteSingleTask()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
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

	private void ConditionsReset(bool isInit = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public bool SetTriggerState(TriggerManager.triggerState _state)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
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
		}
	}

	public bool CheckGroup(string groupTitle)
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

	public TSVector2 GetSpecifyMonsterPos()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void AddTask()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xA6*/;
	}

	public TriggerCom()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid field token*/;
	}
}
