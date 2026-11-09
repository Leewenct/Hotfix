using System;
using AIScript.Monster.Template;

namespace AIScript.Monster._50531DaGuanZi;

public class Parallel : AIScript.Monster.Template.Parallel
{
	private const HotfixEnum.questCompleteCondClient achievementType_1 = HotfixEnum.questCompleteCondClient.DaGuanZi_001;

	private const HotfixEnum.questCompleteCondClient achievementType_2 = HotfixEnum.questCompleteCondClient.DaGuanZi_002;

	private readonly string LogicTag_IsXiaoGuanZi;

	private bool _achievementTypeFinish_1;

	private bool _achievementTypeFinish_2;

	public override void OnStart()
	{
		// ILSpy could not decompile this member: Error decompiling @0600D8AF AIScript.Monster._50531DaGuanZi.Parallel.OnStart: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0600D8AF AIScript.Monster._50531DaGuanZi.Parallel.OnStart
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1198
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	public override void OnDisable()
	{
		/*Error: Invalid field token*/;
	}

	private void InitAchievementData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnActorDied(IEvent evt)
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
		/*Error near IL_0009: Invalid metadata token*/;
	}

	private bool SetAchievementState(HotfixEnum.questCompleteCondClient achievementType)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got I8
		*(short*)(nint)/*Error near IL_0003: Stack underflow*/ = (short)(*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (IntPtr)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xE7*/;
	}
}
