using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._11801;

public class SkillScript_MainControl : SkillAdvancedBase
{
	private static readonly string actionTag;

	private static readonly int loopCount;

	private static readonly string lightAttackEventName;

	private static readonly int lightAttackHitDamageId;

	private static readonly FP lightAttackRadius;

	private static readonly TSVector2 lightAttackPosOffset;

	private static readonly string lightAttackEffectAlias;

	private static readonly string heavyAttackEventName;

	private static readonly int heavyAttackHitDamageId;

	private static readonly FP heavyAttackRadius;

	private static readonly TSVector2 heavyAttackPosOffset;

	private static readonly string heavyAttackEffectAlias_1;

	private static readonly string heavyAttackEffectAlias_2;

	private static readonly string hittedEffectAlias;

	private static readonly FP _stiffDuration;

	private static readonly FP _airBorneForce;

	private static readonly FP _hitStrength;

	private static readonly int perkId_1;

	private static readonly int loopCount_add;

	private static readonly int perkId_2;

	private static readonly int maxAttackLevel;

	private static readonly float lightAttackEffectScale_level1;

	private static readonly FP lightAttackRadius_level1;

	private static readonly TSVector2 lightAttackPosOffset_level1;

	private static readonly float lightAttackEffectScale_level2;

	private static readonly FP lightAttackRadius_level2;

	private static readonly TSVector2 lightAttackPosOffset_level2;

	private static readonly float lightAttackEffectScale_level3;

	private static readonly FP lightAttackRadius_level3;

	private static readonly TSVector2 lightAttackPosOffset_level3;

	private static readonly float heavyAttackEffectScale_level1;

	private static readonly FP heavyAttackRadius_level1;

	private static readonly TSVector2 heavyAttackPosOffset_level1;

	private static readonly float heavyAttackEffectScale_level2;

	private static readonly FP heavyAttackRadius_level2;

	private static readonly TSVector2 heavyAttackPosOffset_level2;

	private static readonly float heavyAttackEffectScale_level3;

	private static readonly FP heavyAttackRadius_level3;

	private static readonly TSVector2 heavyAttackPosOffset_level3;

	private readonly int perkId_5;

	private static readonly int buffId_Base_1;

	private int _currentLoopCount;

	private int _totalLoopCount;

	private int _attackCount;

	private PlayFX _playFX;

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		((short[])/*Error near IL_0003: Stack underflow*/)[val] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void OnStart()
	{
		// ILSpy could not decompile this member: Error decompiling @0601271B AIScript.Character._11801.SkillScript_MainControl.OnStart: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0601271B AIScript.Character._11801.SkillScript_MainControl.OnStart
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

	private void OnComboLoop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	private void OnCustom(string eventName)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private void OnInterrupt()
	{
		/*Error: Read out of bounds.*/;
	}

	public SkillScript_MainControl()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: ldloc 2 (out-of-bounds)*/;
			/*Error near IL_0003: Unknown opcode: 0xE7*/;
		}
	}

	unsafe static SkillScript_MainControl()
	{
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)checked((byte)(0.0 - (double)unchecked((int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))));
		((sbyte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (sbyte)/*Error near IL_0006: Stack underflow*/;
		*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
		_ = *(double*)(nint)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: Unknown opcode: 0xF4*/;
	}
}
