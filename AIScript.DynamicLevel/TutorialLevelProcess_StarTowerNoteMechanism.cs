using System.Collections.Generic;
using TrueSync;

namespace AIScript.DynamicLevel;

public class TutorialLevelProcess_StarTowerNoteMechanism : TutorialLevelProcessBase
{
	private readonly int buffId_Room;

	private readonly Dictionary<int, string> operationTipsDic;

	private readonly Dictionary<int, FP> waitTimeDic;

	private readonly List<int> showNoteIdList;

	private readonly Dictionary<int, Dictionary<int, int>> dropNoteDic;

	private readonly Dictionary<int, List<int>> activeNoteSkillDic;

	private readonly string dropItemPath_Note;

	private readonly string monsterSpawnWave_Note;

	private readonly int dropNoteIndexInWave_Note;

	private readonly string monsterSpawnWave_NoteSkill;

	private readonly int dropNoteIndexInWave_NoteSkill;

	private readonly int tutorialCardId_NoteSkill;

	private readonly FP delay_TutorialCard_NoteSkill;

	private readonly FP waitTime_FreeBattle;

	private readonly string interactiveId_FreeBattle;

	private readonly Dictionary<int, int> _noteDic;

	private int _diedMonsterIndex;

	private int _dropNoteMonsterIndex;

	public unsafe override void OnLevelStart()
	{
		//Discarded unreachable code: IL_000d, IL_0024
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
		}
		_ = *(int*)(-1894060833);
		/*Error near IL_0009: Unknown opcode: 0xE8*/;
	}

	public override void OnTriggerNextTask(int taskId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1680027651;
		}
	}

	private void OnMonsterDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private void UpdateNoteData(Dictionary<int, int> dropNoteInfo, List<int> activeNoteSkillIds)
	{
		//Discarded unreachable code: IL_0012, IL_0014
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 212 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public unsafe override void OnTaskFinish(int taskId, bool isLastTask = false)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 4;
		/*Error near IL_0003: Invalid field token*/;
	}

	public override void OnLevelEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) > 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public TutorialLevelProcess_StarTowerNoteMechanism()
	{
		// ILSpy could not decompile this member: Error decompiling @0600BFA4 AIScript.DynamicLevel.TutorialLevelProcess_StarTowerNoteMechanism..ctor: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0600BFA4 AIScript.DynamicLevel.TutorialLevelProcess_StarTowerNoteMechanism..ctor
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeFieldReference() in ILReader.cs:line 251
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1201
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}
}
