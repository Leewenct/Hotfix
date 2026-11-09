using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster._31301JiJuXie;

public class Parallel_OctopusBattery_BossRush : Parallel_OctopusBattery
{
	private class WaveAgg
	{
		public int expected;

		public bool hit;

		public readonly HashSet<long> reported;

		public unsafe WaveAgg()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected F8, but got I
			*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = *(nint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			_ = ((ushort[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private class BulletWave
	{
		public FP startTime;

		public int alive;

		public bool hit;
	}

	private readonly HotfixEnum.scoreBossBehavior entryEnum_DodgeAttack;

	private static readonly int[] sprayScoreSkillIds;

	private static readonly FP bulletWaveTolerance;

	private MonsterAdventureActor _scoreBoss;

	private Dictionary<long, FP> _bulletShot;

	private bool _isSpraying;

	private bool _sprayHit;

	private FP _sprayWaveId;

	private FP _sprayWaveIdPending;

	private static readonly Dictionary<FP, WaveAgg> s_waves;

	private static readonly Dictionary<FP, BulletWave> s_bulletWaves;

	private static readonly List<FP> s_bulletSweepBuffer;

	public override void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/> 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
			/*Error near IL_0009: Unknown opcode: 0xC0*/;
		}
	}

	public override void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe void OpenWindow(FP waveId)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (sbyte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private unsafe void OnBulletBorn(IEvent evt)
	{
		//Discarded unreachable code: IL_003c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB0*/;
	}

	private unsafe void OnBulletFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB1*/;
	}

	private unsafe void OnActorCastSkillEnd(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnActorCustomEvent(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xEE*/;
	}

	private unsafe void OnActorReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe bool IsSprayScoreSkill(int skillId)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (nint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private void TryAddDodgeScore(FP waveId, bool isHit)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected I4, but got Unknown
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
		}
	}

	private void SettleBulletWave(BulletWave w)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
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
		}
	}

	private void SweepSettleClosedEmpty(FP now)
	{
		// ILSpy could not decompile this member: Error decompiling @0600E92B AIScript.Monster._31301JiJuXie.Parallel_OctopusBattery_BossRush.SweepSettleClosedEmpty: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0600E92B AIScript.Monster._31301JiJuXie.Parallel_OctopusBattery_BossRush.SweepSettleClosedEmpty
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeFieldReference() in ILReader.cs:line 251
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1227
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	private int CountActiveBatteries()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private MonsterAdventureActor FindBoss()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe Parallel_OctopusBattery_BossRush()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		_ = ((float[])/*Error near IL_000f: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >> (int)(short)(*(double*)16576132355884826341uL)];
		/*Error near IL_000f: Read out of bounds.*/;
	}

	static Parallel_OctopusBattery_BossRush()
	{
		/*Error: Unknown opcode: 0xED*/;
	}
}
