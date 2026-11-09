namespace AIScript.Monster.Soldier._30901;

public class NormalSkill : SkillAdvancedBase
{
	private const string actionKey = "NormalAttack";

	protected override void OnSkillEnable()
	{
		/*Error: Invalid field token*/;
	}

	protected override void OnSkillDisable()
	{
		/*Error: Invalid field token*/;
	}

	public void OnStart()
	{
		/*Error: Read out of bounds.*/;
	}

	protected void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected void OnInterrupt()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void OnUpdate()
	{
	}

	private void DoMainLogic()
	{
		// ILSpy could not decompile this member: Error decompiling @060108FF AIScript.Monster.Soldier._30901.NormalSkill.DoMainLogic: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @060108FF AIScript.Monster.Soldier._30901.NormalSkill.DoMainLogic
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeCall(OpCode opCode) in ILReader.cs:line 1760
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 879
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	private void onCustomEvent(string evt)
	{
	}

	public NormalSkill()
	{
		/*Error: Invalid field token*/;
	}
}
