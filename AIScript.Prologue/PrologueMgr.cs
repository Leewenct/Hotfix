using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AIScript.Prologue;

public class PrologueMgr : AIBase
{
	public enum Status
	{
		Enter,
		FirstPart,
		SencondPart,
		ThirdPart,
		End_Sec
	}

	public static PrologueMgr Ins;

	public string key_npcTargetPos;

	public Transform npcTargetPos;

	public List<string> key_edgeOBBs;

	public List<WorldOBB> edgeOBBs;

	public string key_endOBB_1;

	public WorldOBB endOBB_1;

	public string key_preSlidePos;

	public Transform preSlidePos;

	public string key_runOBB;

	public WorldOBB runOBB;

	public string key_monsterOBB;

	public WorldOBB monsterOBB;

	public string key_battle2StartPoint;

	public Transform battle2StartPoint;

	public string key_climbStartPos;

	public Transform climbStartPos;

	public string key_sandstormOBB;

	public WorldOBB sandstormOBB;

	public string key_climbEndPos;

	public Transform climbEndPos;

	public string key_climbOBB;

	public WorldOBB climbOBB;

	public string key_endOBB_3;

	public WorldOBB endOBB_3;

	public string key_EndPos;

	public Transform EndPos;

	private LogicEntity entity;

	public RefTool refTool;

	private readonly Status curStatus;

	private IState curState;

	private readonly Dictionary<Status, IState> dicState;

	public Transform cacheCameraBeacon;

	public SimpleMonsterAdventrueActor monsterActor;

	public SimplePlayerAdventureActor playerActor;

	public void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xBE*/;
		}
	}

	public void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
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
		}
	}

	public unsafe void OnLevelStart()
	{
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Not a type handle*/;
	}

	public void OnLevelStop()
	{
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	public void ChangeState(Status status)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
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
		}
	}

	public unsafe PrologueMgr()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
