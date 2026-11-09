using System.Collections.Generic;

namespace AIScript.Disc;

public class Disc_214007 : DiscScriptBase
{
	private const int discId = 214007;

	private static readonly List<int> skillIds_1;

	private static readonly List<int> buffIdList_1_1_1;

	private static readonly List<int> buffIdList_1_1_2;

	private const int buffId_1_2 = 4007006;

	private const int additionalAttrId_1_3_1 = 4007009;

	private const int additionalAttrId_1_3_2 = 4007010;

	private const int buffId_1_4 = 4007007;

	private const int buffId_1_5 = 4007008;

	private static readonly List<int> skillIds_2;

	private const int buffId_2 = 4007100;

	private static readonly List<int> skillIds_3;

	private const int additionalAttrId_3 = 4007200;

	private const int buffId_3 = 4007201;

	private int _discSkillLevel_1;

	private int _discSkillStage_1;

	private int _discSkillLevel_2;

	private int _discSkillLevel_3;

	protected override void OnDiscEnable()
	{
		//Discarded unreachable code: IL_0082
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 1u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnCastSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1680169239;
		}
	}

	protected unsafe override void OnBeforePlayerActorHit(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageBeforeHitEvent damageEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_0007: Stack underflow*/;
	}

	protected unsafe override void OnPlayerActorDamaged(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageEvent damageEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_0007: Stack underflow*/;
	}

	protected override void OnElementMarkTrigger(AdventureElementMarkTriggerEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1680170774;
		}
	}

	private void OnGetBuff(IEvent evt)
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

	private void OnAddShield(IEvent evt)
	{
		// ILSpy could not decompile this member: Error decompiling @0600C1C7 AIScript.Disc.Disc_214007.OnAddShield: Index was outside the bounds of the array.
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0600C1C7 AIScript.Disc.Disc_214007.OnAddShield
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

	private bool CheckActorIsLE(PlayerAdventureActor actor, bool checkAssit = false, bool isAssist = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	protected override void OnDiscDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 2u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public Disc_214007()
	{
		/*Error: Invalid field token*/;
	}

	unsafe static Disc_214007()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAE*/;
	}
}
