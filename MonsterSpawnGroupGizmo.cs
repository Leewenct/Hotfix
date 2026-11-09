using System.Collections.Generic;
using TrueSync;

public class MonsterSpawnGroupGizmo : BaseSpawnPointGizmo
{
	public bool enableDelayActiveCondition;

	public FP delaySpawnDuration;

	public bool enableMaxMonsterCount;

	public int maxMonsterCount;

	public int minMonsterCount;

	public FP delayActiveMonsterDuration;

	public FP intervalTime;

	protected bool enableDelayActiveMonster;

	public bool isSyncActive;

	protected FP _timerToActiveLogic;

	protected bool logicActived;

	private int curSpawnIndex;

	private int delayActiveCount;

	[ReadOnly]
	public int monsterLevel;

	private FP lastTime;

	public override void EnableSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0;
			/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override void ResetSpawnState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xE6*/;
		}
	}

	protected void ActiveSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
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
		}
	}

	public override void UpdateSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		FP val = (FP)checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override bool CheckActiveConditions()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
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

	public override bool IsAllActived()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public List<MonsterSpawnPointGizmo> GetInstableMonsters()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected Obj, but got I
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			List<MonsterSpawnPointGizmo> list = (List<MonsterSpawnPointGizmo>)(nint)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void ChildMonsterDied()
	{
		// ILSpy could not decompile this member: Error decompiling @06001460 MonsterSpawnGroupGizmo.ChildMonsterDied: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06001460 MonsterSpawnGroupGizmo.ChildMonsterDied
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

	public override void JumpOverBornPerformance(bool jumpOver = false)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public override List<long> GetSpawnedEntities()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected Obj, but got I
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			List<long> list = (List<long>)(nint)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override int DiedMonsterCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override int RemindMonsterCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public MonsterSpawnGroupGizmo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
