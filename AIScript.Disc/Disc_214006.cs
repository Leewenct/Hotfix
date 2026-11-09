using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Disc;

public class Disc_214006 : DiscScriptBase
{
	private const int discId = 214006;

	private List<int> skillId_s1;

	private List<int> buff_s1v1_atk;

	private List<int> buff_s1v1_extra;

	private int buff_s1v2_dmg;

	private int maxCount_s1v2;

	private int buff_s1v3_dmg;

	private FP range_s1v3;

	private string effect_s1v3;

	private int buff_s1v4_atk;

	private int buff_s1v5_atk;

	private FP interval_slv5;

	private int lv_s1;

	private int stage_s1;

	private List<MonsterAdventureActor> monsters;

	private List<LogicEntity> entities;

	private int summonCount;

	private FP triggerTime;

	private PlayFX playFX;

	private PlayerAdventureActor mainCtrActor
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	protected override void OnDiscEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 1u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected unsafe override void OnCastSkill(AdventureActorCastSkillEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		_ = /*Error near IL_000e: Stack underflow*/^ checked(/*Error near IL_000d: Stack underflow*/ * -5692527157212419072L);
		/*Error near IL_000e: Unknown opcode: 0xCD*/;
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

	protected override void OnReceiveDamage(AdventureActorReceiveDamageEvent damageEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		}
	}

	private unsafe void OnActorSpawned(IEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 2;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnDied(AdventureActorDiedEvent evt)
	{
		// ILSpy could not decompile this member: Error decompiling @0600C1BF AIScript.Disc.Disc_214006.OnDied: Index was outside the bounds of the array.
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0600C1BF AIScript.Disc.Disc_214006.OnDied
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

	public unsafe Disc_214006()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
