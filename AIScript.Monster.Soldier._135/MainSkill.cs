using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.Soldier._135;

public class MainSkill : SkillAdvancedBase
{
	private const string actionKey = "MainSkill";

	private const string eventName_Summon = "Fire";

	private const int summonedChessId = 100007;

	private const int summonPerCast = 2;

	private const int maxSummonLive = 6;

	private static readonly List<TSVector2> summonOffset;

	private const int perkLv_BroadcastMin = 2;

	private static readonly int broadcastEvt;

	private const int perkLv_ExpandCap = 3;

	private const int summonPerCast_P3 = 1;

	private const int maxSummonBonus_P3 = 4;

	private static readonly FP extendPerCastSec;

	private static readonly int extendLifeEvt;

	private static readonly Dictionary<int, int> partnerDamageBuffId_TODODic;

	public HotfixEnum.ChessPartnerType partnerTypes;

	private LogicEntity _target;

	private int _potentialLv;

	private int _partnerLv;

	private float _partnerParam1Ratio;

	private bool _isExtraCombo;

	private int _nextOffsetIdx;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void OnStart()
	{
		/*Error: Read out of bounds.*/;
	}

	public void OnUpdate()
	{
	}

	private void OnFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
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
		}
	}

	private void OnInterrupt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: stloc 6 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xED*/;
		}
	}

	private void DoMainLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	private unsafe void OnCustomEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if ((uint)(*unchecked((ulong*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))) == 0)
			{
				/*Error: Invalid branch target*/;
			}
		}
	}

	private void BroadcastWhirlwindToExistingSummons()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void BroadcastExtendLifeToExistingSummons(FP addSec)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void BeginExtraCombo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private void TryRemovePartnerDamageBuff()
	{
		// ILSpy could not decompile this member: Error decompiling @06010C48 AIScript.Monster.Soldier._135.MainSkill.TryRemovePartnerDamageBuff: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06010C48 AIScript.Monster.Soldier._135.MainSkill.TryRemovePartnerDamageBuff
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1275
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	private unsafe bool TryGetPartnerDamageBuffId(out int buffId)
	{
		//IL_0003: Expected I8, but got I
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0002: Stack underflow*/);
		/*Error near IL_0004: Unknown opcode: 0xE8*/;
	}

	private static int CeilMulRatio(int count, float ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public MainSkill()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	unsafe static MainSkill()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 0;
		/*Error near IL_0002: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}
}
