[AdventureEffect(HotfixEnum.effectType.DAMAGE_IMM_ACC)]
public class DamageImmunityAcc : AdventureEffectBase
{
	private int leftTime;

	private int curTime;

	public override void InitParams()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/<= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_0008: Stack underflow*/^ /*Error near IL_0008: Stack underflow*/;
			_ = (byte)(object)this;
			/*Error near IL_000a: Unknown opcode: 0xBB*/;
		}
	}

	public override void AddListenerer()
	{
		/*Error: Invalid field token*/;
	}

	public override void RemoveListener()
	{
		/*Error: Invalid field token*/;
	}

	public unsafe override void Execute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got Unknown
		//IL_000a: Expected F4, but got I4
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		if (false)
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (float)val;
		*(float*)(nint)/*Error near IL_000a: Stack underflow*/ = -1f;
		/*Error near IL_000a: Unknown opcode: 0xC5*/;
	}

	public unsafe override void PostExecute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Expected F4, but got I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (float)/*Error near IL_0008: Stack underflow*/;
		*(float*)(nint)/*Error near IL_000a: Stack underflow*/ = -1f;
		/*Error near IL_000a: Unknown opcode: 0xC5*/;
	}

	private void AccumulateCost()
	{
		// ILSpy could not decompile this member: Error decompiling @060010DB DamageImmunityAcc.AccumulateCost: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @060010DB DamageImmunityAcc.AccumulateCost
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

	public DamageImmunityAcc()
	{
		/*Error: Invalid field token*/;
	}
}
