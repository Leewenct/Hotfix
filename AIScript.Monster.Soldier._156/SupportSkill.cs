using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.Soldier._156;

public class SupportSkill : SkillAdvancedBase
{
	private readonly string comboTag;

	private readonly string eventName_Summon;

	private readonly int summonedChessId;

	private readonly TSVector2 summonOffset;

	private readonly int shieldId_Potential;

	private readonly string areaEffectKey_Potenial;

	private int _potentialLv;

	private readonly List<SoldierActor> _targetSoldierActors;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void OnStart()
	{
		// ILSpy could not decompile this member: Error decompiling @06010A93 AIScript.Monster.Soldier._156.SupportSkill.OnStart: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06010A93 AIScript.Monster.Soldier._156.SupportSkill.OnStart
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

	private void OnCustomEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			((sbyte[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	private void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private void OnInterrupt()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected override void OnSkillDisable()
	{
		/*Error: Invalid field token*/;
	}

	public unsafe SupportSkill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF9*/;
	}
}
