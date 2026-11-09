[AdventureEffect(HotfixEnum.effectType.IMMUNE_DEAD)]
public class ImmuneDead : AdventureEffectBase
{
	private int _maxTime;

	private int _curTime;

	public override void InitParams()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/^ /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0009: Unknown opcode: 0xFEBB*/;
	}

	public override void AddListenerer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/== 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xFE20*/;
		}
	}

	public override void RemoveListener()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/> 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xFE20*/;
		}
	}

	public unsafe override void Execute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got Unknown
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		if (false)
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (float)val;
		/*Error near IL_0008: stloc 2 (out-of-bounds)*/;
		if (/*Error near IL_000b: Stack underflow*/ <= /*Error near IL_000b: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		*(_003F*)(nint)/*Error near IL_000c: Stack underflow*/ = /*Error near IL_000c: Stack underflow*/;
		/*Error near IL_000c: Unknown opcode: 0xEF*/;
	}

	private void AccumulateTime()
	{
		// ILSpy could not decompile this member: Error decompiling @06001142 ImmuneDead.AccumulateTime: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06001142 ImmuneDead.AccumulateTime
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

	public ImmuneDead()
	{
		/*Error: Invalid field token*/;
	}
}
